using System;
using System.Windows.Forms;
using Fiesta.FileFormats.ActionInfo;
using Fiesta.FileFormats.ActionInfo.Types;
using Fiesta.FileFormats.ActionInfo.Types.Effect;
using Fiesta.FileFormats.ActionInfo.Types.Sound;

namespace ActionEditor
{
	public partial class ActionEditor : Form
	{
		public string Path;
		public ActionInfoSet AIS;

		public ActionEditor()
		{
			InitializeComponent();
		}

		private void ActionEditor_Load(object sender, EventArgs e)
		{
			ActionInfoList.DisplayMember = "ActionName";
			ActionInfoList.ValueMember = "ActionName";
		}

		private void OpenActionInfo(string path)
		{
			Path = path;
			AIS = ActionInfoSet.Load(path);
			ActionInfoList.DataSource = AIS.ActionInfoData;
			ActionInfoProperties.ExpandAllGridItems();
		}

		private void OpenMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog
			{
				Filter = "DAT File (*.dat)|*.dat",
			};

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				OpenActionInfo(openFileDialog.FileName);
			}
		}

		private void SaveMenuItem_Click(object sender, EventArgs e)
		{
			AIS.Save(Path);
		}

		private void SaveAsMenu_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog
			{
				Filter = "Action File (*.dat)|*.dat",
				Title = "Save DAT file"
			};

			if (saveFileDialog.ShowDialog() == DialogResult.OK && saveFileDialog.FileName != "")
			{
				AIS.Save(saveFileDialog.FileName);
			}
		}

		private void AddMenuItem_Click(object sender, EventArgs e)
		{
			if (AIS != null)
			{
				ActionInfo ai = new ActionInfo((ushort) ActionInfoSet.Total, "New InxName", "New ActionName",
					WeaponDemand.None, "New", 0, WeaponType.None,  new Effect(), new Sound());

				AIS.ActionInfoData.Add(ai);
				ActionInfoSet.Total++;

				ActionInfoList.DataSource = AIS.ActionInfoData;
				ActionInfoList.SelectedItem = ai;
				ActionInfoProperties.SelectedObject = ai;
				//ActionInfoProperties.ExpandAllGridItems();
				Refresh();
			}
		}

		private void DeleteMenuItem_Click(object sender, EventArgs e)
		{
			if (ActionInfoList.SelectedIndex >= 0)
			{
				AIS.ActionInfoData.RemoveAt(ActionInfoList.SelectedIndex);
				ActionInfoSet.Total--;
			}
		}

		private void ActionInfoList_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (ActionInfoList.SelectedItem != null)
			{
				ActionInfo ai = (ActionInfo)ActionInfoList.SelectedItem;

				ActionInfoProperties.SelectedObject = ai;
				//ActionInfoProperties.ExpandAllGridItems();
			}
		}

		private void ActionInfoList_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				e.Effect = DragDropEffects.Copy;
			}
		}

		private void ActionInfoList_DragDrop(object sender, DragEventArgs e)
		{
			string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
			OpenActionInfo(files[0]);
		}
	}
}
