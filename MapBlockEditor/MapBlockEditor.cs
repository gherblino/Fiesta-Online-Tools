using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Fiesta.FileFormats.Map;
using Fiesta.FileFormats.Map.ShineBlockInfo;
using MapBlockEditor.Properties;


//TODO: Add all the other functionality (AID/SHMD/SHBD)
//TODO: Add save ability for every part separately (AID, SBI, SHAB, SHBD, SHMD)
//TODO: Add option to click on a folder and say "Open With MapBlockEditor"
namespace MapBlockEditor
{
	public partial class MapBlockEditor : Form
	{
		private bool _hasSelectedPath;

		public static double ZoomScale = 1;
		public static MapBlockInformation MBI;
		public static List<TabPage> BackUp;

		public MapBlockEditor()
		{
			InitializeComponent();
			BackUp = GetCopyOfPages(MBETabControl);
		}

		private void MapBlockEditor_Load(object sender, EventArgs e)
		{
			SetStyle(ControlStyles.AllPaintingInWmPaint, true);
			SetStyle(ControlStyles.DoubleBuffer, true);
			SetStyle(ControlStyles.UserPaint, true);

			PictureBoxPanel.MouseWheel += PictureBoxPanel_MouseWheel;
		}

		private List<TabPage> GetCopyOfPages(TabControl tabControl)
		{
			var result = new List<TabPage>();

			foreach (TabPage tp in tabControl.TabPages)
			{
				result.Add(tp);
			}

			return result;
		}

		private void UpdateTabControl()
		{
			var i = 0;
			foreach (var tb in BackUp)
			{
				if (!MBETabControl.TabPages.ContainsKey(tb.Name))
				{
					MBETabControl.TabPages.Insert(i, tb);
				}

				i++;
			}
		}

		/******************************Tool Strip Menu Items ******************************/
		private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var folderBrowserDialog = new FolderBrowserDialog();

			if (Settings.Default.InitialPath.Length > 0)
			{
				folderBrowserDialog.SelectedPath = Settings.Default.InitialPath;
			}

			var dialogResult = folderBrowserDialog.ShowDialog();

			if (dialogResult == DialogResult.OK)
			{
				_hasSelectedPath = true;

				// Set default path to opened path
				Settings.Default.InitialPath = folderBrowserDialog.SelectedPath;
				Settings.Default.Save();

				var path = folderBrowserDialog.SelectedPath.TrimEnd(Path.DirectorySeparatorChar);
				var mapInx = path.Substring(path.LastIndexOf(Path.DirectorySeparatorChar) + 1);

				MBI = MapBlockInformation.Load(path, mapInx);

				PictureBox.Size = new Size(MBI.SHBD.XSize * 8, MBI.SHBD.YSize);
				PictureBox.Image = MBI.SHBD.Import();

				UpdateTabControl();
				//TODO: Figure out if ValueMember is relevant
				if (MBI.HasAID)
				{
					InitializeAID();
				}
				else
				{
//					MBETabControl.TabPages[0].Parent = null;
					MBETabControl.TabPages.RemoveByKey("AIDPage");
				}

				if (MBI.HasSBI)
				{
					InitializeSBI();
				}
				else
				{
//					MBETabControl.TabPages[1].Parent = null;
					MBETabControl.TabPages.RemoveByKey("SBIPage");
				}

				//TODO: Implement
				if (MBI.HasSHAB)
				{

				}
				else
				{
//					MBETabControl.TabPages[2].Parent = null;
					MBETabControl.TabPages.RemoveByKey("SHABPage");
				}

				if (MBI.HasSHMD)
				{
					InitializeSHMD();
				}
				else
				{
//					MBETabControl.TabPages[4].Parent = null;
					MBETabControl.TabPages.RemoveByKey("SHMDPage");
				}

				Draw(true);
			}
		}

		private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var folderBrowserDialog = new FolderBrowserDialog();

			if (Settings.Default.InitialPath.Length > 0)
			{
				folderBrowserDialog.SelectedPath = Settings.Default.InitialPath;
			}

			var dialogResult = folderBrowserDialog.ShowDialog();

