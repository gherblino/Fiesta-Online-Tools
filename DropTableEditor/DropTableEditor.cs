using DropTableEditor.Models;
using DropTableEditor.Shine;
using DropTableEditor.SHN;
using DropTableEditor.Tools;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DropTableEditor
{
    public partial class DropTableEditor : Form
    {
        private bool _isLoaded;
        public BindingList<Mob> Mobs { get; set; }
        public BindingList<ItemGroup> Groups { get; set; }
        public BindingList<string> Items { get; set; }
        public ShnFile ItemInfoServer { get; set; }
        public ShnFile MobInfo { get; set; }
        public ShineFile ItemDropGroup { get; set; }
        public ShineFile ItemDropTable { get; set; }

        public DropTableEditor()
        {
            InitializeComponent();
            ToggleControls(false);
        }

        private void MenuOpen_Click(object sender, EventArgs e)
        {
            OpenFiles();
        }

        private void OpenFiles()
        {
	        var dlg = new frmOpenFile();

	        if (dlg.ShowDialog() == DialogResult.OK)
	        {
		        LoadFiles(dlg);
	        }
        }

		private void MenuOpenFromShine_Click(object sender, EventArgs e)
		{
			var dlg = new FolderBrowserDialog();

			if (dlg.ShowDialog() == DialogResult.OK)
			{
				OpenFiles(dlg.SelectedPath);
			}
		}

		private void menuOpenFromPath_Click(object sender, EventArgs e)
		{
			OpenFiles(AppDomain.CurrentDomain.BaseDirectory);
		}

		private void OpenFiles(string path)
		{
			var dlg = new frmOpenFile();

			try
			{
				dlg.MobInfo = new ShnFile(Path.Combine(path, "MobInfo.shn"));
				dlg.ItemInfoServer = new ShnFile(Path.Combine(path, "ItemInfoServer.shn"));
				dlg.ItemDropGroup = new ShineFile(Path.Combine(path, "World/ItemDropGroup.txt"));
				dlg.ItemDropTable = new ShineFile(Path.Combine(path, "World/ItemDropTable.txt"));
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message, "Failed to open file");
			}

			LoadFiles(dlg);
		}

		public async void LoadFiles(frmOpenFile dlg)
		{
			Mobs = new BindingList<Mob>();
			Groups = new BindingList<ItemGroup>();
			Items = new BindingList<string>();

			ItemInfoServer = dlg.ItemInfoServer;
			MobInfo = dlg.MobInfo;
			ItemDropGroup = dlg.ItemDropGroup;
			ItemDropTable = dlg.ItemDropTable;

			ItemDropGroup.ReadFile();
			ItemDropTable.ReadFile();

			lblStatus.Text = @"Reading MobInfo..";
			await MobInfo.Open();

			lblStatus.Text = @"Reading ItemInfoServer..";
			await ItemInfoServer.Open();

			lblStatus.Text = @"Putting items in their groups..";
			await LoadGroups();
			lbItemGroups.DataSource = Groups;
			lbItemGroups.DisplayMember = "Index";

			lblStatus.Text = @"Reading Mobs..";
			await LoadMobs();

			lbMobs.DataSource = Mobs;
			lbMobs.DisplayMember = "InxName";

			await LoadItems();
			lbAllItems.DataSource = Items;

			lblStatus.Text = @"Ready";

			ToggleControls(true);
			_isLoaded = true;
		}

        private Task LoadItems()
        {
            return Task.Factory.StartNew(() =>
            {
                Items = new BindingList<string>(ItemInfoServer.Table.Rows
                    .Cast<DataRow>()
                    .Select(x => x["InxName"].ToString())
                    .ToList());
            });
        }

        private Task LoadGroups()
        {
            return Task.Factory.StartNew(() =>
            {
                foreach (var row in ItemDropGroup.DataSet.Tables[0].Rows.Cast<DataRow>())
                {
                    var group = new ItemGroup(row);

                    var items = ItemInfoServer.Table.Rows.Cast<DataRow>()
                        .Where(x =>
                            x["DropGroupA"].ToString() == group.Index ||
                            x["DropGroupB"].ToString() == group.Index)
                        .Select(x => x["InxName"].ToString());

                    group.Items = new BindingList<string>(items.ToList());
                    Groups.Add(group);
                }
            });
        }

        private Task LoadMobs()
        {
            return Task.Factory.StartNew(() =>
            {
                var mobs = MobInfo.Table.Rows.Cast<DataRow>()
                    .Where(x => Convert.ToInt32(x["IsNPC"]) == 0 &&
                                Convert.ToInt32(x["Type"]) != 6 &&
                                Convert.ToInt32(x["Type"]) != 12 &&
                                Convert.ToInt32(x["Type"]) != 13);


                foreach (var row in mobs)
                {
                    var mob = new Mob();
                    mob.MobLevel = Convert.ToByte(row["Level"]);
                    mob.InxName = row["InxName"].ToString();
                    mob.DropGroups = new BindingList<MobDropGroupEntry>();
                    mob.MinLevel = 1;
                    mob.MaxLevel = 150;

                    var dropRow = ItemDropTable.DataSet.Tables[0].Rows.Cast<DataRow>().FirstOrDefault(x => x["MobId"].ToString() == mob.InxName);

                    if (dropRow != null)
                    {
                        mob.MinLevel = Convert.ToInt32(dropRow["MinLevel"]);
                        mob.MaxLevel = Convert.ToInt32(dropRow["MaxLevel"]);
                        mob.MinCen = Convert.ToInt32(dropRow["MinCen"]);
                        mob.MaxCen = Convert.ToInt32(dropRow["MaxCen"]);
                        mob.CenRate = Convert.ToDecimal(dropRow["CenRate"]) / 10000;

                        for (int i = 1; i < 46; i++)
                        {
                            var grp = dropRow["DrItem" + i].ToString();
                            var grpRate = Convert.ToDecimal(dropRow["DrItem" + i + "R"]) / 10000;
                            var UpGradeMin = Convert.ToInt32(dropRow[$"UpGradeMin{i:D2}"]);
                            var UpGradeMax = Convert.ToInt32(dropRow[$"UpGradeMax{i:D2}"]);

                            if (grp != "-")
                            {
                                var group = Groups.FirstOrDefault(x => x.Index == grp);

                                if (group != null)
                                {
                                    mob.DropGroups.Add(new MobDropGroupEntry(group, grpRate, UpGradeMin, UpGradeMax));
                                }
                            }
                        }
                    }

                    Mobs.Add(mob);
                }
            });
        }

        private void LoadMobGroupView()
        {
	        btnSave.Tag = null;
	        txtGroupIndex.Clear();
	        nudGroupDropRate.Value = 1;

	        lvMobDropGroups.Items.Clear();

	        var mob = (Mob)lbMobs.SelectedItem;
	        MinCen.Value = mob.MinCen;
	        MaxCen.Value = mob.MaxCen;
	        CenRate.Value = mob.CenRate;

	        nudGroupDropRate.Value = 0;
	        UpGradeMin.Value = 0;
	        UpGradeMax.Value = 0;

	        foreach (var grp in ((Mob)lbMobs.SelectedItem).DropGroups)
	        {
		        var item = new ListViewItem(grp.Group.Index);

		        item.SubItems.AddRange(new string[] {
			        grp.DropRate + "%"
		        });

		        lvMobDropGroups.Items.Add(item);
	        }
        }

		private void LbItemGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            var group = ((ItemGroup)lbItemGroups.SelectedItem);
            if (group != null)
            {
                lbGroupItems.DataSource = group.Items;
                txtSelectedGroupName.Text = group.Index;
                nudMinimum.Value = group.Minimum;
                nudMaximum.Value = group.Maximum;
            }
        }

        private void TxtFilter_TextChanged(object sender, EventArgs e)
        {
            var filteredMobs = Mobs.Where(x => x.InxName.ToLower().Contains(txtFilter.Text.ToLower())).ToList();
            lbMobs.DataSource = filteredMobs;
            lbMobs.DisplayMember = "InxName";
        }

        private void LbMobs_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMobGroupView();
        }

        private void BtnRemoveGroup_Click(object sender, EventArgs e)
        {
            if (btnSave.Tag == null)
            {
                MessageBox.Show("You must select an item group first.");
                return;
            }

            var mob = (Mob)lbMobs.SelectedItem;
            var group = mob.DropGroups[Convert.ToInt32(btnSave.Tag)];
            mob.DropGroups.Remove(group);

            btnSave.Tag = null;
            nudGroupDropRate.Value = 0;
            txtGroupIndex.Text = "";

            LoadMobGroupView();
        }

        private void LvMobDropGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvMobDropGroups.SelectedIndices.Count <= 0)
                return;

            var mob = (Mob)lbMobs.SelectedItem;
            var index = lvMobDropGroups.Items[lvMobDropGroups.SelectedIndices[0]].SubItems[0].Text;
            var listItem = lbItemGroups.Items.Cast<ItemGroup>().FirstOrDefault(x => x.Index == index);

            if (listItem != null)
            {
                txtGroupIndex.Text = listItem.Index;
                btnSave.Tag = lvMobDropGroups.SelectedIndices[0];
                nudGroupDropRate.Value = mob.DropGroups.Where(x => x.Group.Index == listItem.Index).FirstOrDefault().DropRate;
                UpGradeMin.Value = mob.DropGroups.Where(x => x.Group.Index == listItem.Index).FirstOrDefault().UpGradeMin;
                UpGradeMax.Value = mob.DropGroups.Where(x => x.Group.Index == listItem.Index).FirstOrDefault().UpGradeMax;
                lbItemGroups.SelectedItem = listItem;
            }
        }

        private void BtnAddMobDropGroup_Click(object sender, EventArgs e)
        {
            var dropGroup = Groups.FirstOrDefault(x => x.Index == txtAddGroup.Text);
            if (dropGroup != null)
            {
                var mob = (Mob)lbMobs.SelectedItem;
                var entry = new MobDropGroupEntry(dropGroup, 100, 0, 0);
                mob.DropGroups.Add(entry);

                LoadMobGroupView();
            }
            else
            {
                MessageBox.Show("Item Group does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAddItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbAllItems.SelectedItems.Count <= 0)
                    throw new Exception("You have to select an item from the list first.");

                var newItem = lbAllItems.SelectedItem.ToString();
                var relatedGroups = Groups.Where(x => x.Items.Contains(newItem));

                if (relatedGroups.Count() >= 2)
                {
                    throw new Exception("This item already belongs to two other item groups. " +
                        "Remove it from one of the following groups before adding it to this one.\n\n" +
                        "Group 1: " + relatedGroups.First().Index + "\n" +
                        "Group 2: " + relatedGroups.Last().Index);
                }

                if (((ItemGroup)lbItemGroups.SelectedItem).Items.Contains(newItem))
                {
                    throw new Exception("This group already has this item added.");
                }

                ((ItemGroup)lbItemGroups.SelectedItem).Items.Add(newItem);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TxtAllItemsFilter_TextChanged(object sender, EventArgs e)
        {
            var filterItems = Items.Where(x => x.ToLower().Contains(txtAllItemsFilter.Text.ToLower())).ToList();
            lbAllItems.DataSource = filterItems;
        }

        private void TxtItemGroupFilter_TextChanged(object sender, EventArgs e)
        {
            var filterGroups = Groups.Where(x => x.Index.ToLower().Contains(txtItemGroupFilter.Text.ToLower())).ToList();
            lbItemGroups.DataSource = filterGroups;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Tag == null)
            {
                MessageBox.Show("You must select an item group first.");
                return;
            }

            if (UpGradeMin.Value > UpGradeMax.Value)
            {
                throw new Exception("UpGradeMin must be smaller than/equal to UpGradeMax.");
            }

            var mob = (Mob)lbMobs.SelectedItem;
            var group = mob.DropGroups[Convert.ToInt32(btnSave.Tag)];
            group.DropRate = nudGroupDropRate.Value;
            group.UpGradeMin = Convert.ToInt32(UpGradeMin.Value);
            group.UpGradeMax = Convert.ToInt32(UpGradeMax.Value);

            LoadMobGroupView();
        }

        private void NudMaximum_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                ((ItemGroup)lbItemGroups.SelectedItem).Maximum = Convert.ToInt32(nudMaximum.Value);
            }
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

        private void BtnRemoveItem_Click(object sender, EventArgs e)
        {
            if (lbGroupItems.SelectedItem == null || lbItemGroups.SelectedItem == null)
                return;

            ((ItemGroup)lbItemGroups.SelectedItem).Items.RemoveAt(lbGroupItems.SelectedIndex);
        }

        private void NudMinimum_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                ((ItemGroup)lbItemGroups.SelectedItem).Minimum = Convert.ToInt32(nudMinimum.Value);
            }
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

        private void BtnAddItemGroup_Click(object sender, EventArgs e)
        {
            if (Groups.Where(x => x.Index == txtNewItemGroup.Text).Count() <= 0)
            {
                var group = new ItemGroup(txtNewItemGroup.Text);
                Groups.Add(group);
                lbItemGroups.SelectedItem = lbItemGroups.Items.Cast<ItemGroup>().Last();
            }
            else
            {
                MessageBox.Show("A group with that name already exists.");
            }
        }

        private void BtnDeleteGroup_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this group?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information) != DialogResult.Yes)
                return;

            var grp = ((ItemGroup)lbItemGroups.SelectedItem);
            RemoveGroup(grp);

            if (lbItemGroups.Items.Count > 0)
            {
                lbItemGroups.SelectedIndex = 0;
            }
            else
            {
                lbGroupItems.DataSource = null;
                txtSelectedGroupName.Clear();
                nudMaximum.Value = 1;
                nudMinimum.Value = 1;
            }

            LoadMobGroupView();
        }

        private void RemoveGroup(ItemGroup grp)
        {
            foreach (var mob in Mobs)
            {
                var groups = mob.DropGroups.Where(x => x.Group.Index == grp.Index).ToList();
                foreach (var group in groups)
                {
                    mob.DropGroups.Remove(group);
                }
            }
            Groups.Remove(grp);
        }

        private void MenuRemoveAllGroups_Click(object sender, EventArgs e)
        {
            try
            {
				CheckIfLoaded();

                if (MessageBox.Show("Are you sure you want to remove all groups?", "Confirm",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information) == DialogResult.No)
                {
                    return;
                }

                foreach (var grp in Groups.ToList())
                {
                    RemoveGroup(grp);
                }

                LoadMobGroupView();

                lbGroupItems.DataSource = null;
                txtSelectedGroupName.Clear();
                nudMaximum.Value = 1;
                nudMinimum.Value = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void MenuSave_Click(object sender, EventArgs e)
        {
            if (_isLoaded)
            {
                lblStatus.Text = "Saving..";

                ToggleControls(false);
                await SaveDrops();
                ToggleControls(true);

                lblStatus.Text = "Saved!";
            }
        }

        private Task SaveDrops()
        {
            return Task.Factory.StartNew(() =>
            {
                SaveItemDropGroup();
                SaveItemDropTable();
                SaveItemInfoServer();
            });
        }

        private void SaveItemInfoServer()
        {
            for (int i = 0; i < ItemInfoServer.Table.Rows.Count; i++)
            {
                ItemInfoServer.Table.Rows[i]["DropGroupA"] = "-";
                ItemInfoServer.Table.Rows[i]["DropGroupB"] = "-";
            }

            foreach (var group in Groups)
            {
                foreach (var item in group.Items)
                {
                    var row = ItemInfoServer.Table.Rows.Cast<DataRow>()
                                    .Where(x => x["InxName"].ToString() == item).FirstOrDefault();

                    if (row != null)
                    {
                        if (row["DropGroupA"].ToString() == "-")
                        {
                            row["DropGroupA"] = group.Index;
                        }
                        else
                        {
                            row["DropGroupB"] = group.Index;
                        }
                    }
                }
            }

            ItemInfoServer.Save();
        }

        private void SaveItemDropTable()
        {
            ItemDropTable.DataSet.Tables[0].Rows.Clear();

            foreach (var mob in Mobs)
            {
                var row = ItemDropTable.DataSet.Tables[0].NewRow();
                row["MapArea"] = "-";
                row["MobId"] = mob.InxName;
                row["MinLevel"] = mob.MinLevel;
                row["MaxLevel"] = mob.MaxLevel;
                row["AbStateCnt"] = 0;
                row["MinCen"] = mob.MinCen;
                row["MaxCen"] = mob.MaxCen;
                row["CenRate"] = mob.CenRate * 10000;
                row["TradeBoxA"] = "-";
                row["RateA"] = 0;
                row["TradeBoxB"] = "-";
                row["RateB"] = 0;
                row["TradeBoxC"] = "-";
                row["RateC"] = 0;

                var i = 1;
                foreach (var grp in mob.DropGroups)
                {
                    row["DrItem" + i] = grp.Group.Index;
                    row["DrItem" + i + "R"] = Convert.ToInt32(grp.DropRate * 10000);
                    row[$"UpgradeMin{i:D2}"] = grp.UpGradeMin;
                    row[$"UpgradeMax{i:D2}"] = grp.UpGradeMax;
                    row["Rule" + i] = "r";
                    row["Num" + i] = -1;
                    i++;
                }

                for (int x = i; x < 46; x++)
                {
                    row["DrItem" + x] = "-";
                    row["DrItem" + x + "R"] = 0;
                    row[$"UpgradeMin{x:D2}"] = 0;
                    row[$"UpgradeMax{x:D2}"] = 0;
                    row["Rule" + x] = "-";
                    row["Num" + x] = 0;
                }

                row["ExcItem1"] = "-";
                row["ExcItem2"] = "-";
                row["ExcItem3"] = "-";
                row["ExcItem4"] = "-";
                row["ExcItem5"] = "-";

                row["CheckSum"] = mob.MinLevel + mob.MaxLevel + mob.MinCen + mob.MaxCen + (mob.CenRate * 10000);
                ItemDropTable.DataSet.Tables[0].Rows.Add(row);
            }

            ItemDropTable.SaveFile();
        }

        private void SaveItemDropGroup()
        {
            ItemDropGroup.DataSet.Tables[0].Rows.Clear();

            foreach (var group in Groups)
            {
                var row = ItemDropGroup.DataSet.Tables[0].NewRow();
                row["ItemGroupIdx"] = group.Index;
                row["ItemID"] = group.Index;
                row["MinQtty"] = group.Minimum;
                row["MaxQtty"] = group.Maximum;

                for (int i = 0; i < 16; i++)
                {
                    row[string.Format("Upgrade{0}", i.ToString("D2"))] = group.Upgrades[i];
                }

                row["CheckSum"] = group.Checksum;
                ItemDropGroup.DataSet.Tables[0].Rows.Add(row);
            }

            ItemDropGroup.SaveFile();
        }

		private void CheckIfLoaded()
		{
			if (!_isLoaded)
			{
				throw new Exception("You need to load your files before this tool is available.");
			}
		}

		private void CheckDropGroup(frmParent frm)
		{
			try
			{
				CheckIfLoaded();

				if (frm.ShowDialog(this) != DialogResult.OK)
				{
					return;
				}

				if (Groups.FirstOrDefault(x => x.Index == frm.GroupName) == null)
					throw new Exception("Specified drop group does not exist. Don't forget that they are case sensitive.");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void MenuAddGroupToAll_Click(object sender, EventArgs e)
        {
			var frm = new frmAddToAll();
			CheckDropGroup(frm);
			foreach (var mob in Mobs.Where(x => x.MobLevel >= frm.MinLevel && x.MobLevel <= frm.MaxLevel))
			{
				var entry = new MobDropGroupEntry(Groups.FirstOrDefault(x => x.Index == frm.GroupName), 100, 0, 0);
				entry.DropRate = frm.DropRate;
				mob.DropGroups.Add(entry);
			}

			LoadMobGroupView();
        }

		private void MenuGroupRateEdit_Click(object sender, EventArgs e)
        {
			var frm = new frmGroupRateEditor();
			CheckDropGroup(frm);
			foreach (var mob in Mobs)
			{
				foreach (var entry in mob.DropGroups.Where(x => x.Group.Index == frm.GroupName))
				{
					entry.DropRate = frm.Value;
				}
			}
			LoadMobGroupView();
        }

        private void ToggleControls(bool enabled)
        {
            txtAllItemsFilter.Enabled = enabled;
            txtItemGroupFilter.Enabled = enabled;
            txtFilter.Enabled = enabled;
            btnAddItem.Enabled = enabled;
            btnAddItemGroup.Enabled = enabled;
            btnAddMobDropGroup.Enabled = enabled;
            btnDeleteGroup.Enabled = enabled;
            btnRemoveGroup.Enabled = enabled;
            btnRemoveItem.Enabled = enabled;
            btnSave.Enabled = enabled;
            txtSelectedGroupName.Enabled = enabled;
            nudMinimum.Enabled = enabled;
            nudMaximum.Enabled = enabled;
            txtNewItemGroup.Enabled = enabled;
            txtAddGroup.Enabled = enabled;
            MinCen.Enabled = enabled;
            MaxCen.Enabled = enabled;
            CenRate.Enabled = enabled;
            nudGroupDropRate.Enabled = enabled;
            UpGradeMin.Enabled = enabled;
            UpGradeMax.Enabled = enabled;
        }

		private void SetCen(int option, decimal value)
		{
			try
			{
				option = Convert.ToInt32(value);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void SetCen(decimal option, decimal value)
		{
			SetCen(Convert.ToInt32(option), value);
		}

        private void MinCen_ValueChanged(object sender, EventArgs e)
        {
			SetCen(((Mob)lbMobs.SelectedItem).MinCen, MinCen.Value);
		}

        private void MaxCen_ValueChanged(object sender, EventArgs e)
        {
			SetCen(((Mob)lbMobs.SelectedItem).MaxCen, MaxCen.Value);
		}

        private void CenRate_ValueChanged(object sender, EventArgs e)
        {
			SetCen(((Mob)lbMobs.SelectedItem).CenRate, CenRate.Value);
		}

		private void CreditsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var frmCredits = new frmCredits();
			frmCredits.Show();
		}
	}
}
