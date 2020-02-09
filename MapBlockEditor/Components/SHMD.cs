using System;
using System.Linq;
using Fiesta.FileFormats.Map.ShineMapData.Elements;
using SHMDEditor.Tabs;

namespace MapBlockEditor
{
	partial class MapBlockEditor
	{
		public General General;

		public void InitializeSHMD()
		{
			AddSkyObjectTextBox.AutoSize = false;
			AddSkyObjectTextBox.Height = 22;

			AddWaterObjectTextBox.AutoSize = false;
			AddWaterObjectTextBox.Height = 22;

			AddGroundObjectTextBox.AutoSize = false;
			AddGroundObjectTextBox.Height = 22;

			AddMapObjectTextBox.AutoSize = false;
			AddMapObjectTextBox.Height = 22;
			
			General = new General(MBI.SHMD.Header, MBI.SHMD.GlobalLight, MBI.SHMD.Fog, MBI.SHMD.BackGroundColor, MBI.SHMD.Frustum, MBI.SHMD.DirectionLightAmbient, MBI.SHMD.DirectionLightDiffuse);

			GeneralProperties.SelectedObject = General;
			GeneralProperties.ExpandAllGridItems();

			SkyBox.DataSource = MBI.SHMD.Sky.MapElements;
			WaterBox.DataSource = MBI.SHMD.Water.MapElements;
			GroundObjectsBox.DataSource = MBI.SHMD.GroundObject.MapElements;
			MapObjectsBox.DataSource = MBI.SHMD.MapObjects;

			CheckSHMDComponents(true);
			Refresh();
		}

		private void CheckSHMDComponents(bool value)
		{
			//TODO: Make this work?
//			// Menu Items
//			SaveMenu.Enabled = value;
//			SaveAsMenu.Enabled = value;
//			CloseMenu.Enabled = value;

			// SkyObject Items
			DeleteSelectedSkyObjectButton.Enabled = value && MBI.SHMD.Sky.MapElements.Count != 0;
			AddSkyObjectTextBox.Enabled = value;
			AddSkyObjectButton.Enabled = value && !string.IsNullOrEmpty(AddSkyObjectTextBox.Text);

			// WaterObject Items
			DeleteSelectedWaterObjectButton.Enabled = value && MBI.SHMD.Water.MapElements.Count != 0;
			AddWaterObjectTextBox.Enabled = value;
			AddWaterObjectButton.Enabled = value && !string.IsNullOrEmpty(AddWaterObjectTextBox.Text);

			// GroundObjects Items
			DeleteSelectedGroundObjectButton.Enabled = value && MBI.SHMD.GroundObject.MapElements.Count != 0;
			AddGroundObjectTextBox.Enabled = value;
			AddGroundObjectButton.Enabled = value && !string.IsNullOrEmpty(AddGroundObjectTextBox.Text);

			// MapObject Items
			DeleteSelectedMapObjectButton.Enabled = value && MBI.SHMD.MapObjects.Count != 0;
			AddMapObjectTextBox.Enabled = value;
			AddMapObjectButton.Enabled = value && !string.IsNullOrEmpty(AddMapObjectTextBox.Text);
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
			MBI.SHMD.MapObjects.Add(mo);
			MapObjectsBox.SelectedItem = mo;
			AddMapObjectTextBox.Text = "";
			CheckSHMDComponents(MBI.SHMD != null);
		}

		private void DeleteSelectedMapObjectButton_Click(object sender, EventArgs e)
		{
			if (MapObjectsBox.SelectedItem != null && MapObjectsBox.SelectedIndex >= 0 &&
				MapObjectsBox.SelectedItem is MapObject item && MBI.SHMD.MapObjects.Contains(MapObjectsBox.SelectedItem))
			{
				MBI.SHMD.MapObjects.Remove(item);
				CheckSHMDComponents(MBI.SHMD != null);
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
			MBI.SHMD.Sky.MapElements.Add(me);
			SkyBox.SelectedItem = me;
			AddSkyObjectTextBox.Text = "";
			CheckSHMDComponents(MBI.SHMD != null);
		}

		private void DeleteSelectedSkyObjectButton_Click(object sender, EventArgs e)
		{
			if (SkyBox.SelectedItem != null && SkyBox.SelectedIndex >= 0 &&
				SkyBox.SelectedItem is MapElement item && MBI.SHMD.Sky.MapElements.Contains(SkyBox.SelectedItem))
			{
				MBI.SHMD.Sky.MapElements.Remove(item);
				CheckSHMDComponents(MBI.SHMD != null);
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
			MBI.SHMD.Water.MapElements.Add(me);
			WaterBox.SelectedItem = me;
			AddWaterObjectTextBox.Text = "";
			CheckSHMDComponents(MBI.SHMD != null);
		}

		private void DeleteSelectedWaterObjectButton_Click(object sender, EventArgs e)
		{
			if (WaterBox.SelectedItem != null && WaterBox.SelectedIndex >= 0 &&
				WaterBox.SelectedItem is MapElement item && MBI.SHMD.Water.MapElements.Contains(WaterBox.SelectedItem))
			{
				MBI.SHMD.Water.MapElements.Remove(item);
				CheckSHMDComponents(MBI.SHMD != null);
			}
		}

		private void AddGroundObjectTextBox_TextChanged(object sender, EventArgs e)
		{
			AddGroundObjectButton.Enabled = !string.IsNullOrEmpty(AddGroundObjectTextBox.Text);
		}

		private void AddGroundObjectButton_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(AddGroundObjectTextBox.Text))
			{
				return;
			}

			var me = new MapElement(AddGroundObjectTextBox.Text);
			MBI.SHMD.GroundObject.MapElements.Add(me);
			GroundObjectsBox.SelectedItem = me;
			AddGroundObjectTextBox.Text = "";
			CheckSHMDComponents(MBI.SHMD != null);
		}

		private void DeleteSelectedGroundObjectButton_Click(object sender, EventArgs e)
		{
			if (GroundObjectsBox.SelectedItem != null && GroundObjectsBox.SelectedIndex >= 0 &&
			    GroundObjectsBox.SelectedItem is MapElement item && MBI.SHMD.GroundObject.MapElements.Contains(GroundObjectsBox.SelectedItem))
			{
				MBI.SHMD.GroundObject.MapElements.Remove(item);
				CheckSHMDComponents(MBI.SHMD != null);
			}
		}
	}
}