			if (dialogResult == DialogResult.OK)
			{
				Settings.Default.InitialPath = folderBrowserDialog.SelectedPath;
				Settings.Default.Save();

				var path = folderBrowserDialog.SelectedPath.TrimEnd(Path.DirectorySeparatorChar);
				var mapInx = path.Substring(path.LastIndexOf(Path.DirectorySeparatorChar) + 1);

				MBI.SBI.Export(path + Path.DirectorySeparatorChar + mapInx + ".sbi");
				MessageBox.Show(@"Successfully saved the SBI file!");
			}
		}

		private void UpdateFormText(MouseEventArgs e)
		{
			if (MBI != null)
			{
				Text =
					$@"Fiesta Map Block Editor        ({e.X}, {e.Y})        ({MBI.BlockXSize}, {MBI.BlockYSize})        {ZoomScale}";
			}
		}

		private static Bitmap ReadBitmapFromBytes(string path)
		{
			byte[] bytes = File.ReadAllBytes(path);

			using (var ms = new MemoryStream(bytes))
			{
				Image img = Image.FromStream(ms);
				return (new Bitmap(img));
			}
		}

		public MapDoorBlockElement CreateNewDoorFromBitmap(Bitmap input)
		{
			var startX = (uint) 0;
			var startY = MBI.BlockYSize - (uint) input.Height;
			var endX = (uint) input.Width - 1;
			var endY = MBI.BlockYSize - 1;
			var newMBE = new MapDoorBlockElement("New", startX, startY, endX, endY, Color.Red);
			newMBE.SetBitmap(input);
			newMBE.SetData();
			newMBE.InitializeColor(Color.Red);
			return newMBE;
		}

		private void TempToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//TODO: Figure out how to make this work properly
//			MBI.SBI = new MapDoorArray
//			{
//				TotalHeadCount = 0,
//				Doors = new List<MapDoorBlockElement>()
//			};
//			MBI.HasSBI = true;
//
//			MBETabControl.TabPages.Add("SBI");
		}

		private void DeleteSelectedDoor()
		{
			var index = DoorsListBox.SelectedIndex;

			if (index >= 0)
			{
				MBI.SBI.Doors.RemoveAt(index);
				MBI.SBI.TotalHeadCount--;

				MBI.SBI.UpdateDoors();

				Draw(true);
			}
		}

		private void MapBlockEditorForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete)
			{
				DeleteSelectedDoor();
			}
		}

		// TODO: Check which tab is selected and change options depending on tab
		private void AddNewToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var openFileDialog = new OpenFileDialog
			{
				Filter = @"Bitmap File (*.bmp)|*.bmp",
			};

			if (openFileDialog.ShowDialog() != DialogResult.OK) return;

			var bitmap = ReadBitmapFromBytes(openFileDialog.FileName);

			if (MBI.SBI == null || MBI.SBI.TotalHeadCount == 0)
			{
				MBI.SBI = new MapDoorArray
				{
					Doors = new List<MapDoorBlockElement>(),
					TotalHeadCount = 0
				};

				DoorsListBox.DataSource = MBI.SBI.Doors;
				DoorsListBox.DisplayMember = "BlockName";
			}

			var element = CreateNewDoorFromBitmap(bitmap);

			// Add it to the door list and increment the count
			MBI.SBI.Doors.Add(element);
			++MBI.SBI.TotalHeadCount;
			MBI.SBI.UpdateDoors();
			Draw(true);
		}

		private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
		{
			_hasSelectedPath = false;
			ZoomScale = 1;
			MBI = null;
			Draw(true);
		}

		private void UpdateTabsElements()
		{
			if (MBETabControl.SelectedTab == null)
			{
				return;
			}

			var tab = MBETabControl.SelectedTab.Text;

			switch (tab)
			{
				case "AID":
					//TODO: Make it so it shows the AID
					DoorsGroupBox.Hide();
					break;

				case "SBI":
					//TODO: Make it so it shows the SBI
					DoorsGroupBox.Show();
					break;

				case "SHAB":
					//TODO: Make it so it shows the SHAB
					DoorsGroupBox.Hide();
					break;

				case "SHBD":
					//TODO: Make it so it shows the SHBD
					DoorsGroupBox.Hide();
					break;

				case "SHMD":
					//TODO: Make it so it shows the SHMD
					DoorsGroupBox.Hide();
					break;

				default:
					return;
			}
		}

		private void MBETabControl_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateTabsElements();
		}
	}
}