using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Fiesta.FileFormats.Map.ShineBlockData;
using Microsoft.Win32;

namespace SHBDEditor
{
	//TODO: Add "New SHBD" button
	//TODO: Add support for SHAB
	//TODO: Fix drawing without resizing image (automatically call the resize method upon starting?)
	//TODO: Add ability to drag SHAB/SHBD files into the editor and automatically open it
	//TODO: Add undo/redo functionality (https://stackoverflow.com/questions/4431920/how-to-implement-undo-functionality)
	//TODO: Refactor code
	public partial class SHBDEditor : Form
	{
		public string Path;
		public string MapInx;

		public SHBD Selected;
		public bool OpenedBmp;
		public bool OpenedSHBD;

		private double _zoomScale = 1.1;
		public int ImageWidth;
		public int ImageHeight;

		// Horizontal Scroll Bar Proportion
		public double HSBP;
		// Vertical Scroll Bar Proportion
		public double VSBP;

		public bool IsDrawing;
		private List<List<DrawPoint>> _strokes = new List<List<DrawPoint>>();
		private List<DrawPoint> _currStroke;

		public SHBDEditor()
		{
			InitializeComponent();

			SetAssociation();
		}

		private void SHBDEditor_Load(object sender, EventArgs e)
		{
			EnableComponents(false);
			IsDrawing = false;
			HSBP = VSBP = 0;

			using (var stream = new MemoryStream(Properties.Resources.pencil))
			{
				PictureBox.Cursor = new Cursor(stream);
			}

			string[] args = Environment.GetCommandLineArgs();

			if (args.Length == 1) return;
			Path = System.IO.Path.GetDirectoryName(args[1]);
			MapInx = System.IO.Path.GetFileNameWithoutExtension(args[1]);

			Open();
		}

		public void Open() 
		{
			EnableComponents(true);

			OpenedBmp = false;
			OpenedSHBD = true;

			Selected = SHBD.Load(GetFullPath());
			Selected.SetBitmap();

			PictureBox.Image = Selected.Bitmap.Clone(new Rectangle(0, 0, Selected.Bitmap.Width, Selected.Bitmap.Height), PixelFormat.DontCare);
			ImageWidth = PictureBox.Image.Width;
			ImageHeight = PictureBox.Image.Height;

			Refresh();
		}

		private void EnableComponents(bool value)
		{
			BrushSizeLabel.Enabled = value;
			BrushSize.Enabled = value;
			SaveMenu.Enabled = value;
			SaveAsMenu.Enabled = value;
			PictureBox.Enabled = value;
			ZoomBar.Enabled = value;
			isColoringBlack.Enabled = value;
			isColoringWhite.Enabled = value;
			CloseMenu.Enabled = value;

			Refresh();
		}

		private string GetFullPath(bool withExtension = true)
		{
			return Path + System.IO.Path.DirectorySeparatorChar + MapInx + (!withExtension ? "" : (OpenedBmp ? ".bmp" : ".shbd"));
		}

		private Color GetBrushColor()
		{
			return (isColoringBlack.Checked ? Color.Black : Color.White);
		}

		private Bitmap ReadBitmapFromBytes(string path)
		{
			var bytes = File.ReadAllBytes(path);

			using (var ms = new MemoryStream(bytes))
			{
				var img = Image.FromStream(ms);
				return (new Bitmap(img));
			}
		}

		// ====================================Menu Items====================================
		private void OpenMenu_Click(object sender, EventArgs e)
		{
			var openFileDialog = new OpenFileDialog
			{
				Filter = @"SHBD File (*.shbd)|*.shbd|Bitmap File (*.bmp)|*.bmp",
			};

			if (openFileDialog.ShowDialog() != DialogResult.OK) return;

			Path = System.IO.Path.GetDirectoryName(openFileDialog.FileName);
			MapInx = System.IO.Path.GetFileNameWithoutExtension(openFileDialog.FileName);
			EnableComponents(true);

			switch (openFileDialog.FilterIndex)
			{
				case 1:
					OpenedBmp = false;
					OpenedSHBD = true;
					Selected = SHBD.Load(GetFullPath());
					Selected.SetBitmap();
					break;

				case 2:
					OpenedBmp = true;
					OpenedSHBD = false;
					var bitmap = ReadBitmapFromBytes(openFileDialog.FileName);
					Selected = SHBD.Load(bitmap.Width / 8, bitmap.Height, bitmap);
					break;
			}

			PictureBox.Image = Selected.Bitmap.Clone(new Rectangle(0, 0, Selected.Bitmap.Width, Selected.Bitmap.Height), PixelFormat.DontCare);
			ImageWidth = PictureBox.Image.Width;
			ImageHeight = PictureBox.Image.Height;

			Refresh();
		}

