using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Fiesta.FileFormats.Map;
using Fiesta.FileFormats.Map.ShineBlockInfo;

//TODO: Add checks for dragging so you cannot overflow (go out of bounds, just like my GraphEditor for OOP)
//TODO: Make it so when you click on the PropertyGrid, it puts focus on the item and adjusts scrollbar accordingly
//TODO: Add Duplicate Selected button (contextmenu?)
//TODO: Add delete all button
//TODO: Add Create New button
//TODO: Add Import SHBD button (and perhaps make it not automatically try to load the SHBD?)
//TODO: Add independence from MBI
//TODO: Add multiple select in ListBox so multiple can be deleted
//TODO: Fix zooming (if you zoom in, it will also scroll up/down on the scrollbar in the panel) [look at SHBD]
//TODO: Add undo/redo functionality (https://stackoverflow.com/questions/4431920/how-to-implement-undo-functionality)
//TODO: Add checks before saving (doors within bounds, no duplicate names, correct distances between each door)
//TODO: Add context menu strip for the PictureBoxes
/*TODO: Add functionality to disable Form elements properly
		- Cannot press any Save button if no folder is selected
		- Cannot click on the MenuStripItem "Element" if no SBI is selected
		- 
*/
namespace SBIEditor
{
	public partial class SBIEditor : Form
	{
		public bool HasSelectedPath;
		public string FullPathAndFileName;
		public string MapInx;
		public string MapPath;
		public static MapBlockInformation MBI;

		public SBIEditor()
		{
			InitializeComponent();
		}

		private void Draw(bool refreshDoors)
		{
			PictureBox.Size = new Size(PictureBox.Image.Width, PictureBox.Image.Height);
			PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
			PictureBox.Controls.Clear();

			if (!HasSelectedPath)
			{
				return;
			}

			PictureBox.Size = new Size(PictureBox.Image.Width, PictureBox.Image.Height);
			PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
			PictureBox.Controls.Clear();

			// If the SBI is invalid, we return
			if (MBI == null || !MBI.HasSBI || MBI.SBI.Doors == null)
			{
				return;
			}

			foreach (var mbe in MBI.SBI.Doors)
			{
				if (!mbe.IsVisible) continue;

				var spb = new SelectablePictureBox(mbe)
				{
					Location = new Point((int)(mbe.StartX), (int)(MBI.BlockYSize - mbe.StartY - mbe.GetHeight())),
					Size = new Size(mbe.GetWidth(), mbe.GetHeight()),
					Image = mbe.Bitmap,
					SizeMode = PictureBoxSizeMode.StretchImage,
					BackColor = Color.Transparent
				};

				spb.UpdatedLocation += UpdatePropertyGridLocation;
				spb.UpdatedSelected += UpdatePropertyGridSelection;

				PictureBox.Controls.Add(spb);
			}

			if (refreshDoors)
			{
				DoorsListBox.DataSource = null;
				DoorsListBox.DataSource = MBI.SBI.Doors;
				DoorsListBox.DisplayMember = null;
				DoorsListBox.DisplayMember = "BlockName";
			}
		}

		private void UpdatePropertyGridSelection(object sender, EventArgs e)
		{
			var spb = (SelectablePictureBox) sender;
			DoorsListBox.SelectedItem = spb.MBE;
			spb.Focus();
		}

		private void UpdatePropertyGridLocation(object sender, EventArgs e)
		{
			DoorPropertyGrid.Refresh();
		}

		private void DoorsListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			DoorPropertyGrid.SelectedObject = DoorsListBox.SelectedItem;
		}

		private void DoorPropertyGrid_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
		{
			DoorsListBox.DisplayMember = null;
			DoorsListBox.DisplayMember = "BlockName";
			Draw(false);
		}

		private void UpdateFormText(MouseEventArgs e)
		{
			if (MBI != null)
			{
				Text = $@"SBI Editor                {MapInx}.sbi                ({e.X}, {e.Y})                ({MBI.BlockXSize}, {MBI.BlockYSize})";
			}
		}

