using System;
using System.Drawing;
using System.Windows.Forms;

namespace MapBlockEditor
{
	partial class MapBlockEditor
	{
		private void InitializeSBI()
		{
			DoorsListBox.DisplayMember = "BlockName";
			DoorsListBox.ValueMember = "BlockName";
			DoorsListBox.DataSource = MBI.SBI.Doors;
			DoorPropertyGrid.ExpandAllGridItems();
		}

		private void Draw(bool refreshDoors)
		{
			if (!_hasSelectedPath)
			{
				return;
			}

			PictureBox.Size = new Size((int)(PictureBox.Image.Width * ZoomScale), (int)(PictureBox.Image.Height * ZoomScale));
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
					Location = new Point((int)(mbe.StartX * ZoomScale), (int)((MBI.BlockYSize - mbe.StartY - mbe.GetHeight()) * ZoomScale)),
					Size = new Size((int)(mbe.GetWidth() * ZoomScale), (int)(mbe.GetHeight() * ZoomScale)),
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
			var spb = (SelectablePictureBox)sender;
			DoorsListBox.SelectedItem = spb.MBE;
			spb.Focus();
		}

		private void UpdatePropertyGridLocation(object sender, EventArgs e)
		{
			DoorPropertyGrid.Refresh();
		}

		private void PictureBoxPanel_MouseWheel(object sender, MouseEventArgs e)
		{
			if (ModifierKeys == Keys.Control && MBI != null && PictureBox.Image != null)
			{
				ZoomScale *= e.Delta < 0 ? 0.8 : 1.2;

				Draw(false);
			}
		}

		private void SetBackgroundImageToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (!_hasSelectedPath)
			{
				throw new Exception("Please select a map folder first!");
			}

			if (!MBI.HasAID || MBI.AID == null)
			{
				throw new Exception("Please make sure the selected map folder contains an .aid file!");
			}

			throw new NotImplementedException();
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

		private void PictureBox_MouseMove(object sender, MouseEventArgs e)
		{
			UpdateFormText(e);
		}
	}
}