		private void SaveMenu_Click(object sender, EventArgs e)
		{
			if (OpenedBmp)
			{
				PictureBox.Image.Save(GetFullPath(), ImageFormat.Bmp);
			}
			else if (OpenedSHBD)
			{
				Selected.Export(GetFullPath(), (Bitmap)PictureBox.Image, Selected.XSize, Selected.YSize);
			}
			else
			{
				throw new Exception("Trying to save an unsupported file extension!");
			}
		}

		private void SaveAsMenu_Click(object sender, EventArgs e)
		{
			var saveFileDialog = new SaveFileDialog
			{
				Filter = @"SHBD File (*.shbd)|*.shbd|Bitmap File (*.bmp)|*.bmp",
				Title = @"Save SHBD file"
			};

			if (saveFileDialog.ShowDialog() != DialogResult.OK || saveFileDialog.FileName == "") return;

			using (var fs = (FileStream)saveFileDialog.OpenFile())
			{
				switch (saveFileDialog.FilterIndex)
				{
					case 1:
						string selectedPath = fs.Name;
						fs.Close();

						if (OpenedBmp)
						{
							Selected.Export(selectedPath, (Bitmap)PictureBox.Image, Selected.XSize * 8, Selected.YSize);
						}
						else
						{
							Selected.Export(selectedPath, (Bitmap)PictureBox.Image, Selected.XSize, Selected.YSize);
						}

						break;

					case 2:
						PictureBox.Image.Save(fs, ImageFormat.Bmp);
						break;
				}
			}
		}

		private void CloseMenu_Click(object sender, EventArgs e)
		{
			Selected = null;
			PictureBox.Image = null;
			EnableComponents(false);
			IsDrawing = false;
		}

		private void UpdatePictureBoxSize()
		{
			if (ZoomBar.Value > 0)
			{
				PictureBox.Size = new Size((int)(ImageWidth * Math.Pow(_zoomScale, ZoomBar.Value)), (int)(ImageHeight * Math.Pow(_zoomScale, ZoomBar.Value)));
			}
			else
			{
				PictureBox.Size = new Size((int)(ImageWidth / (Math.Pow(_zoomScale, -ZoomBar.Value + 1))), (int)(ImageHeight / (Math.Pow(_zoomScale, -ZoomBar.Value + 1))));
			}
		}

		// =====================================Zooming======================================
		//TODO: Fix zooming (make it more fluent)
		private void ZoomBar_Scroll(object sender, EventArgs e)
		{
			if (Selected != null)
			{
				var hsbMax = PanelGroupBox.HorizontalScroll.Maximum - PanelGroupBox.HorizontalScroll.LargeChange - 1;
				var vsbMax = PanelGroupBox.VerticalScroll.Maximum - PanelGroupBox.VerticalScroll.LargeChange - 1;

				HSBP = PanelGroupBox.HorizontalScroll.Value == 0 ? 0 : (double)PanelGroupBox.HorizontalScroll.Value / hsbMax;
				VSBP = PanelGroupBox.VerticalScroll.Value == 0 ? 0 : (double)PanelGroupBox.VerticalScroll.Value / vsbMax;

				UpdatePictureBoxSize();

				hsbMax = PanelGroupBox.HorizontalScroll.Maximum - PanelGroupBox.HorizontalScroll.LargeChange - 1;
				vsbMax = PanelGroupBox.VerticalScroll.Maximum - PanelGroupBox.VerticalScroll.LargeChange - 1;

				PanelGroupBox.HorizontalScroll.Value = (int)(HSBP * hsbMax);
				PanelGroupBox.VerticalScroll.Value = (int)(VSBP * vsbMax);
				PanelGroupBox.PerformLayout();
			}

			Refresh();
		}

		// =====================================Drawing======================================
		private void IsColoringWhite_CheckedChanged(object sender, EventArgs e)
		{
			if (isColoringBlack.Enabled)
			{
				isColoringBlack.Checked = (!isColoringWhite.Checked && isColoringBlack.Checked);
			}
		}

		private void IsColoringBlack_CheckedChanged(object sender, EventArgs e)
		{
			if (isColoringWhite.Enabled)
			{
				isColoringWhite.Checked = (!isColoringBlack.Checked && isColoringWhite.Checked);
			}
		}

		private void PictureBox_MouseDown(object sender, MouseEventArgs e)
		{
			IsDrawing = true;
			_currStroke = new List<DrawPoint>();

			if (ZoomBar.Value > 0)
			{
				float scale = (float)(Math.Pow(_zoomScale, ZoomBar.Value));
				_currStroke.Add(new DrawPoint((e.X / scale), (e.Y / scale), GetBrushColor(), (float)BrushSize.Value));
			}
			else
			{
				float scale = (float)(Math.Pow(_zoomScale, -ZoomBar.Value + 1));
				_currStroke.Add(new DrawPoint((e.X * scale), (e.Y * scale), GetBrushColor(), (float)BrushSize.Value));
			}

			_strokes.Add(_currStroke);
		}