		private void PictureBox_MouseMove(object sender, MouseEventArgs e)
		{
			UpdateFormText(e);
		}

		private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var openFileDialog = new OpenFileDialog
			{
				Filter = @"SBI File (*.sbi)|*.sbi"
			};

			var dialogResult = openFileDialog.ShowDialog();

			if (dialogResult == DialogResult.OK)
			{
				HasSelectedPath = true;

				FullPathAndFileName = openFileDialog.FileName;
				MapPath = Path.GetDirectoryName(openFileDialog.FileName);
				MapInx = Path.GetFileNameWithoutExtension(FullPathAndFileName);

				MBI = MapBlockInformation.LoadSBI(MapPath, MapInx);

				PictureBox.Size = new Size(MBI.SHBD.XSize * 8, MBI.SHBD.YSize);
				PictureBox.Image = MBI.SHBD.Import();

				Draw(true);

				DoorPropertyGrid.ExpandAllGridItems();
				DoorsGroupBox.Show();
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
			const uint startX = 0;
			var startY = MBI.BlockYSize - (uint)input.Height;
			var endX = (uint)input.Width - 1;
			var endY = MBI.BlockYSize - 1;
			var newMBE = new MapDoorBlockElement("New", startX, startY, endX, endY, Color.Red);
			newMBE.SetBitmap(input);
			newMBE.SetData();
			newMBE.InitializeColor(Color.Red);
			return newMBE;
		}

		private void AddNewToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var openFileDialog = new OpenFileDialog
			{
				Filter = @"Bitmap File (*.bmp)|*.bmp",
			};

			if (openFileDialog.ShowDialog() != DialogResult.OK) return;

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

			var element = CreateNewDoorFromBitmap(ReadBitmapFromBytes(openFileDialog.FileName));

			// Add it to the door list and increment the count
			MBI.SBI.Doors.Add(element);
			MBI.SBI.TotalHeadCount++;
			MBI.SBI.UpdateDoors();

			// Enable the delete button if it is disabled
			if (!deleteToolStripMenuItem.Enabled)
			{
				deleteToolStripMenuItem.Enabled = true;
			}

			Draw(true);
		}

		private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
		{
			HasSelectedPath = false;
			MBI = null;
			Draw(true);
			DoorsGroupBox.Hide();
			PictureBox.Image = null;
			PictureBox.Size = new Size(0,0);
			SaveMenuItem.Enabled = false;
			SaveAsMenuItem.Enabled = false;
		}

		private void DeleteSelectedDoor()
		{
			var index = DoorsListBox.SelectedIndex;

			if (index >= 0)
			{
				MBI.SBI.Doors.RemoveAt(index);
				MBI.SBI.TotalHeadCount--;

				MBI.SBI.UpdateDoors();

				if (MBI.SBI.TotalHeadCount == 0)
				{
					deleteToolStripMenuItem.Enabled = false;
				}

				Draw(true);
			}
		}

		private void SBIEditor_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete)
			{
				DeleteSelectedDoor();
			}
		}

		private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DeleteSelectedDoor();
		}

		private void SaveMenuItem_Click(object sender, EventArgs e)
		{
			MBI.SBI.Export(FullPathAndFileName);
			MessageBox.Show($@"{MapInx}.sbi has successfully been saved!");
		}

		private void SaveAsMenuItem_Click(object sender, EventArgs e)
		{
			var saveFileDialog = new SaveFileDialog
			{
				Filter = @"SBI File (*.sbi)|*.sbi",
				Title = @"Save SBI file"
			};

			if (saveFileDialog.ShowDialog() != DialogResult.OK || saveFileDialog.FileName == "") return;

			using (var fs = (FileStream)saveFileDialog.OpenFile())
			{
				var selectedPath = fs.Name;
				fs.Close();
				MBI.SBI.Export(selectedPath);
			}
		}
	}
}