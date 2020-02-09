using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using Fiesta.FileFormats.Map.AreaInfoData;
using Fiesta.FileFormats.Map.AreaInfoData.AreaData;

//TODO: Look into making this visual
namespace AIDEditor
{
	public partial class AIDEditorForm : Form
	{
		public AID AID;
		private string _path;
		private string _mapInx;

		public AIDEditorForm()
		{
			InitializeComponent();
			UpdateButtons(false);
		}

		private void UpdateButtons(bool value)
		{
			editToolStripMenuItem.Enabled = value;
			addToolStripMenuItem.Enabled = value;
			deleteToolStripMenuItem.Enabled = AID != null && AID.Data.Count > 0;
			saveToolStripMenuItem.Enabled = value;
			Refresh();
		}

		private void AIDEditorForm_Load(object sender, EventArgs e)
		{
			AIDListBox.DisplayMember = "Name";
			AIDListBox.ValueMember = "Name";
		}

		private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var openFileDialog = new OpenFileDialog
			{
				Filter = @"AID File (*.aid)|*.aid"
			};

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				_path = openFileDialog.FileName.TrimEnd(Path.DirectorySeparatorChar);
				_mapInx = _path.Substring(_path.LastIndexOf(Path.DirectorySeparatorChar) + 1);

				AID = AID.Load(openFileDialog.FileName);

				AIDListBox.DataSource = AID.Data;
				AIDPropertyGrid.ExpandAllGridItems();
				UpdateButtons(true);
			}
		}

		private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AID.Save(_path, _mapInx);
		}

		private void AddToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AreaInfoData aid = new AreaInfoData("New", AreaType.Square, new AE_Square(0, 0, 0, 0, 0));
			AID.Data.Add(aid);
			AID.TotalDataCount++;

			AIDListBox.DataSource = AID.Data;
			AIDPropertyGrid.ExpandAllGridItems();
			Refresh();
		}

		private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (AIDListBox.SelectedIndex >= 0)
			{
				AID.Data.RemoveAt(AIDListBox.SelectedIndex);
				UpdateButtons(true);
			}
		}

		private void AIDListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (AIDListBox.SelectedItem == null)
			{
				return;
			}

			var aid = (AreaInfoData)AIDListBox.SelectedItem;
			aid.PropertyChanged += AID_PropertyChanged;

			AIDPropertyGrid.SelectedObject = aid;
			AIDPropertyGrid.ExpandAllGridItems();
		}

		private void AID_PropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			AIDPropertyGrid.Refresh();
		}
	}
}