		private void PictureBox_MouseMove(object sender, MouseEventArgs e)
		{
			UpdatePictureBoxSize();

			if (Selected == null) return;

			Text = $@"Fiesta SHBD Editor        ({e.X}, {e.Y})        ({Selected.XSize * 8}, {Selected.YSize})";

			if (!IsDrawing) return;

			if (ZoomBar.Value > 0)
			{
				var scale = (float)(Math.Pow(_zoomScale, ZoomBar.Value));
				_currStroke.Add(new DrawPoint(e.X / scale, e.Y / scale, GetBrushColor(), (float)BrushSize.Value));
			}
			else
			{
				var scale = (float)(Math.Pow(_zoomScale, -ZoomBar.Value + 1));
				_currStroke.Add(new DrawPoint(e.X * scale, e.Y * scale, GetBrushColor(), (float)BrushSize.Value));
			}

			Refresh();
		}

		private void PictureBox_MouseUp(object sender, MouseEventArgs e)
		{
			IsDrawing = false;
		}

		//TODO: Fix drawing, this shit is trash (doesn't even save properly apparently)
		private void PictureBox_Paint(object sender, PaintEventArgs e)
		{
			DoubleBuffered = true;

			if (IsDrawing && Selected != null)
			{
				Graphics g = Graphics.FromImage(PictureBox.Image);
				g.SmoothingMode = SmoothingMode.HighQuality;
				g.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
				g.InterpolationMode = InterpolationMode.High;

				if (_strokes.Count == 1)
				{
					List <DrawPoint> point = _strokes[0];
					g.DrawRectangle(new Pen(point[1].color), point[1].X, point[0].Y, 1, 1);
				}

				foreach (List<DrawPoint> stroke in _strokes.Where(x => x.Count > 1))
				{
					for (int i = 0; i < stroke.Count - 1; i++)
					{
						DrawPoint dp1 = stroke[i];
						DrawPoint dp2 = stroke[i + 1];
						Brush brush = new SolidBrush(dp1.color);
						g.DrawLine(new Pen(brush, dp1.brushSize), dp1.X - 5, dp1.Y + 5, dp2.X - 5, dp2.Y + 5);
					}
				}				
			}
		}

		// ===================================Association====================================
		//TODO: Fix File Association properly! (Also make it so that when you open an SHBD (double click), it automatically loads it)
		private void SetAssociation()
		{
			var isAso = FileAssociation.AssociationCheck(".shbd", "SHBD Tool");

			if (!isAso)
			{
				var result = MessageBox.Show(@"Do you want to associate this tool with SHBD files?", @"SHBD", MessageBoxButtons.YesNo);
				if (result == DialogResult.Yes) CreateAssociation();
			}

			SetRegistryInfo();
		}

		private void CreateAssociation()
		{
			string[] openWithList = { "notepad.exe", "wordpad.exe" };
			FileAssociation.AssociationCreation(".shbd", "SHBD Tool", "application/myfile", openWithList, true, "SHBD Editor");
		}

		private void SetRegistryInfo()
		{
			var assemblyName = Assembly.GetExecutingAssembly().GetName().Name;
			var rK = Registry.CurrentUser.CreateSubKey(@"Software\\" + Assembly.GetExecutingAssembly().GetName().Name + "\\Encoding", RegistryKeyPermissionCheck.ReadWriteSubTree);
			string eT;

			try
			{
				eT = Registry.CurrentUser.OpenSubKey(@"Software\\" + assemblyName + "\\Encoding")?.GetValue("0").ToString();
			}
			catch (NullReferenceException)
			{
				rK?.SetValue("0", "ISO-8859-1");
				eT = Registry.CurrentUser.OpenSubKey(@"Software\\" + assemblyName + "\\Encoding")?.GetValue("0").ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show(@"An error occurred trying to get encoding type: " + ex.Message);
			}
		}

		private void TempToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var hsbMax = PanelGroupBox.HorizontalScroll.Maximum - PanelGroupBox.HorizontalScroll.LargeChange - 1;
			var vsbMax = PanelGroupBox.VerticalScroll.Maximum - PanelGroupBox.VerticalScroll.LargeChange - 1;

			HSBP = PanelGroupBox.HorizontalScroll.Value == 0 ? 0 : (double)PanelGroupBox.HorizontalScroll.Value / hsbMax;
			VSBP = PanelGroupBox.VerticalScroll.Value == 0 ? 0 : (double)PanelGroupBox.VerticalScroll.Value / vsbMax;

			MessageBox.Show(ZoomBar.Value.ToString());
			MessageBox.Show(
				$"HSBP: {HSBP}\tHVal: {PanelGroupBox.HorizontalScroll.Value}\tHMax: {hsbMax}\nVSBP: {VSBP}\tVVal: {PanelGroupBox.VerticalScroll.Value}\tVMax: {vsbMax}");
		}
	}
}
