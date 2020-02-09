using Fiesta.FileFormats.Map.ShineMapData;
using System;
using System.IO;
using System.Windows.Forms;
using Fiesta.FileFormats.Map.ShineMapData.Elements;
using System.Linq;
using SHMDEditor.Tabs;

namespace SHMDEditor
{
	public partial class SHMDEditor : Form
	{
		public string Path;
		public SHMD SHMD;
		public General General;

		public SHMDEditor()
		{
			InitializeComponent();

			AddSkyObjectTextBox.AutoSize = false;
			AddSkyObjectTextBox.Height = 22;

			AddWaterObjectTextBox.AutoSize = false;
			AddWaterObjectTextBox.Height = 22;

			AddGroundObjectTextBox.AutoSize = false;
			AddGroundObjectTextBox.Height = 22;

			AddMapObjectTextBox.AutoSize = false;
			AddMapObjectTextBox.Height = 22;

			CheckComponents(false);
		}

		private void SHMDEditor_Paint(object sender, PaintEventArgs e)
		{
			CheckComponents(SHMD != null);
		}

		private void CheckComponents(bool value)
		{
			// Menu Items
			SaveMenu.Enabled = value;
			SaveAsMenu.Enabled = value;
			CloseMenu.Enabled = value;

			// SkyObject Items
			DeleteSelectedSkyObjectButton.Enabled = value && SHMD.Sky.MapElements.Count != 0;
			AddSkyObjectTextBox.Enabled = value;
			AddSkyObjectButton.Enabled = value && !string.IsNullOrEmpty(AddSkyObjectTextBox.Text);

			// WaterObject Items
			DeleteSelectedWaterObjectButton.Enabled = value && SHMD.Water.MapElements.Count != 0;
			AddWaterObjectTextBox.Enabled = value;
			AddWaterObjectButton.Enabled = value && !string.IsNullOrEmpty(AddWaterObjectTextBox.Text);

			// GroundObjects Items
			DeleteSelectedGroundObjectButton.Enabled = value && SHMD.Water.MapElements.Count != 0;
			AddGroundObjectTextBox.Enabled = value;
			AddGroundObjectButton.Enabled = value && !string.IsNullOrEmpty(AddGroundObjectTextBox.Text);

			// MapObject Items
			DeleteSelectedMapObjectButton.Enabled = value && SHMD.MapObjects.Count != 0;
			AddMapObjectTextBox.Enabled = value;
			AddMapObjectButton.Enabled = value && !string.IsNullOrEmpty(AddMapObjectTextBox.Text);
		}

		private void OpenMenu_Click(object sender, EventArgs e)
		{
			var openFileDialog = new OpenFileDialog()
			{
				Filter = @"SHMD File (*.shmd)|*.shmd"
			};

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				Path = openFileDialog.FileName;
				SHMD = SHMD.Load(Path);
				General = new General(SHMD.Header, SHMD.GlobalLight, SHMD.Fog, SHMD.BackGroundColor, SHMD.Frustum, SHMD.DirectionLightAmbient, SHMD.DirectionLightDiffuse);

				GeneralProperties.SelectedObject = General;
				GeneralProperties.ExpandAllGridItems();

				SkyBox.DataSource = SHMD.Sky.MapElements;
				WaterBox.DataSource = SHMD.Water.MapElements;
				GroundObjectsBox.DataSource = SHMD.GroundObject.MapElements;
				MapObjectsBox.DataSource = SHMD.MapObjects;

				CheckComponents(true);
				Refresh();
			}
		}

		private void SaveMenu_Click(object sender, EventArgs e)
		{
			SHMD.Save(Path);
		}

		private void SaveAsMenu_Click(object sender, EventArgs e)
		{
			var saveFileDialog = new SaveFileDialog
			{
				Filter = @"SHMD File (*.shmd)|*.shmd",
				Title = @"Save SHMD file"
			};

			if (saveFileDialog.ShowDialog() == DialogResult.OK && saveFileDialog.FileName != "")
			{
				using (var fs = (FileStream)saveFileDialog.OpenFile())
				{
					var path = fs.Name;
					fs.Close();

					SHMD.Save(path);
				}
			}
		}

		private void CloseMenu_Click(object sender, EventArgs e)
		{
			SHMD = null;
			General = null;
			Path = string.Empty;
			GeneralProperties.SelectedObject = null;
			SkyBox.DataSource = null;
			MapObjectsBox.DataSource = null;
			CheckComponents(false);
			Refresh();
		}

		private void MapObjectsBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			MapObjectsProperties.SelectedObject = MapObjectsBox.SelectedItem;
		}

		private void AddMapObjectTextBox_TextChanged(object sender, EventArgs e)
		{
			AddMapObjectButton.Enabled = !string.IsNullOrEmpty(AddMapObjectTextBox.Text);
		}

		private void AddMapObjectButton_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(AddMapObjectTextBox.Text))
			{
				return;
			}

			var mo = new MapObject(AddMapObjectTextBox.Text);
			SHMD.MapObjects.Add(mo);
			MapObjectsBox.SelectedItem = mo;
			AddMapObjectTextBox.Text = "";
			CheckComponents(SHMD != null);
		}

		private void DeleteSelectedMapObjectButton_Click(object sender, EventArgs e)
		{
			if (MapObjectsBox.SelectedItem != null && MapObjectsBox.SelectedIndex >= 0 &&
			    MapObjectsBox.SelectedItem is MapObject item && SHMD.MapObjects.Contains(MapObjectsBox.SelectedItem))
			{
				SHMD.MapObjects.Remove(item);
				CheckComponents(SHMD != null);
			}
		}

		private void AddSkyObjectTextBox_TextChanged(object sender, EventArgs e)
		{
			AddSkyObjectButton.Enabled = !string.IsNullOrEmpty(AddSkyObjectTextBox.Text);
		}

		private void AddSkyObjectButton_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(AddSkyObjectTextBox.Text))
			{
				return;
			}

			var me = new MapElement(AddSkyObjectTextBox.Text);
			SHMD.Sky.MapElements.Add(me);
			SkyBox.SelectedItem = me;
			AddSkyObjectTextBox.Text = "";
			CheckComponents(SHMD != null);
		}

		private void DeleteSelectedSkyObjectButton_Click(object sender, EventArgs e)
		{
			if (SkyBox.SelectedItem != null && SkyBox.SelectedIndex >= 0 &&
			    SkyBox.SelectedItem is MapElement item && SHMD.Sky.MapElements.Contains(SkyBox.SelectedItem))
			{
				SHMD.Sky.MapElements.Remove(item);
				CheckComponents(SHMD != null);
			}
		}

        private void AddWaterObjectTextBox_TextChanged(object sender, EventArgs e)
        {
            AddWaterObjectButton.Enabled = !string.IsNullOrEmpty(AddWaterObjectTextBox.Text);
        }

        private void AddWaterObjectButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(AddWaterObjectTextBox.Text))
            {
	            return;
            }

            var me = new MapElement(AddWaterObjectTextBox.Text);
            SHMD.Water.MapElements.Add(me);
            WaterBox.SelectedItem = me;
            AddWaterObjectTextBox.Text = "";
            CheckComponents(SHMD != null);
		}

        private void DeleteSelectedWaterObjectButton_Click(object sender, EventArgs e)
        {
            if (WaterBox.SelectedItem != null && WaterBox.SelectedIndex >= 0 &&
                WaterBox.SelectedItem is MapElement item && SHMD.Water.MapElements.Contains(WaterBox.SelectedItem))
            {
                SHMD.Water.MapElements.Remove(item);
                CheckComponents(SHMD != null);
            }
        }

        private void AddGroundObjectTextBox_TextChanged(object sender, EventArgs e)
        {
	        AddGroundObjectButton.Enabled = !string.IsNullOrEmpty(AddWaterObjectTextBox.Text);
        }

        private void AddGroundObjectButton_Click(object sender, EventArgs e)
        {
	        if (string.IsNullOrEmpty(AddGroundObjectTextBox.Text))
	        {
		        return;
	        }

	        var me = new MapElement(AddGroundObjectTextBox.Text);
	        SHMD.GroundObject.MapElements.Add(me);
	        GroundObjectsBox.SelectedItem = me;
	        AddGroundObjectTextBox.Text = "";
	        CheckComponents(SHMD != null);
        }

        private void DeleteSelectedGroundObjectButton_Click(object sender, EventArgs e)
        {
	        if (GroundObjectsBox.SelectedItem != null && GroundObjectsBox.SelectedIndex >= 0 &&
	            GroundObjectsBox.SelectedItem is MapElement item && SHMD.GroundObject.MapElements.Contains(GroundObjectsBox.SelectedItem))
	        {
		        SHMD.GroundObject.MapElements.Remove(item);
		        CheckComponents(SHMD != null);
	        }
        }
	}
}
