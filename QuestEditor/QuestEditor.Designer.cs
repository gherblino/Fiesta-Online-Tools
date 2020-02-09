namespace QuestEditor
{
    partial class QuestEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestEditor));
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.CloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DuplicateSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QuestListBox = new System.Windows.Forms.ListBox();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.SearchOptions = new System.Windows.Forms.ComboBox();
            this.CompareOptions = new System.Windows.Forms.ComboBox();
            this.Credits = new System.Windows.Forms.StatusStrip();
            this.CreditsLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.RewardInfoTab = new System.Windows.Forms.TabPage();
            this.MiniHouseIDRewardLabel = new System.Windows.Forms.Label();
            this.PetIDRewardLabel = new System.Windows.Forms.Label();
            this.FameRewardLabel = new System.Windows.Forms.Label();
            this.KillPointRewardLabel = new System.Windows.Forms.Label();
            this.TitleTypeRewardComboBox = new System.Windows.Forms.ComboBox();
            this.ElementNoRewardLabel = new System.Windows.Forms.Label();
            this.TitleTypeRewardLabel = new System.Windows.Forms.Label();
            this.AbstateIDRewardLabel = new System.Windows.Forms.Label();
            this.AbstateStrengthRewardLabel = new System.Windows.Forms.Label();
            this.AbstateTimeRewardLabel = new System.Windows.Forms.Label();
            this.ItemLotRewardLabel = new System.Windows.Forms.Label();
            this.ItemIDRewardLabel = new System.Windows.Forms.Label();
            this.MoneyRewardLabel = new System.Windows.Forms.Label();
            this.ExpRewardLabel = new System.Windows.Forms.Label();
            this.RewardDataGridView = new System.Windows.Forms.DataGridView();
            this.useDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.questRewardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MiniHouseIDRewardBox = new NumberBox.NumberBox();
            this.PetIDRewardBox = new NumberBox.NumberBox();
            this.FameRewardBox = new NumberBox.NumberBox();
            this.KillPointRewardBox = new NumberBox.NumberBox();
            this.ElementNoRewardBox = new NumberBox.NumberBox();
            this.AbstateIDRewardBox = new NumberBox.NumberBox();
            this.AbstateStrengthRewardBox = new NumberBox.NumberBox();
            this.AbstateTimeRewardBox = new NumberBox.NumberBox();
            this.ItemLotRewardBox = new NumberBox.NumberBox();
            this.ItemIDRewardBox = new NumberBox.NumberBox();
            this.MoneyRewardBox = new NumberBox.NumberBox();
            this.ExpRewardBox = new NumberBox.NumberBox();
            this.ItemInfoTab = new System.Windows.Forms.TabPage();
            this.MobInfoTab = new System.Windows.Forms.TabPage();
            this.EndScriptTab = new System.Windows.Forms.TabPage();
            this.EndScriptBox = new System.Windows.Forms.TextBox();
            this.ActiveScriptTab = new System.Windows.Forms.TabPage();
            this.ActiveScriptBox = new System.Windows.Forms.TextBox();
            this.StartScriptTab = new System.Windows.Forms.TabPage();
            this.StartScriptBox = new System.Windows.Forms.TextBox();
            this.EndInfoTab = new System.Windows.Forms.TabPage();
            this.EndGroupBox = new System.Windows.Forms.GroupBox();
            this.EndLevelBox = new NumberBox.NumberBox();
            this.EndClassBox = new System.Windows.Forms.ComboBox();
            this.EndRaceBox = new System.Windows.Forms.ComboBox();
            this.EndTimeLimitBox = new NumberBox.NumberBox();
            this.EndTimeLimitLabel = new System.Windows.Forms.Label();
            this.EndHasTimeLimitBox = new System.Windows.Forms.ComboBox();
            this.EndHasTimeLimitLabel = new System.Windows.Forms.Label();
            this.EndRaceLabel = new System.Windows.Forms.Label();
            this.EndNeedsRaceBox = new System.Windows.Forms.ComboBox();
            this.EndNeedsRaceLabel = new System.Windows.Forms.Label();
            this.EndClassLabel = new System.Windows.Forms.Label();
            this.EndNeedsClassBox = new System.Windows.Forms.ComboBox();
            this.EndNeedsClassLabel = new System.Windows.Forms.Label();
            this.EndScenarioIDBox = new NumberBox.NumberBox();
            this.EndScenarioIDLabel = new System.Windows.Forms.Label();
            this.EndNeedsScenarioBox = new System.Windows.Forms.ComboBox();
            this.EndNeedsScenarioLabel = new System.Windows.Forms.Label();
            this.EndLocationBox = new NumberBox.NumberBox();
            this.EndLocationLabel = new System.Windows.Forms.Label();
            this.EndUnkBox = new NumberBox.NumberBox();
            this.EndUnkLabel = new System.Windows.Forms.Label();
            this.EndRangeBox = new NumberBox.NumberBox();
            this.EndRangeLabel = new System.Windows.Forms.Label();
            this.EndYBox = new NumberBox.NumberBox();
            this.EndYLabel = new System.Windows.Forms.Label();
            this.EndXBox = new NumberBox.NumberBox();
            this.EndXLabel = new System.Windows.Forms.Label();
            this.EndNeedsLocationBox = new System.Windows.Forms.ComboBox();
            this.EndNeedsLocationLabel = new System.Windows.Forms.Label();
            this.EndLevelLabel = new System.Windows.Forms.Label();
            this.EndNeedsLevelBox = new System.Windows.Forms.ComboBox();
            this.EndIsInstantHandInLabel = new System.Windows.Forms.Label();
            this.EndNeedsLevelLabel = new System.Windows.Forms.Label();
            this.EndIsInstantHandInBox = new System.Windows.Forms.ComboBox();
            this.StartInfoTab = new System.Windows.Forms.TabPage();
            this.StartGroupBox = new System.Windows.Forms.GroupBox();
            this.StartDateEndBox = new NumberBox.NumberBox();
            this.StartDateEndLabel = new System.Windows.Forms.Label();
            this.StartDateStartBox = new NumberBox.NumberBox();
            this.StartDateStartLabel = new System.Windows.Forms.Label();
            this.StartItemIDBox = new NumberBox.NumberBox();
            this.StartNPCIDBox = new NumberBox.NumberBox();
            this.StartMaxLevelBox = new NumberBox.NumberBox();
            this.StartMinLevelBox = new NumberBox.NumberBox();
            this.StartDateModeBox = new System.Windows.Forms.ComboBox();
            this.StartDateModeLabel = new System.Windows.Forms.Label();
            this.StartNeedsDateBox = new System.Windows.Forms.ComboBox();
            this.StartNeedsDateLabel = new System.Windows.Forms.Label();
            this.StartGenderBox = new System.Windows.Forms.ComboBox();
            this.StartGenderLabel = new System.Windows.Forms.Label();
            this.StartNeedsGenderBox = new System.Windows.Forms.ComboBox();
            this.StartNeedsGenderLabel = new System.Windows.Forms.Label();
            this.StartClassBox = new System.Windows.Forms.ComboBox();
            this.StartRaceBox = new System.Windows.Forms.ComboBox();
            this.StartPreviousQuestBox = new NumberBox.NumberBox();
            this.StartRaceLabel = new System.Windows.Forms.Label();
            this.StartPreviousQuestLabel = new System.Windows.Forms.Label();
            this.StartNeedsRaceBox = new System.Windows.Forms.ComboBox();
            this.StartNeedsRaceLabel = new System.Windows.Forms.Label();
            this.StartNeedsQuestBox = new System.Windows.Forms.ComboBox();
            this.StartClassLabel = new System.Windows.Forms.Label();
            this.StartNeedsQuestLabel = new System.Windows.Forms.Label();
            this.StartNeedsClassBox = new System.Windows.Forms.ComboBox();
            this.StartLocationBox = new NumberBox.NumberBox();
            this.StartNeedsClassLabel = new System.Windows.Forms.Label();
            this.StartLocationLabel = new System.Windows.Forms.Label();
            this.StartUnkBox = new NumberBox.NumberBox();
            this.StartUnkLabel = new System.Windows.Forms.Label();
            this.StartRangeBox = new NumberBox.NumberBox();
            this.StartRangeLabel = new System.Windows.Forms.Label();
            this.StartYBox = new NumberBox.NumberBox();
            this.StartYLabel = new System.Windows.Forms.Label();
            this.StartXBox = new NumberBox.NumberBox();
            this.StartXLabel = new System.Windows.Forms.Label();
            this.StartNeedsLocationBox = new System.Windows.Forms.ComboBox();
            this.StartNeedsLocationLabel = new System.Windows.Forms.Label();
            this.StartItemIDLabel = new System.Windows.Forms.Label();
            this.StartItemLotLabel = new System.Windows.Forms.Label();
            this.StartItemLotBox = new NumberBox.NumberBox();
            this.StartNeedsItemBox = new System.Windows.Forms.ComboBox();
            this.StartNeedsItemLabel = new System.Windows.Forms.Label();
            this.StartNPCIDLabel = new System.Windows.Forms.Label();
            this.StartNeedsNPCBox = new System.Windows.Forms.ComboBox();
            this.StartNeedsNPCLabel = new System.Windows.Forms.Label();
            this.StartMaxLevelLabel = new System.Windows.Forms.Label();
            this.StartIsWaitListProgressBox = new System.Windows.Forms.ComboBox();
            this.StartMinLevelLabel = new System.Windows.Forms.Label();
            this.StartIsInstantAcceptBox = new System.Windows.Forms.ComboBox();
            this.StartNeedsLevelBox = new System.Windows.Forms.ComboBox();
            this.StartNeedsLevelLabel = new System.Windows.Forms.Label();
            this.StartIsWaitListProgressLabel = new System.Windows.Forms.Label();
            this.StartIsWaitListViewLabel = new System.Windows.Forms.Label();
            this.StartIsWaitListViewBox = new System.Windows.Forms.ComboBox();
            this.StartIsInstantAcceptLabel = new System.Windows.Forms.Label();
            this.BaseInfoTab = new System.Windows.Forms.TabPage();
            this.BaseInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.RegionBox = new NumberBox.NumberBox();
            this.DescriptionBox = new NumberBox.NumberBox();
            this.TitleBox = new NumberBox.NumberBox();
            this.IDBox = new NumberBox.NumberBox();
            this.IsEnabledBox = new System.Windows.Forms.ComboBox();
            this.IsEnabledLabel = new System.Windows.Forms.Label();
            this.QuestTypeBox = new System.Windows.Forms.ComboBox();
            this.DailyQuestTypeLabel = new System.Windows.Forms.Label();
            this.DailyQuestTypeBox = new System.Windows.Forms.ComboBox();
            this.IDLabel = new System.Windows.Forms.Label();
            this.IsDailyQuestBox = new System.Windows.Forms.ComboBox();
            this.IsDailyQuestLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.IsRepeatableBox = new System.Windows.Forms.ComboBox();
            this.IsRepeatableLabel = new System.Windows.Forms.Label();
            this.QuestTypeLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.RegionLabel = new System.Windows.Forms.Label();
            this.Tabs = new System.Windows.Forms.TabControl();
            this.MenuStrip.SuspendLayout();
            this.Credits.SuspendLayout();
            this.RewardInfoTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RewardDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questRewardBindingSource)).BeginInit();
            this.EndScriptTab.SuspendLayout();
            this.ActiveScriptTab.SuspendLayout();
            this.StartScriptTab.SuspendLayout();
            this.EndInfoTab.SuspendLayout();
            this.EndGroupBox.SuspendLayout();
            this.StartInfoTab.SuspendLayout();
            this.StartGroupBox.SuspendLayout();
            this.BaseInfoTab.SuspendLayout();
            this.BaseInfoGroupBox.SuspendLayout();
            this.Tabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.EditToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(1006, 28);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.SaveAsToolStripMenuItem,
            this.ToolStripSeparator,
            this.CloseToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.OpenToolStripMenuItem.Text = "Open";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.SaveToolStripMenuItem.Text = "Save";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // SaveAsToolStripMenuItem
            // 
            this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
            this.SaveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.SaveAsToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.SaveAsToolStripMenuItem.Text = "Save As";
            this.SaveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // ToolStripSeparator
            // 
            this.ToolStripSeparator.Name = "ToolStripSeparator";
            this.ToolStripSeparator.Size = new System.Drawing.Size(222, 6);
            // 
            // CloseToolStripMenuItem
            // 
            this.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
            this.CloseToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.CloseToolStripMenuItem.Text = "Close";
            this.CloseToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DuplicateSelectedToolStripMenuItem,
            this.DeleteAllToolStripMenuItem});
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.EditToolStripMenuItem.Text = "Edit";
            // 
            // DuplicateSelectedToolStripMenuItem
            // 
            this.DuplicateSelectedToolStripMenuItem.Name = "DuplicateSelectedToolStripMenuItem";
            this.DuplicateSelectedToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.DuplicateSelectedToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.DuplicateSelectedToolStripMenuItem.Text = "Duplicate Selected";
            this.DuplicateSelectedToolStripMenuItem.Click += new System.EventHandler(this.DuplicateSelectedToolStripMenuItem_Click);
            // 
            // DeleteAllToolStripMenuItem
            // 
            this.DeleteAllToolStripMenuItem.Name = "DeleteAllToolStripMenuItem";
            this.DeleteAllToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.DeleteAllToolStripMenuItem.Text = "Delete All";
            this.DeleteAllToolStripMenuItem.Click += new System.EventHandler(this.DeleteAllToolStripMenuItem_Click);
            // 
            // QuestListBox
            // 
            this.QuestListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.QuestListBox.FormattingEnabled = true;
            this.QuestListBox.ItemHeight = 16;
            this.QuestListBox.Location = new System.Drawing.Point(0, 60);
            this.QuestListBox.Name = "QuestListBox";
            this.QuestListBox.Size = new System.Drawing.Size(254, 516);
            this.QuestListBox.TabIndex = 2;
            this.QuestListBox.TabStop = false;
            this.QuestListBox.SelectedIndexChanged += new System.EventHandler(this.QuestListBox_SelectedIndexChanged);
            // 
            // SearchBox
            // 
            this.SearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBox.Location = new System.Drawing.Point(0, 32);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(254, 22);
            this.SearchBox.TabIndex = 3;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // SearchOptions
            // 
            this.SearchOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SearchOptions.FormattingEnabled = true;
            this.SearchOptions.Items.AddRange(new object[] {
            "ID",
            "Title",
            "Description",
            "NPC ID",
            "NPC InxName",
            "NPC Name",
            "MinLevel",
            "MaxLevel"});
            this.SearchOptions.Location = new System.Drawing.Point(260, 32);
            this.SearchOptions.Name = "SearchOptions";
            this.SearchOptions.Size = new System.Drawing.Size(153, 24);
            this.SearchOptions.TabIndex = 4;
            this.SearchOptions.SelectionChangeCommitted += new System.EventHandler(this.SearchOptions_SelectionChangeCommitted);
            // 
            // CompareOptions
            // 
            this.CompareOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CompareOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CompareOptions.FormattingEnabled = true;
            this.CompareOptions.Items.AddRange(new object[] {
            "Contains",
            "Not contains",
            "Equals",
            "Not equals",
            "Larger than",
            "Smaller than"});
            this.CompareOptions.Location = new System.Drawing.Point(419, 32);
            this.CompareOptions.Name = "CompareOptions";
            this.CompareOptions.Size = new System.Drawing.Size(147, 24);
            this.CompareOptions.TabIndex = 5;
            // 
            // Credits
            // 
            this.Credits.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Credits.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreditsLabel});
            this.Credits.Location = new System.Drawing.Point(0, 581);
            this.Credits.Name = "Credits";
            this.Credits.Size = new System.Drawing.Size(1006, 25);
            this.Credits.SizingGrip = false;
            this.Credits.TabIndex = 7;
            this.Credits.Text = "Created by Gherblino";
            // 
            // CreditsLabel
            // 
            this.CreditsLabel.Name = "CreditsLabel";
            this.CreditsLabel.Size = new System.Drawing.Size(150, 20);
            this.CreditsLabel.Text = "Created by Gherblino";
            // 
            // RewardInfoTab
            // 
            this.RewardInfoTab.Controls.Add(this.MiniHouseIDRewardLabel);
            this.RewardInfoTab.Controls.Add(this.PetIDRewardLabel);
            this.RewardInfoTab.Controls.Add(this.FameRewardLabel);
            this.RewardInfoTab.Controls.Add(this.KillPointRewardLabel);
            this.RewardInfoTab.Controls.Add(this.TitleTypeRewardComboBox);
            this.RewardInfoTab.Controls.Add(this.ElementNoRewardLabel);
            this.RewardInfoTab.Controls.Add(this.TitleTypeRewardLabel);
            this.RewardInfoTab.Controls.Add(this.AbstateIDRewardLabel);
            this.RewardInfoTab.Controls.Add(this.AbstateStrengthRewardLabel);
            this.RewardInfoTab.Controls.Add(this.AbstateTimeRewardLabel);
            this.RewardInfoTab.Controls.Add(this.ItemLotRewardLabel);
            this.RewardInfoTab.Controls.Add(this.ItemIDRewardLabel);
            this.RewardInfoTab.Controls.Add(this.MoneyRewardLabel);
            this.RewardInfoTab.Controls.Add(this.ExpRewardLabel);
            this.RewardInfoTab.Controls.Add(this.RewardDataGridView);
            this.RewardInfoTab.Controls.Add(this.MiniHouseIDRewardBox);
            this.RewardInfoTab.Controls.Add(this.PetIDRewardBox);
            this.RewardInfoTab.Controls.Add(this.FameRewardBox);
            this.RewardInfoTab.Controls.Add(this.KillPointRewardBox);
            this.RewardInfoTab.Controls.Add(this.ElementNoRewardBox);
            this.RewardInfoTab.Controls.Add(this.AbstateIDRewardBox);
            this.RewardInfoTab.Controls.Add(this.AbstateStrengthRewardBox);
            this.RewardInfoTab.Controls.Add(this.AbstateTimeRewardBox);
            this.RewardInfoTab.Controls.Add(this.ItemLotRewardBox);
            this.RewardInfoTab.Controls.Add(this.ItemIDRewardBox);
            this.RewardInfoTab.Controls.Add(this.MoneyRewardBox);
            this.RewardInfoTab.Controls.Add(this.ExpRewardBox);
            this.RewardInfoTab.Location = new System.Drawing.Point(4, 25);
            this.RewardInfoTab.Name = "RewardInfoTab";
            this.RewardInfoTab.Size = new System.Drawing.Size(738, 489);
            this.RewardInfoTab.TabIndex = 8;
            this.RewardInfoTab.Text = "Reward Info";
            this.RewardInfoTab.UseVisualStyleBackColor = true;
            // 
            // MiniHouseIDRewardLabel
            // 
            this.MiniHouseIDRewardLabel.AutoSize = true;
            this.MiniHouseIDRewardLabel.Location = new System.Drawing.Point(326, 224);
            this.MiniHouseIDRewardLabel.Name = "MiniHouseIDRewardLabel";
            this.MiniHouseIDRewardLabel.Size = new System.Drawing.Size(99, 17);
            this.MiniHouseIDRewardLabel.TabIndex = 29;
            this.MiniHouseIDRewardLabel.Text = "Mini House ID:";
            // 
            // PetIDRewardLabel
            // 
            this.PetIDRewardLabel.AutoSize = true;
            this.PetIDRewardLabel.Location = new System.Drawing.Point(375, 196);
            this.PetIDRewardLabel.Name = "PetIDRewardLabel";
            this.PetIDRewardLabel.Size = new System.Drawing.Size(50, 17);
            this.PetIDRewardLabel.TabIndex = 27;
            this.PetIDRewardLabel.Text = "Pet ID:";
            // 
            // FameRewardLabel
            // 
            this.FameRewardLabel.AutoSize = true;
            this.FameRewardLabel.Location = new System.Drawing.Point(378, 168);
            this.FameRewardLabel.Name = "FameRewardLabel";
            this.FameRewardLabel.Size = new System.Drawing.Size(47, 17);
            this.FameRewardLabel.TabIndex = 25;
            this.FameRewardLabel.Text = "Fame:";
            // 
            // KillPointRewardLabel
            // 
            this.KillPointRewardLabel.AutoSize = true;
            this.KillPointRewardLabel.Location = new System.Drawing.Point(352, 282);
            this.KillPointRewardLabel.Name = "KillPointRewardLabel";
            this.KillPointRewardLabel.Size = new System.Drawing.Size(73, 17);
            this.KillPointRewardLabel.TabIndex = 21;
            this.KillPointRewardLabel.Text = "Kill Points:";
            // 
            // TitleTypeRewardComboBox
            // 
            this.TitleTypeRewardComboBox.FormattingEnabled = true;
            this.TitleTypeRewardComboBox.Location = new System.Drawing.Point(431, 249);
            this.TitleTypeRewardComboBox.Name = "TitleTypeRewardComboBox";
            this.TitleTypeRewardComboBox.Size = new System.Drawing.Size(121, 24);
            this.TitleTypeRewardComboBox.TabIndex = 21;
            // 
            // ElementNoRewardLabel
            // 
            this.ElementNoRewardLabel.AutoSize = true;
            this.ElementNoRewardLabel.Location = new System.Drawing.Point(572, 252);
            this.ElementNoRewardLabel.Name = "ElementNoRewardLabel";
            this.ElementNoRewardLabel.Size = new System.Drawing.Size(85, 17);
            this.ElementNoRewardLabel.TabIndex = 18;
            this.ElementNoRewardLabel.Text = "Element No:";
            // 
            // TitleTypeRewardLabel
            // 
            this.TitleTypeRewardLabel.AutoSize = true;
            this.TitleTypeRewardLabel.Location = new System.Drawing.Point(350, 252);
            this.TitleTypeRewardLabel.Name = "TitleTypeRewardLabel";
            this.TitleTypeRewardLabel.Size = new System.Drawing.Size(75, 17);
            this.TitleTypeRewardLabel.TabIndex = 16;
            this.TitleTypeRewardLabel.Text = "Title Type:";
            // 
            // AbstateIDRewardLabel
            // 
            this.AbstateIDRewardLabel.AutoSize = true;
            this.AbstateIDRewardLabel.Location = new System.Drawing.Point(348, 112);
            this.AbstateIDRewardLabel.Name = "AbstateIDRewardLabel";
            this.AbstateIDRewardLabel.Size = new System.Drawing.Size(77, 17);
            this.AbstateIDRewardLabel.TabIndex = 14;
            this.AbstateIDRewardLabel.Text = "Abstate ID:";
            // 
            // AbstateStrengthRewardLabel
            // 
            this.AbstateStrengthRewardLabel.AutoSize = true;
            this.AbstateStrengthRewardLabel.Location = new System.Drawing.Point(539, 112);
            this.AbstateStrengthRewardLabel.Name = "AbstateStrengthRewardLabel";
            this.AbstateStrengthRewardLabel.Size = new System.Drawing.Size(118, 17);
            this.AbstateStrengthRewardLabel.TabIndex = 12;
            this.AbstateStrengthRewardLabel.Text = "Abstate Strength:";
            // 
            // AbstateTimeRewardLabel
            // 
            this.AbstateTimeRewardLabel.AutoSize = true;
            this.AbstateTimeRewardLabel.Location = new System.Drawing.Point(562, 140);
            this.AbstateTimeRewardLabel.Name = "AbstateTimeRewardLabel";
            this.AbstateTimeRewardLabel.Size = new System.Drawing.Size(95, 17);
            this.AbstateTimeRewardLabel.TabIndex = 10;
            this.AbstateTimeRewardLabel.Text = "Abstate Time:";
            // 
            // ItemLotRewardLabel
            // 
            this.ItemLotRewardLabel.AutoSize = true;
            this.ItemLotRewardLabel.Location = new System.Drawing.Point(595, 84);
            this.ItemLotRewardLabel.Name = "ItemLotRewardLabel";
            this.ItemLotRewardLabel.Size = new System.Drawing.Size(62, 17);
            this.ItemLotRewardLabel.TabIndex = 8;
            this.ItemLotRewardLabel.Text = "Item Lot:";
            // 
            // ItemIDRewardLabel
            // 
            this.ItemIDRewardLabel.AutoSize = true;
            this.ItemIDRewardLabel.Location = new System.Drawing.Point(370, 84);
            this.ItemIDRewardLabel.Name = "ItemIDRewardLabel";
            this.ItemIDRewardLabel.Size = new System.Drawing.Size(55, 17);
            this.ItemIDRewardLabel.TabIndex = 6;
            this.ItemIDRewardLabel.Text = "Item ID:";
            // 
            // MoneyRewardLabel
            // 
            this.MoneyRewardLabel.AutoSize = true;
            this.MoneyRewardLabel.Location = new System.Drawing.Point(371, 56);
            this.MoneyRewardLabel.Name = "MoneyRewardLabel";
            this.MoneyRewardLabel.Size = new System.Drawing.Size(54, 17);
            this.MoneyRewardLabel.TabIndex = 4;
            this.MoneyRewardLabel.Text = "Money:";
            // 
            // ExpRewardLabel
            // 
            this.ExpRewardLabel.AutoSize = true;
            this.ExpRewardLabel.Location = new System.Drawing.Point(386, 28);
            this.ExpRewardLabel.Name = "ExpRewardLabel";
            this.ExpRewardLabel.Size = new System.Drawing.Size(39, 17);
            this.ExpRewardLabel.TabIndex = 2;
            this.ExpRewardLabel.Text = "EXP:";
            // 
            // RewardDataGridView
            // 
            this.RewardDataGridView.AllowUserToAddRows = false;
            this.RewardDataGridView.AllowUserToDeleteRows = false;
            this.RewardDataGridView.AllowUserToOrderColumns = true;
            this.RewardDataGridView.AllowUserToResizeColumns = false;
            this.RewardDataGridView.AllowUserToResizeRows = false;
            this.RewardDataGridView.AutoGenerateColumns = false;
            this.RewardDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RewardDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.useDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn});
            this.RewardDataGridView.DataSource = this.questRewardBindingSource;
            this.RewardDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.RewardDataGridView.Location = new System.Drawing.Point(0, 0);
            this.RewardDataGridView.Name = "RewardDataGridView";
            this.RewardDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.RewardDataGridView.RowTemplate.Height = 24;
            this.RewardDataGridView.Size = new System.Drawing.Size(324, 383);
            this.RewardDataGridView.TabIndex = 0;
            this.RewardDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RewardDataGridView_CellClick);
            this.RewardDataGridView.CurrentCellDirtyStateChanged += new System.EventHandler(this.RewardDataGridView_CurrentCellDirtyStateChanged);
            this.RewardDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.RewardDataGridView_DataError);
            this.RewardDataGridView.SelectionChanged += new System.EventHandler(this.RewardDataGridView_SelectionChanged);
            // 
            // useDataGridViewTextBoxColumn
            // 
            this.useDataGridViewTextBoxColumn.DataPropertyName = "Use";
            this.useDataGridViewTextBoxColumn.HeaderText = "Use";
            this.useDataGridViewTextBoxColumn.Name = "useDataGridViewTextBoxColumn";
            this.useDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.useDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.typeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // questRewardBindingSource
            // 
            this.questRewardBindingSource.DataSource = typeof(Fiesta.FileFormats.Quest.Rewards.Reward);
            // 
            // MiniHouseIDRewardBox
            // 
            this.MiniHouseIDRewardBox.HasCustomDomain = false;
            this.MiniHouseIDRewardBox.Location = new System.Drawing.Point(431, 221);
            this.MiniHouseIDRewardBox.Max = 0D;
            this.MiniHouseIDRewardBox.Min = 0D;
            this.MiniHouseIDRewardBox.Name = "MiniHouseIDRewardBox";
            this.MiniHouseIDRewardBox.NumberType = NumberBox.NumberType.BYTE;
            this.MiniHouseIDRewardBox.Size = new System.Drawing.Size(64, 22);
            this.MiniHouseIDRewardBox.TabIndex = 19;
            // 
            // PetIDRewardBox
            // 
            this.PetIDRewardBox.HasCustomDomain = false;
            this.PetIDRewardBox.Location = new System.Drawing.Point(431, 193);
            this.PetIDRewardBox.Max = 0D;
            this.PetIDRewardBox.Min = 0D;
            this.PetIDRewardBox.Name = "PetIDRewardBox";
            this.PetIDRewardBox.NumberType = NumberBox.NumberType.UINT;
            this.PetIDRewardBox.Size = new System.Drawing.Size(64, 22);
            this.PetIDRewardBox.TabIndex = 17;
            // 
            // FameRewardBox
            // 
            this.FameRewardBox.HasCustomDomain = false;
            this.FameRewardBox.Location = new System.Drawing.Point(431, 165);
            this.FameRewardBox.Max = 0D;
            this.FameRewardBox.Min = 0D;
            this.FameRewardBox.Name = "FameRewardBox";
            this.FameRewardBox.NumberType = NumberBox.NumberType.UINT;
            this.FameRewardBox.Size = new System.Drawing.Size(64, 22);
            this.FameRewardBox.TabIndex = 15;
            // 
            // KillPointRewardBox
            // 
            this.KillPointRewardBox.HasCustomDomain = false;
            this.KillPointRewardBox.Location = new System.Drawing.Point(431, 279);
            this.KillPointRewardBox.Max = 0D;
            this.KillPointRewardBox.Min = 0D;
            this.KillPointRewardBox.Name = "KillPointRewardBox";
            this.KillPointRewardBox.NumberType = NumberBox.NumberType.UINT;
            this.KillPointRewardBox.Size = new System.Drawing.Size(64, 22);
            this.KillPointRewardBox.TabIndex = 25;
            // 
            // ElementNoRewardBox
            // 
            this.ElementNoRewardBox.HasCustomDomain = false;
            this.ElementNoRewardBox.Location = new System.Drawing.Point(663, 249);
            this.ElementNoRewardBox.Max = 0D;
            this.ElementNoRewardBox.Min = 0D;
            this.ElementNoRewardBox.Name = "ElementNoRewardBox";
            this.ElementNoRewardBox.NumberType = NumberBox.NumberType.USHORT;
            this.ElementNoRewardBox.Size = new System.Drawing.Size(64, 22);
            this.ElementNoRewardBox.TabIndex = 23;
            // 
            // AbstateIDRewardBox
            // 
            this.AbstateIDRewardBox.HasCustomDomain = false;
            this.AbstateIDRewardBox.Location = new System.Drawing.Point(431, 109);
            this.AbstateIDRewardBox.Max = 0D;
            this.AbstateIDRewardBox.Min = 0D;
            this.AbstateIDRewardBox.Name = "AbstateIDRewardBox";
            this.AbstateIDRewardBox.NumberType = NumberBox.NumberType.USHORT;
            this.AbstateIDRewardBox.Size = new System.Drawing.Size(64, 22);
            this.AbstateIDRewardBox.TabIndex = 9;
            // 
            // AbstateStrengthRewardBox
            // 
            this.AbstateStrengthRewardBox.HasCustomDomain = false;
            this.AbstateStrengthRewardBox.Location = new System.Drawing.Point(663, 109);
            this.AbstateStrengthRewardBox.Max = 0D;
            this.AbstateStrengthRewardBox.Min = 0D;
            this.AbstateStrengthRewardBox.Name = "AbstateStrengthRewardBox";
            this.AbstateStrengthRewardBox.NumberType = NumberBox.NumberType.USHORT;
            this.AbstateStrengthRewardBox.Size = new System.Drawing.Size(64, 22);
            this.AbstateStrengthRewardBox.TabIndex = 11;
            // 
            // AbstateTimeRewardBox
            // 
            this.AbstateTimeRewardBox.HasCustomDomain = false;
            this.AbstateTimeRewardBox.Location = new System.Drawing.Point(663, 137);
            this.AbstateTimeRewardBox.Max = 0D;
            this.AbstateTimeRewardBox.Min = 0D;
            this.AbstateTimeRewardBox.Name = "AbstateTimeRewardBox";
            this.AbstateTimeRewardBox.NumberType = NumberBox.NumberType.INT;
            this.AbstateTimeRewardBox.Size = new System.Drawing.Size(64, 22);
            this.AbstateTimeRewardBox.TabIndex = 13;
            // 
            // ItemLotRewardBox
            // 
            this.ItemLotRewardBox.HasCustomDomain = false;
            this.ItemLotRewardBox.Location = new System.Drawing.Point(663, 81);
            this.ItemLotRewardBox.Max = 0D;
            this.ItemLotRewardBox.Min = 0D;
            this.ItemLotRewardBox.Name = "ItemLotRewardBox";
            this.ItemLotRewardBox.NumberType = NumberBox.NumberType.USHORT;
            this.ItemLotRewardBox.Size = new System.Drawing.Size(64, 22);
            this.ItemLotRewardBox.TabIndex = 7;
            // 
            // ItemIDRewardBox
            // 
            this.ItemIDRewardBox.HasCustomDomain = false;
            this.ItemIDRewardBox.Location = new System.Drawing.Point(431, 81);
            this.ItemIDRewardBox.Max = 0D;
            this.ItemIDRewardBox.Min = 0D;
            this.ItemIDRewardBox.Name = "ItemIDRewardBox";
            this.ItemIDRewardBox.NumberType = NumberBox.NumberType.USHORT;
            this.ItemIDRewardBox.Size = new System.Drawing.Size(64, 22);
            this.ItemIDRewardBox.TabIndex = 5;
            // 
            // MoneyRewardBox
            // 
            this.MoneyRewardBox.HasCustomDomain = false;
            this.MoneyRewardBox.Location = new System.Drawing.Point(431, 53);
            this.MoneyRewardBox.Max = 0D;
            this.MoneyRewardBox.Min = 0D;
            this.MoneyRewardBox.Name = "MoneyRewardBox";
            this.MoneyRewardBox.NumberType = NumberBox.NumberType.UINT;
            this.MoneyRewardBox.Size = new System.Drawing.Size(64, 22);
            this.MoneyRewardBox.TabIndex = 3;
            // 
            // ExpRewardBox
            // 
            this.ExpRewardBox.HasCustomDomain = false;
            this.ExpRewardBox.Location = new System.Drawing.Point(431, 25);
            this.ExpRewardBox.Max = 0D;
            this.ExpRewardBox.Min = 0D;
            this.ExpRewardBox.Name = "ExpRewardBox";
            this.ExpRewardBox.NumberType = NumberBox.NumberType.UINT;
            this.ExpRewardBox.Size = new System.Drawing.Size(64, 22);
            this.ExpRewardBox.TabIndex = 1;
            // 
            // ItemInfoTab
            // 
            this.ItemInfoTab.Location = new System.Drawing.Point(4, 25);
            this.ItemInfoTab.Name = "ItemInfoTab";
            this.ItemInfoTab.Size = new System.Drawing.Size(738, 489);
            this.ItemInfoTab.TabIndex = 7;
            this.ItemInfoTab.Text = "Item Info";
            this.ItemInfoTab.UseVisualStyleBackColor = true;
            // 
            // MobInfoTab
            // 
            this.MobInfoTab.Location = new System.Drawing.Point(4, 25);
            this.MobInfoTab.Name = "MobInfoTab";
            this.MobInfoTab.Size = new System.Drawing.Size(738, 489);
            this.MobInfoTab.TabIndex = 6;
            this.MobInfoTab.Text = "Mob Info";
            this.MobInfoTab.UseVisualStyleBackColor = true;
            // 
            // EndScriptTab
            // 
            this.EndScriptTab.Controls.Add(this.EndScriptBox);
            this.EndScriptTab.Location = new System.Drawing.Point(4, 25);
            this.EndScriptTab.Name = "EndScriptTab";
            this.EndScriptTab.Size = new System.Drawing.Size(738, 489);
            this.EndScriptTab.TabIndex = 5;
            this.EndScriptTab.Text = "End Script";
            this.EndScriptTab.UseVisualStyleBackColor = true;
            // 
            // EndScriptBox
            // 
            this.EndScriptBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EndScriptBox.Location = new System.Drawing.Point(0, 0);
            this.EndScriptBox.Multiline = true;
            this.EndScriptBox.Name = "EndScriptBox";
            this.EndScriptBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.EndScriptBox.Size = new System.Drawing.Size(738, 489);
            this.EndScriptBox.TabIndex = 0;
            // 
            // ActiveScriptTab
            // 
            this.ActiveScriptTab.Controls.Add(this.ActiveScriptBox);
            this.ActiveScriptTab.Location = new System.Drawing.Point(4, 25);
            this.ActiveScriptTab.Name = "ActiveScriptTab";
            this.ActiveScriptTab.Size = new System.Drawing.Size(738, 489);
            this.ActiveScriptTab.TabIndex = 4;
            this.ActiveScriptTab.Text = "Active Script";
            this.ActiveScriptTab.UseVisualStyleBackColor = true;
            // 
            // ActiveScriptBox
            // 
            this.ActiveScriptBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ActiveScriptBox.Location = new System.Drawing.Point(0, 0);
            this.ActiveScriptBox.Multiline = true;
            this.ActiveScriptBox.Name = "ActiveScriptBox";
            this.ActiveScriptBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ActiveScriptBox.Size = new System.Drawing.Size(738, 489);
            this.ActiveScriptBox.TabIndex = 0;
            // 
            // StartScriptTab
            // 
            this.StartScriptTab.Controls.Add(this.StartScriptBox);
            this.StartScriptTab.Location = new System.Drawing.Point(4, 25);
            this.StartScriptTab.Name = "StartScriptTab";
            this.StartScriptTab.Padding = new System.Windows.Forms.Padding(3);
            this.StartScriptTab.Size = new System.Drawing.Size(738, 489);
            this.StartScriptTab.TabIndex = 3;
            this.StartScriptTab.Text = "Start Script";
            this.StartScriptTab.UseVisualStyleBackColor = true;
            // 
            // StartScriptBox
            // 
            this.StartScriptBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StartScriptBox.Location = new System.Drawing.Point(3, 3);
            this.StartScriptBox.Multiline = true;
            this.StartScriptBox.Name = "StartScriptBox";
            this.StartScriptBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.StartScriptBox.Size = new System.Drawing.Size(732, 483);
            this.StartScriptBox.TabIndex = 1;
            // 
            // EndInfoTab
            // 
            this.EndInfoTab.Controls.Add(this.EndGroupBox);
            this.EndInfoTab.Location = new System.Drawing.Point(4, 25);
            this.EndInfoTab.Name = "EndInfoTab";
            this.EndInfoTab.Padding = new System.Windows.Forms.Padding(3);
            this.EndInfoTab.Size = new System.Drawing.Size(738, 489);
            this.EndInfoTab.TabIndex = 10;
            this.EndInfoTab.Text = "End Info";
            this.EndInfoTab.UseVisualStyleBackColor = true;
            // 
            // EndGroupBox
            // 
            this.EndGroupBox.Controls.Add(this.EndLevelBox);
            this.EndGroupBox.Controls.Add(this.EndClassBox);
            this.EndGroupBox.Controls.Add(this.EndRaceBox);
            this.EndGroupBox.Controls.Add(this.EndTimeLimitBox);
            this.EndGroupBox.Controls.Add(this.EndTimeLimitLabel);
            this.EndGroupBox.Controls.Add(this.EndHasTimeLimitBox);
            this.EndGroupBox.Controls.Add(this.EndHasTimeLimitLabel);
            this.EndGroupBox.Controls.Add(this.EndRaceLabel);
            this.EndGroupBox.Controls.Add(this.EndNeedsRaceBox);
            this.EndGroupBox.Controls.Add(this.EndNeedsRaceLabel);
            this.EndGroupBox.Controls.Add(this.EndClassLabel);
            this.EndGroupBox.Controls.Add(this.EndNeedsClassBox);
            this.EndGroupBox.Controls.Add(this.EndNeedsClassLabel);
            this.EndGroupBox.Controls.Add(this.EndScenarioIDBox);
            this.EndGroupBox.Controls.Add(this.EndScenarioIDLabel);
            this.EndGroupBox.Controls.Add(this.EndNeedsScenarioBox);
            this.EndGroupBox.Controls.Add(this.EndNeedsScenarioLabel);
            this.EndGroupBox.Controls.Add(this.EndLocationBox);
            this.EndGroupBox.Controls.Add(this.EndLocationLabel);
            this.EndGroupBox.Controls.Add(this.EndUnkBox);
            this.EndGroupBox.Controls.Add(this.EndUnkLabel);
            this.EndGroupBox.Controls.Add(this.EndRangeBox);
            this.EndGroupBox.Controls.Add(this.EndRangeLabel);
            this.EndGroupBox.Controls.Add(this.EndYBox);
            this.EndGroupBox.Controls.Add(this.EndYLabel);
            this.EndGroupBox.Controls.Add(this.EndXBox);
            this.EndGroupBox.Controls.Add(this.EndXLabel);
            this.EndGroupBox.Controls.Add(this.EndNeedsLocationBox);
            this.EndGroupBox.Controls.Add(this.EndNeedsLocationLabel);
            this.EndGroupBox.Controls.Add(this.EndLevelLabel);
            this.EndGroupBox.Controls.Add(this.EndNeedsLevelBox);
            this.EndGroupBox.Controls.Add(this.EndIsInstantHandInLabel);
            this.EndGroupBox.Controls.Add(this.EndNeedsLevelLabel);
            this.EndGroupBox.Controls.Add(this.EndIsInstantHandInBox);
            this.EndGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EndGroupBox.Location = new System.Drawing.Point(3, 3);
            this.EndGroupBox.Name = "EndGroupBox";
            this.EndGroupBox.Size = new System.Drawing.Size(732, 483);
            this.EndGroupBox.TabIndex = 29;
            this.EndGroupBox.TabStop = false;
            this.EndGroupBox.Text = "End Info";
            // 
            // EndLevelBox
            // 
            this.EndLevelBox.HasCustomDomain = false;
            this.EndLevelBox.Location = new System.Drawing.Point(277, 61);
            this.EndLevelBox.Max = 0D;
            this.EndLevelBox.Min = 0D;
            this.EndLevelBox.Name = "EndLevelBox";
            this.EndLevelBox.NumberType = NumberBox.NumberType.BYTE;
            this.EndLevelBox.Size = new System.Drawing.Size(62, 22);
            this.EndLevelBox.TabIndex = 60;
            // 
            // EndClassBox
            // 
            this.EndClassBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EndClassBox.FormattingEnabled = true;
            this.EndClassBox.Location = new System.Drawing.Point(277, 234);
            this.EndClassBox.Name = "EndClassBox";
            this.EndClassBox.Size = new System.Drawing.Size(126, 24);
            this.EndClassBox.TabIndex = 59;
            this.EndClassBox.TabStop = false;
            // 
            // EndRaceBox
            // 
            this.EndRaceBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EndRaceBox.FormattingEnabled = true;
            this.EndRaceBox.Location = new System.Drawing.Point(277, 204);
            this.EndRaceBox.Name = "EndRaceBox";
            this.EndRaceBox.Size = new System.Drawing.Size(126, 24);
            this.EndRaceBox.TabIndex = 26;
            this.EndRaceBox.TabStop = false;
            // 
            // EndTimeLimitBox
            // 
            this.EndTimeLimitBox.HasCustomDomain = false;
            this.EndTimeLimitBox.Location = new System.Drawing.Point(277, 265);
            this.EndTimeLimitBox.Max = 0D;
            this.EndTimeLimitBox.Min = 0D;
            this.EndTimeLimitBox.Multiline = true;
            this.EndTimeLimitBox.Name = "EndTimeLimitBox";
            this.EndTimeLimitBox.NumberType = NumberBox.NumberType.USHORT;
            this.EndTimeLimitBox.Size = new System.Drawing.Size(62, 22);
            this.EndTimeLimitBox.TabIndex = 57;
            // 
            // EndTimeLimitLabel
            // 
            this.EndTimeLimitLabel.AutoSize = true;
            this.EndTimeLimitLabel.Location = new System.Drawing.Point(199, 268);
            this.EndTimeLimitLabel.Name = "EndTimeLimitLabel";
            this.EndTimeLimitLabel.Size = new System.Drawing.Size(72, 17);
            this.EndTimeLimitLabel.TabIndex = 58;
            this.EndTimeLimitLabel.Text = "TimeLimit:";
            // 
            // EndHasTimeLimitBox
            // 
            this.EndHasTimeLimitBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EndHasTimeLimitBox.FormattingEnabled = true;
            this.EndHasTimeLimitBox.Location = new System.Drawing.Point(122, 265);
            this.EndHasTimeLimitBox.Name = "EndHasTimeLimitBox";
            this.EndHasTimeLimitBox.Size = new System.Drawing.Size(62, 24);
            this.EndHasTimeLimitBox.TabIndex = 56;
            this.EndHasTimeLimitBox.TabStop = false;
            this.EndHasTimeLimitBox.SelectionChangeCommitted += new System.EventHandler(this.EndHasTimeLimitBox_SelectionChangeCommitted);
            // 
            // EndHasTimeLimitLabel
            // 
            this.EndHasTimeLimitLabel.AutoSize = true;
            this.EndHasTimeLimitLabel.Location = new System.Drawing.Point(19, 268);
            this.EndHasTimeLimitLabel.Name = "EndHasTimeLimitLabel";
            this.EndHasTimeLimitLabel.Size = new System.Drawing.Size(97, 17);
            this.EndHasTimeLimitLabel.TabIndex = 55;
            this.EndHasTimeLimitLabel.Text = "HasTimeLimit:";
            // 
            // EndRaceLabel
            // 
            this.EndRaceLabel.AutoSize = true;
            this.EndRaceLabel.Location = new System.Drawing.Point(226, 207);
            this.EndRaceLabel.Name = "EndRaceLabel";
            this.EndRaceLabel.Size = new System.Drawing.Size(45, 17);
            this.EndRaceLabel.TabIndex = 54;
            this.EndRaceLabel.Text = "Race:";
            // 
            // EndNeedsRaceBox
            // 
            this.EndNeedsRaceBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EndNeedsRaceBox.FormattingEnabled = true;
            this.EndNeedsRaceBox.Location = new System.Drawing.Point(122, 204);
            this.EndNeedsRaceBox.Name = "EndNeedsRaceBox";
            this.EndNeedsRaceBox.Size = new System.Drawing.Size(62, 24);
            this.EndNeedsRaceBox.TabIndex = 52;
            this.EndNeedsRaceBox.TabStop = false;
            this.EndNeedsRaceBox.SelectionChangeCommitted += new System.EventHandler(this.EndNeedsRaceBox_SelectionChangeCommitted);
            // 
            // EndNeedsRaceLabel
            // 
            this.EndNeedsRaceLabel.AutoSize = true;
            this.EndNeedsRaceLabel.Location = new System.Drawing.Point(30, 207);
            this.EndNeedsRaceLabel.Name = "EndNeedsRaceLabel";
            this.EndNeedsRaceLabel.Size = new System.Drawing.Size(86, 17);
            this.EndNeedsRaceLabel.TabIndex = 51;
            this.EndNeedsRaceLabel.Text = "NeedsRace:";
            // 
            // EndClassLabel
            // 
            this.EndClassLabel.AutoSize = true;
            this.EndClassLabel.Location = new System.Drawing.Point(225, 237);
            this.EndClassLabel.Name = "EndClassLabel";
            this.EndClassLabel.Size = new System.Drawing.Size(46, 17);
            this.EndClassLabel.TabIndex = 50;
            this.EndClassLabel.Text = "Class:";
            // 
            // EndNeedsClassBox
            // 
            this.EndNeedsClassBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EndNeedsClassBox.FormattingEnabled = true;
            this.EndNeedsClassBox.Location = new System.Drawing.Point(122, 234);
            this.EndNeedsClassBox.Name = "EndNeedsClassBox";
            this.EndNeedsClassBox.Size = new System.Drawing.Size(62, 24);
            this.EndNeedsClassBox.TabIndex = 48;
            this.EndNeedsClassBox.TabStop = false;
            this.EndNeedsClassBox.SelectionChangeCommitted += new System.EventHandler(this.EndNeedsClassBox_SelectionChangeCommitted);
            // 
            // EndNeedsClassLabel
            // 
            this.EndNeedsClassLabel.AutoSize = true;
            this.EndNeedsClassLabel.Location = new System.Drawing.Point(29, 237);
            this.EndNeedsClassLabel.Name = "EndNeedsClassLabel";
            this.EndNeedsClassLabel.Size = new System.Drawing.Size(87, 17);
            this.EndNeedsClassLabel.TabIndex = 47;
            this.EndNeedsClassLabel.Text = "NeedsClass:";
            // 
            // EndScenarioIDBox
            // 
            this.EndScenarioIDBox.HasCustomDomain = false;
            this.EndScenarioIDBox.Location = new System.Drawing.Point(277, 176);
            this.EndScenarioIDBox.Max = 0D;
            this.EndScenarioIDBox.Min = 0D;
            this.EndScenarioIDBox.Multiline = true;
            this.EndScenarioIDBox.Name = "EndScenarioIDBox";
            this.EndScenarioIDBox.NumberType = NumberBox.NumberType.USHORT;
            this.EndScenarioIDBox.Size = new System.Drawing.Size(62, 22);
            this.EndScenarioIDBox.TabIndex = 45;
            // 
            // EndScenarioIDLabel
            // 
            this.EndScenarioIDLabel.AutoSize = true;
            this.EndScenarioIDLabel.Location = new System.Drawing.Point(190, 179);
            this.EndScenarioIDLabel.Name = "EndScenarioIDLabel";
            this.EndScenarioIDLabel.Size = new System.Drawing.Size(81, 17);
            this.EndScenarioIDLabel.TabIndex = 46;
            this.EndScenarioIDLabel.Text = "ScenarioID:";
            // 
            // EndNeedsScenarioBox
            // 
            this.EndNeedsScenarioBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EndNeedsScenarioBox.FormattingEnabled = true;
            this.EndNeedsScenarioBox.Location = new System.Drawing.Point(122, 176);
            this.EndNeedsScenarioBox.Name = "EndNeedsScenarioBox";
            this.EndNeedsScenarioBox.Size = new System.Drawing.Size(62, 24);
            this.EndNeedsScenarioBox.TabIndex = 44;
            this.EndNeedsScenarioBox.TabStop = false;
            this.EndNeedsScenarioBox.SelectionChangeCommitted += new System.EventHandler(this.EndNeedsScenarioBox_SelectionChangeCommitted);
            // 
            // EndNeedsScenarioLabel
            // 
            this.EndNeedsScenarioLabel.AutoSize = true;
            this.EndNeedsScenarioLabel.Location = new System.Drawing.Point(7, 179);
            this.EndNeedsScenarioLabel.Name = "EndNeedsScenarioLabel";
            this.EndNeedsScenarioLabel.Size = new System.Drawing.Size(109, 17);
            this.EndNeedsScenarioLabel.TabIndex = 43;
            this.EndNeedsScenarioLabel.Text = "NeedsScenario:";
            // 
            // EndLocationBox
            // 
            this.EndLocationBox.HasCustomDomain = false;
            this.EndLocationBox.Location = new System.Drawing.Point(277, 89);
            this.EndLocationBox.Max = 0D;
            this.EndLocationBox.Min = 0D;
            this.EndLocationBox.Multiline = true;
            this.EndLocationBox.Name = "EndLocationBox";
            this.EndLocationBox.NumberType = NumberBox.NumberType.USHORT;
            this.EndLocationBox.Size = new System.Drawing.Size(62, 22);
            this.EndLocationBox.TabIndex = 41;
            // 
            // EndLocationLabel
            // 
            this.EndLocationLabel.AutoSize = true;
            this.EndLocationLabel.Location = new System.Drawing.Point(205, 92);
            this.EndLocationLabel.Name = "EndLocationLabel";
            this.EndLocationLabel.Size = new System.Drawing.Size(66, 17);
            this.EndLocationLabel.TabIndex = 42;
            this.EndLocationLabel.Text = "Location:";
            // 
            // EndUnkBox
            // 
            this.EndUnkBox.HasCustomDomain = false;
            this.EndUnkBox.Location = new System.Drawing.Point(387, 145);
            this.EndUnkBox.Max = 0D;
            this.EndUnkBox.Min = 0D;
            this.EndUnkBox.Multiline = true;
            this.EndUnkBox.Name = "EndUnkBox";
            this.EndUnkBox.NumberType = NumberBox.NumberType.INT;
            this.EndUnkBox.Size = new System.Drawing.Size(62, 22);
            this.EndUnkBox.TabIndex = 39;
            // 
            // EndUnkLabel
            // 
            this.EndUnkLabel.AutoSize = true;
            this.EndUnkLabel.Location = new System.Drawing.Point(345, 148);
            this.EndUnkLabel.Name = "EndUnkLabel";
            this.EndUnkLabel.Size = new System.Drawing.Size(41, 17);
            this.EndUnkLabel.TabIndex = 40;
            this.EndUnkLabel.Text = "Unk: ";
            // 
            // EndRangeBox
            // 
            this.EndRangeBox.HasCustomDomain = false;
            this.EndRangeBox.Location = new System.Drawing.Point(277, 145);
            this.EndRangeBox.Max = 0D;
            this.EndRangeBox.Min = 0D;
            this.EndRangeBox.Multiline = true;
            this.EndRangeBox.Name = "EndRangeBox";
            this.EndRangeBox.NumberType = NumberBox.NumberType.UINT;
            this.EndRangeBox.Size = new System.Drawing.Size(62, 22);
            this.EndRangeBox.TabIndex = 37;
            // 
            // EndRangeLabel
            // 
            this.EndRangeLabel.AutoSize = true;
            this.EndRangeLabel.Location = new System.Drawing.Point(217, 148);
            this.EndRangeLabel.Name = "EndRangeLabel";
            this.EndRangeLabel.Size = new System.Drawing.Size(54, 17);
            this.EndRangeLabel.TabIndex = 38;
            this.EndRangeLabel.Text = "Range:";
            // 
            // EndYBox
            // 
            this.EndYBox.HasCustomDomain = false;
            this.EndYBox.Location = new System.Drawing.Point(387, 117);
            this.EndYBox.Max = 0D;
            this.EndYBox.Min = 0D;
            this.EndYBox.Multiline = true;
            this.EndYBox.Name = "EndYBox";
            this.EndYBox.NumberType = NumberBox.NumberType.UINT;
            this.EndYBox.Size = new System.Drawing.Size(62, 22);
            this.EndYBox.TabIndex = 35;
            // 
            // EndYLabel
            // 
            this.EndYLabel.AutoSize = true;
            this.EndYLabel.Location = new System.Drawing.Point(360, 120);
            this.EndYLabel.Name = "EndYLabel";
            this.EndYLabel.Size = new System.Drawing.Size(21, 17);
            this.EndYLabel.TabIndex = 36;
            this.EndYLabel.Text = "Y:";
            // 
            // EndXBox
            // 
            this.EndXBox.HasCustomDomain = false;
            this.EndXBox.Location = new System.Drawing.Point(277, 117);
            this.EndXBox.Max = 0D;
            this.EndXBox.Min = 0D;
            this.EndXBox.Multiline = true;
            this.EndXBox.Name = "EndXBox";
            this.EndXBox.NumberType = NumberBox.NumberType.UINT;
            this.EndXBox.Size = new System.Drawing.Size(62, 22);
            this.EndXBox.TabIndex = 33;
            // 
            // EndXLabel
            // 
            this.EndXLabel.AutoSize = true;
            this.EndXLabel.Location = new System.Drawing.Point(250, 120);
            this.EndXLabel.Name = "EndXLabel";
            this.EndXLabel.Size = new System.Drawing.Size(21, 17);
            this.EndXLabel.TabIndex = 34;
            this.EndXLabel.Text = "X:";
            // 
            // EndNeedsLocationBox
            // 
            this.EndNeedsLocationBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EndNeedsLocationBox.FormattingEnabled = true;
            this.EndNeedsLocationBox.Location = new System.Drawing.Point(122, 87);
            this.EndNeedsLocationBox.Name = "EndNeedsLocationBox";
            this.EndNeedsLocationBox.Size = new System.Drawing.Size(62, 24);
            this.EndNeedsLocationBox.TabIndex = 32;
            this.EndNeedsLocationBox.TabStop = false;
            this.EndNeedsLocationBox.SelectionChangeCommitted += new System.EventHandler(this.EndNeedsLocationBox_SelectionChangeCommitted);
            // 
            // EndNeedsLocationLabel
            // 
            this.EndNeedsLocationLabel.AutoSize = true;
            this.EndNeedsLocationLabel.Location = new System.Drawing.Point(9, 92);
            this.EndNeedsLocationLabel.Name = "EndNeedsLocationLabel";
            this.EndNeedsLocationLabel.Size = new System.Drawing.Size(107, 17);
            this.EndNeedsLocationLabel.TabIndex = 31;
            this.EndNeedsLocationLabel.Text = "NeedsLocation:";
            // 
            // EndLevelLabel
            // 
            this.EndLevelLabel.AutoSize = true;
            this.EndLevelLabel.Location = new System.Drawing.Point(225, 64);
            this.EndLevelLabel.Name = "EndLevelLabel";
            this.EndLevelLabel.Size = new System.Drawing.Size(46, 17);
            this.EndLevelLabel.TabIndex = 30;
            this.EndLevelLabel.Text = "Level:";
            // 
            // EndNeedsLevelBox
            // 
            this.EndNeedsLevelBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EndNeedsLevelBox.FormattingEnabled = true;
            this.EndNeedsLevelBox.Location = new System.Drawing.Point(122, 58);
            this.EndNeedsLevelBox.Name = "EndNeedsLevelBox";
            this.EndNeedsLevelBox.Size = new System.Drawing.Size(62, 24);
            this.EndNeedsLevelBox.TabIndex = 29;
            this.EndNeedsLevelBox.TabStop = false;
            this.EndNeedsLevelBox.SelectionChangeCommitted += new System.EventHandler(this.EndNeedsLevelBox_SelectionChangeCommitted);
            // 
            // EndIsInstantHandInLabel
            // 
            this.EndIsInstantHandInLabel.AutoSize = true;
            this.EndIsInstantHandInLabel.Location = new System.Drawing.Point(7, 31);
            this.EndIsInstantHandInLabel.Name = "EndIsInstantHandInLabel";
            this.EndIsInstantHandInLabel.Size = new System.Drawing.Size(109, 17);
            this.EndIsInstantHandInLabel.TabIndex = 26;
            this.EndIsInstantHandInLabel.Text = "IsInstantHandIn:";
            // 
            // EndNeedsLevelLabel
            // 
            this.EndNeedsLevelLabel.AutoSize = true;
            this.EndNeedsLevelLabel.Location = new System.Drawing.Point(29, 61);
            this.EndNeedsLevelLabel.Name = "EndNeedsLevelLabel";
            this.EndNeedsLevelLabel.Size = new System.Drawing.Size(87, 17);
            this.EndNeedsLevelLabel.TabIndex = 28;
            this.EndNeedsLevelLabel.Text = "NeedsLevel:";
            // 
            // EndIsInstantHandInBox
            // 
            this.EndIsInstantHandInBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EndIsInstantHandInBox.FormattingEnabled = true;
            this.EndIsInstantHandInBox.Location = new System.Drawing.Point(122, 28);
            this.EndIsInstantHandInBox.Name = "EndIsInstantHandInBox";
            this.EndIsInstantHandInBox.Size = new System.Drawing.Size(62, 24);
            this.EndIsInstantHandInBox.TabIndex = 27;
            this.EndIsInstantHandInBox.TabStop = false;
            // 
            // StartInfoTab
            // 
            this.StartInfoTab.Controls.Add(this.StartGroupBox);
            this.StartInfoTab.Location = new System.Drawing.Point(4, 25);
            this.StartInfoTab.Name = "StartInfoTab";
            this.StartInfoTab.Padding = new System.Windows.Forms.Padding(3);
            this.StartInfoTab.Size = new System.Drawing.Size(738, 489);
            this.StartInfoTab.TabIndex = 9;
            this.StartInfoTab.Text = "Start Info";
            this.StartInfoTab.UseVisualStyleBackColor = true;
            // 
            // StartGroupBox
            // 
            this.StartGroupBox.Controls.Add(this.StartDateEndBox);
            this.StartGroupBox.Controls.Add(this.StartDateEndLabel);
            this.StartGroupBox.Controls.Add(this.StartDateStartBox);
            this.StartGroupBox.Controls.Add(this.StartDateStartLabel);
            this.StartGroupBox.Controls.Add(this.StartItemIDBox);
            this.StartGroupBox.Controls.Add(this.StartNPCIDBox);
            this.StartGroupBox.Controls.Add(this.StartMaxLevelBox);
            this.StartGroupBox.Controls.Add(this.StartMinLevelBox);
            this.StartGroupBox.Controls.Add(this.StartDateModeBox);
            this.StartGroupBox.Controls.Add(this.StartDateModeLabel);
            this.StartGroupBox.Controls.Add(this.StartNeedsDateBox);
            this.StartGroupBox.Controls.Add(this.StartNeedsDateLabel);
            this.StartGroupBox.Controls.Add(this.StartGenderBox);
            this.StartGroupBox.Controls.Add(this.StartGenderLabel);
            this.StartGroupBox.Controls.Add(this.StartNeedsGenderBox);
            this.StartGroupBox.Controls.Add(this.StartNeedsGenderLabel);
            this.StartGroupBox.Controls.Add(this.StartClassBox);
            this.StartGroupBox.Controls.Add(this.StartRaceBox);
            this.StartGroupBox.Controls.Add(this.StartPreviousQuestBox);
            this.StartGroupBox.Controls.Add(this.StartRaceLabel);
            this.StartGroupBox.Controls.Add(this.StartPreviousQuestLabel);
            this.StartGroupBox.Controls.Add(this.StartNeedsRaceBox);
            this.StartGroupBox.Controls.Add(this.StartNeedsRaceLabel);
            this.StartGroupBox.Controls.Add(this.StartNeedsQuestBox);
            this.StartGroupBox.Controls.Add(this.StartClassLabel);
            this.StartGroupBox.Controls.Add(this.StartNeedsQuestLabel);
            this.StartGroupBox.Controls.Add(this.StartNeedsClassBox);
            this.StartGroupBox.Controls.Add(this.StartLocationBox);
            this.StartGroupBox.Controls.Add(this.StartNeedsClassLabel);
            this.StartGroupBox.Controls.Add(this.StartLocationLabel);
            this.StartGroupBox.Controls.Add(this.StartUnkBox);
            this.StartGroupBox.Controls.Add(this.StartUnkLabel);
            this.StartGroupBox.Controls.Add(this.StartRangeBox);
            this.StartGroupBox.Controls.Add(this.StartRangeLabel);
            this.StartGroupBox.Controls.Add(this.StartYBox);
            this.StartGroupBox.Controls.Add(this.StartYLabel);
            this.StartGroupBox.Controls.Add(this.StartXBox);
            this.StartGroupBox.Controls.Add(this.StartXLabel);
            this.StartGroupBox.Controls.Add(this.StartNeedsLocationBox);
            this.StartGroupBox.Controls.Add(this.StartNeedsLocationLabel);
            this.StartGroupBox.Controls.Add(this.StartItemIDLabel);
            this.StartGroupBox.Controls.Add(this.StartItemLotLabel);
            this.StartGroupBox.Controls.Add(this.StartItemLotBox);
            this.StartGroupBox.Controls.Add(this.StartNeedsItemBox);
            this.StartGroupBox.Controls.Add(this.StartNeedsItemLabel);
            this.StartGroupBox.Controls.Add(this.StartNPCIDLabel);
            this.StartGroupBox.Controls.Add(this.StartNeedsNPCBox);
            this.StartGroupBox.Controls.Add(this.StartNeedsNPCLabel);
            this.StartGroupBox.Controls.Add(this.StartMaxLevelLabel);
            this.StartGroupBox.Controls.Add(this.StartIsWaitListProgressBox);
            this.StartGroupBox.Controls.Add(this.StartMinLevelLabel);
            this.StartGroupBox.Controls.Add(this.StartIsInstantAcceptBox);
            this.StartGroupBox.Controls.Add(this.StartNeedsLevelBox);
            this.StartGroupBox.Controls.Add(this.StartNeedsLevelLabel);
            this.StartGroupBox.Controls.Add(this.StartIsWaitListProgressLabel);
            this.StartGroupBox.Controls.Add(this.StartIsWaitListViewLabel);
            this.StartGroupBox.Controls.Add(this.StartIsWaitListViewBox);
            this.StartGroupBox.Controls.Add(this.StartIsInstantAcceptLabel);
            this.StartGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StartGroupBox.Location = new System.Drawing.Point(3, 3);
            this.StartGroupBox.Name = "StartGroupBox";
            this.StartGroupBox.Size = new System.Drawing.Size(732, 483);
            this.StartGroupBox.TabIndex = 28;
            this.StartGroupBox.TabStop = false;
            this.StartGroupBox.Text = "Start Info";
            // 
            // StartDateEndBox
            // 
            this.StartDateEndBox.HasCustomDomain = false;
            this.StartDateEndBox.Location = new System.Drawing.Point(308, 449);
            this.StartDateEndBox.Max = 0D;
            this.StartDateEndBox.Min = 0D;
            this.StartDateEndBox.Name = "StartDateEndBox";
            this.StartDateEndBox.NumberType = NumberBox.NumberType.LONG;
            this.StartDateEndBox.Size = new System.Drawing.Size(126, 22);
            this.StartDateEndBox.TabIndex = 119;
            // 
            // StartDateEndLabel
            // 
            this.StartDateEndLabel.AutoSize = true;
            this.StartDateEndLabel.Location = new System.Drawing.Point(232, 452);
            this.StartDateEndLabel.Name = "StartDateEndLabel";
            this.StartDateEndLabel.Size = new System.Drawing.Size(67, 17);
            this.StartDateEndLabel.TabIndex = 114;
            this.StartDateEndLabel.Text = "DateEnd:";
            // 
            // StartDateStartBox
            // 
            this.StartDateStartBox.HasCustomDomain = false;
            this.StartDateStartBox.Location = new System.Drawing.Point(308, 421);
            this.StartDateStartBox.Max = 0D;
            this.StartDateStartBox.Min = 0D;
            this.StartDateStartBox.Name = "StartDateStartBox";
            this.StartDateStartBox.NumberType = NumberBox.NumberType.LONG;
            this.StartDateStartBox.Size = new System.Drawing.Size(126, 22);
            this.StartDateStartBox.TabIndex = 118;
            // 
            // StartDateStartLabel
            // 
            this.StartDateStartLabel.AutoSize = true;
            this.StartDateStartLabel.Location = new System.Drawing.Point(230, 424);
            this.StartDateStartLabel.Name = "StartDateStartLabel";
            this.StartDateStartLabel.Size = new System.Drawing.Size(72, 17);
            this.StartDateStartLabel.TabIndex = 112;
            this.StartDateStartLabel.Text = "DateStart:";
            // 
            // StartItemIDBox
            // 
            this.StartItemIDBox.HasCustomDomain = false;
            this.StartItemIDBox.Location = new System.Drawing.Point(308, 158);
            this.StartItemIDBox.Max = 0D;
            this.StartItemIDBox.Min = 0D;
            this.StartItemIDBox.Name = "StartItemIDBox";
            this.StartItemIDBox.NumberType = NumberBox.NumberType.USHORT;
            this.StartItemIDBox.Size = new System.Drawing.Size(62, 22);
            this.StartItemIDBox.TabIndex = 110;
            // 
            // StartNPCIDBox
            // 
            this.StartNPCIDBox.HasCustomDomain = false;
            this.StartNPCIDBox.Location = new System.Drawing.Point(308, 129);
            this.StartNPCIDBox.Max = 0D;
            this.StartNPCIDBox.Min = 0D;
            this.StartNPCIDBox.Name = "StartNPCIDBox";
            this.StartNPCIDBox.NumberType = NumberBox.NumberType.USHORT;
            this.StartNPCIDBox.Size = new System.Drawing.Size(62, 22);
            this.StartNPCIDBox.TabIndex = 109;
            // 
            // StartMaxLevelBox
            // 
            this.StartMaxLevelBox.HasCustomDomain = false;
            this.StartMaxLevelBox.Location = new System.Drawing.Point(418, 99);
            this.StartMaxLevelBox.Max = 0D;
            this.StartMaxLevelBox.Min = 0D;
            this.StartMaxLevelBox.Name = "StartMaxLevelBox";
            this.StartMaxLevelBox.NumberType = NumberBox.NumberType.BYTE;
            this.StartMaxLevelBox.Size = new System.Drawing.Size(62, 22);
            this.StartMaxLevelBox.TabIndex = 108;
            // 
            // StartMinLevelBox
            // 
            this.StartMinLevelBox.HasCustomDomain = false;
            this.StartMinLevelBox.Location = new System.Drawing.Point(308, 99);
            this.StartMinLevelBox.Max = 0D;
            this.StartMinLevelBox.Min = 0D;
            this.StartMinLevelBox.Name = "StartMinLevelBox";
            this.StartMinLevelBox.NumberType = NumberBox.NumberType.BYTE;
            this.StartMinLevelBox.Size = new System.Drawing.Size(62, 22);
            this.StartMinLevelBox.TabIndex = 107;
            // 
            // StartDateModeBox
            // 
            this.StartDateModeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StartDateModeBox.FormattingEnabled = true;
            this.StartDateModeBox.Location = new System.Drawing.Point(308, 391);
            this.StartDateModeBox.Name = "StartDateModeBox";
            this.StartDateModeBox.Size = new System.Drawing.Size(126, 24);
            this.StartDateModeBox.TabIndex = 106;
            this.StartDateModeBox.TabStop = false;
            // 
            // StartDateModeLabel
            // 
            this.StartDateModeLabel.AutoSize = true;
            this.StartDateModeLabel.Location = new System.Drawing.Point(225, 394);
            this.StartDateModeLabel.Name = "StartDateModeLabel";
            this.StartDateModeLabel.Size = new System.Drawing.Size(77, 17);
            this.StartDateModeLabel.TabIndex = 105;
            this.StartDateModeLabel.Text = "DateMode:";
            // 
            // StartNeedsDateBox
            // 
            this.StartNeedsDateBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StartNeedsDateBox.FormattingEnabled = true;
            this.StartNeedsDateBox.Location = new System.Drawing.Point(128, 391);
            this.StartNeedsDateBox.Name = "StartNeedsDateBox";
            this.StartNeedsDateBox.Size = new System.Drawing.Size(62, 24);
            this.StartNeedsDateBox.TabIndex = 104;
            this.StartNeedsDateBox.TabStop = false;
            this.StartNeedsDateBox.SelectionChangeCommitted += new System.EventHandler(this.StartNeedsDateBox_SelectionChangeCommitted);
            // 
            // StartNeedsDateLabel
            // 
            this.StartNeedsDateLabel.AutoSize = true;
            this.StartNeedsDateLabel.Location = new System.Drawing.Point(39, 394);
            this.StartNeedsDateLabel.Name = "StartNeedsDateLabel";
            this.StartNeedsDateLabel.Size = new System.Drawing.Size(83, 17);
            this.StartNeedsDateLabel.TabIndex = 103;
            this.StartNeedsDateLabel.Text = "NeedsDate:";
            // 
            // StartGenderBox
            // 
            this.StartGenderBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StartGenderBox.FormattingEnabled = true;
            this.StartGenderBox.Location = new System.Drawing.Point(308, 361);
            this.StartGenderBox.Name = "StartGenderBox";
            this.StartGenderBox.Size = new System.Drawing.Size(126, 24);
            this.StartGenderBox.TabIndex = 102;
            this.StartGenderBox.TabStop = false;
            // 
            // StartGenderLabel
            // 
            this.StartGenderLabel.AutoSize = true;
            this.StartGenderLabel.Location = new System.Drawing.Point(242, 364);
            this.StartGenderLabel.Name = "StartGenderLabel";
            this.StartGenderLabel.Size = new System.Drawing.Size(60, 17);
            this.StartGenderLabel.TabIndex = 101;
            this.StartGenderLabel.Text = "Gender:";
            // 
            // StartNeedsGenderBox
            // 
            this.StartNeedsGenderBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StartNeedsGenderBox.FormattingEnabled = true;
            this.StartNeedsGenderBox.Location = new System.Drawing.Point(128, 361);
            this.StartNeedsGenderBox.Name = "StartNeedsGenderBox";
            this.StartNeedsGenderBox.Size = new System.Drawing.Size(62, 24);
            this.StartNeedsGenderBox.TabIndex = 100;
            this.StartNeedsGenderBox.TabStop = false;
            this.StartNeedsGenderBox.SelectionChangeCommitted += new System.EventHandler(this.StartNeedsGenderBox_SelectionChangeCommitted);
            // 
            // StartNeedsGenderLabel
            // 
            this.StartNeedsGenderLabel.AutoSize = true;
            this.StartNeedsGenderLabel.Location = new System.Drawing.Point(21, 364);
            this.StartNeedsGenderLabel.Name = "StartNeedsGenderLabel";
            this.StartNeedsGenderLabel.Size = new System.Drawing.Size(101, 17);
            this.StartNeedsGenderLabel.TabIndex = 99;
            this.StartNeedsGenderLabel.Text = "NeedsGender:";
            // 
            // StartClassBox
            // 
            this.StartClassBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StartClassBox.FormattingEnabled = true;
            this.StartClassBox.Location = new System.Drawing.Point(308, 331);
            this.StartClassBox.Name = "StartClassBox";
            this.StartClassBox.Size = new System.Drawing.Size(126, 24);
            this.StartClassBox.TabIndex = 67;
            this.StartClassBox.TabStop = false;
            // 
            // StartRaceBox
            // 
            this.StartRaceBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StartRaceBox.FormattingEnabled = true;
            this.StartRaceBox.Location = new System.Drawing.Point(308, 301);
            this.StartRaceBox.Name = "StartRaceBox";
            this.StartRaceBox.Size = new System.Drawing.Size(126, 24);
            this.StartRaceBox.TabIndex = 60;
            this.StartRaceBox.TabStop = false;
            // 
            // StartPreviousQuestBox
            // 
            this.StartPreviousQuestBox.HasCustomDomain = false;
            this.StartPreviousQuestBox.Location = new System.Drawing.Point(308, 271);
            this.StartPreviousQuestBox.Max = 0D;
            this.StartPreviousQuestBox.Min = 0D;
            this.StartPreviousQuestBox.Name = "StartPreviousQuestBox";
            this.StartPreviousQuestBox.NumberType = NumberBox.NumberType.USHORT;
            this.StartPreviousQuestBox.Size = new System.Drawing.Size(62, 22);
            this.StartPreviousQuestBox.TabIndex = 117;
            // 
            // StartRaceLabel
            // 
            this.StartRaceLabel.AutoSize = true;
            this.StartRaceLabel.Location = new System.Drawing.Point(257, 304);
            this.StartRaceLabel.Name = "StartRaceLabel";
            this.StartRaceLabel.Size = new System.Drawing.Size(45, 17);
            this.StartRaceLabel.TabIndex = 66;
            this.StartRaceLabel.Text = "Race:";
            // 
            // StartPreviousQuestLabel
            // 
            this.StartPreviousQuestLabel.AutoSize = true;
            this.StartPreviousQuestLabel.Location = new System.Drawing.Point(239, 274);
            this.StartPreviousQuestLabel.Name = "StartPreviousQuestLabel";
            this.StartPreviousQuestLabel.Size = new System.Drawing.Size(63, 17);
            this.StartPreviousQuestLabel.TabIndex = 97;
            this.StartPreviousQuestLabel.Text = "QuestID:";
            // 
            // StartNeedsRaceBox
            // 
            this.StartNeedsRaceBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StartNeedsRaceBox.FormattingEnabled = true;
            this.StartNeedsRaceBox.Location = new System.Drawing.Point(128, 301);
            this.StartNeedsRaceBox.Name = "StartNeedsRaceBox";
            this.StartNeedsRaceBox.Size = new System.Drawing.Size(62, 24);
            this.StartNeedsRaceBox.TabIndex = 65;
            this.StartNeedsRaceBox.TabStop = false;
            this.StartNeedsRaceBox.SelectionChangeCommitted += new System.EventHandler(this.StartNeedsRaceBox_SelectionChangeCommitted);
            // 
            // StartNeedsRaceLabel
            // 
            this.StartNeedsRaceLabel.AutoSize = true;
            this.StartNeedsRaceLabel.Location = new System.Drawing.Point(36, 304);
            this.StartNeedsRaceLabel.Name = "StartNeedsRaceLabel";
            this.StartNeedsRaceLabel.Size = new System.Drawing.Size(86, 17);
            this.StartNeedsRaceLabel.TabIndex = 64;
            this.StartNeedsRaceLabel.Text = "NeedsRace:";
            // 
            // StartNeedsQuestBox
            // 
            this.StartNeedsQuestBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StartNeedsQuestBox.FormattingEnabled = true;
            this.StartNeedsQuestBox.Location = new System.Drawing.Point(128, 271);
            this.StartNeedsQuestBox.Name = "StartNeedsQuestBox";
            this.StartNeedsQuestBox.Size = new System.Drawing.Size(62, 24);
            this.StartNeedsQuestBox.TabIndex = 95;
            this.StartNeedsQuestBox.TabStop = false;
            this.StartNeedsQuestBox.SelectionChangeCommitted += new System.EventHandler(this.StartNeedsQuestBox_SelectionChangeCommitted);
            // 
            // StartClassLabel
            // 
            this.StartClassLabel.AutoSize = true;
            this.StartClassLabel.Location = new System.Drawing.Point(256, 334);
            this.StartClassLabel.Name = "StartClassLabel";
            this.StartClassLabel.Size = new System.Drawing.Size(46, 17);
            this.StartClassLabel.TabIndex = 63;
            this.StartClassLabel.Text = "Class:";
            // 
            // StartNeedsQuestLabel
            // 
            this.StartNeedsQuestLabel.AutoSize = true;
            this.StartNeedsQuestLabel.Location = new System.Drawing.Point(31, 275);
            this.StartNeedsQuestLabel.Name = "StartNeedsQuestLabel";
            this.StartNeedsQuestLabel.Size = new System.Drawing.Size(91, 17);
            this.StartNeedsQuestLabel.TabIndex = 94;
            this.StartNeedsQuestLabel.Text = "NeedsQuest:";
            // 
            // StartNeedsClassBox
            // 
            this.StartNeedsClassBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StartNeedsClassBox.FormattingEnabled = true;
            this.StartNeedsClassBox.Location = new System.Drawing.Point(128, 331);
            this.StartNeedsClassBox.Name = "StartNeedsClassBox";
            this.StartNeedsClassBox.Size = new System.Drawing.Size(62, 24);
            this.StartNeedsClassBox.TabIndex = 62;
            this.StartNeedsClassBox.TabStop = false;
            this.StartNeedsClassBox.SelectionChangeCommitted += new System.EventHandler(this.StartNeedsClassBox_SelectionChangeCommitted);
            // 
            // StartLocationBox
            // 
            this.StartLocationBox.HasCustomDomain = false;
            this.StartLocationBox.Location = new System.Drawing.Point(308, 187);
            this.StartLocationBox.Max = 0D;
            this.StartLocationBox.Min = 0D;
            this.StartLocationBox.Multiline = true;
            this.StartLocationBox.Name = "StartLocationBox";
            this.StartLocationBox.NumberType = NumberBox.NumberType.USHORT;
            this.StartLocationBox.Size = new System.Drawing.Size(62, 22);
            this.StartLocationBox.TabIndex = 112;
            // 
            // StartNeedsClassLabel
            // 
            this.StartNeedsClassLabel.AutoSize = true;
            this.StartNeedsClassLabel.Location = new System.Drawing.Point(35, 334);
            this.StartNeedsClassLabel.Name = "StartNeedsClassLabel";
            this.StartNeedsClassLabel.Size = new System.Drawing.Size(87, 17);
            this.StartNeedsClassLabel.TabIndex = 61;
            this.StartNeedsClassLabel.Text = "NeedsClass:";
            // 
            // StartLocationLabel
            // 
            this.StartLocationLabel.AutoSize = true;
            this.StartLocationLabel.Location = new System.Drawing.Point(240, 190);
            this.StartLocationLabel.Name = "StartLocationLabel";
            this.StartLocationLabel.Size = new System.Drawing.Size(66, 17);
            this.StartLocationLabel.TabIndex = 93;
            this.StartLocationLabel.Text = "Location:";
            // 
            // StartUnkBox
            // 
            this.StartUnkBox.HasCustomDomain = false;
            this.StartUnkBox.Location = new System.Drawing.Point(418, 243);
            this.StartUnkBox.Max = 0D;
            this.StartUnkBox.Min = 0D;
            this.StartUnkBox.Multiline = true;
            this.StartUnkBox.Name = "StartUnkBox";
            this.StartUnkBox.NumberType = NumberBox.NumberType.INT;
            this.StartUnkBox.Size = new System.Drawing.Size(62, 22);
            this.StartUnkBox.TabIndex = 116;
            // 
            // StartUnkLabel
            // 
            this.StartUnkLabel.AutoSize = true;
            this.StartUnkLabel.Location = new System.Drawing.Point(380, 246);
            this.StartUnkLabel.Name = "StartUnkLabel";
            this.StartUnkLabel.Size = new System.Drawing.Size(37, 17);
            this.StartUnkLabel.TabIndex = 91;
            this.StartUnkLabel.Text = "Unk:";
            // 
            // StartRangeBox
            // 
            this.StartRangeBox.HasCustomDomain = false;
            this.StartRangeBox.Location = new System.Drawing.Point(308, 243);
            this.StartRangeBox.Max = 0D;
            this.StartRangeBox.Min = 0D;
            this.StartRangeBox.Multiline = true;
            this.StartRangeBox.Name = "StartRangeBox";
            this.StartRangeBox.NumberType = NumberBox.NumberType.UINT;
            this.StartRangeBox.Size = new System.Drawing.Size(62, 22);
            this.StartRangeBox.TabIndex = 115;
            // 
            // StartRangeLabel
            // 
            this.StartRangeLabel.AutoSize = true;
            this.StartRangeLabel.Location = new System.Drawing.Point(251, 246);
            this.StartRangeLabel.Name = "StartRangeLabel";
            this.StartRangeLabel.Size = new System.Drawing.Size(54, 17);
            this.StartRangeLabel.TabIndex = 89;
            this.StartRangeLabel.Text = "Range:";
            // 
            // StartYBox
            // 
            this.StartYBox.HasCustomDomain = false;
            this.StartYBox.Location = new System.Drawing.Point(418, 215);
            this.StartYBox.Max = 0D;
            this.StartYBox.Min = 0D;
            this.StartYBox.Multiline = true;
            this.StartYBox.Name = "StartYBox";
            this.StartYBox.NumberType = NumberBox.NumberType.UINT;
            this.StartYBox.Size = new System.Drawing.Size(62, 22);
            this.StartYBox.TabIndex = 114;
            // 
            // StartYLabel
            // 
            this.StartYLabel.AutoSize = true;
            this.StartYLabel.Location = new System.Drawing.Point(397, 218);
            this.StartYLabel.Name = "StartYLabel";
            this.StartYLabel.Size = new System.Drawing.Size(21, 17);
            this.StartYLabel.TabIndex = 87;
            this.StartYLabel.Text = "Y:";
            // 
            // StartXBox
            // 
            this.StartXBox.HasCustomDomain = false;
            this.StartXBox.Location = new System.Drawing.Point(308, 215);
            this.StartXBox.Max = 0D;
            this.StartXBox.Min = 0D;
            this.StartXBox.Multiline = true;
            this.StartXBox.Name = "StartXBox";
            this.StartXBox.NumberType = NumberBox.NumberType.UINT;
            this.StartXBox.Size = new System.Drawing.Size(62, 22);
            this.StartXBox.TabIndex = 113;
            // 
            // StartXLabel
            // 
            this.StartXLabel.AutoSize = true;
            this.StartXLabel.Location = new System.Drawing.Point(285, 218);
            this.StartXLabel.Name = "StartXLabel";
            this.StartXLabel.Size = new System.Drawing.Size(21, 17);
            this.StartXLabel.TabIndex = 85;
            this.StartXLabel.Text = "X:";
            // 
            // StartNeedsLocationBox
            // 
            this.StartNeedsLocationBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StartNeedsLocationBox.FormattingEnabled = true;
            this.StartNeedsLocationBox.Location = new System.Drawing.Point(128, 185);
            this.StartNeedsLocationBox.Name = "StartNeedsLocationBox";
            this.StartNeedsLocationBox.Size = new System.Drawing.Size(62, 24);
            this.StartNeedsLocationBox.TabIndex = 83;
            this.StartNeedsLocationBox.TabStop = false;
            this.StartNeedsLocationBox.SelectionChangeCommitted += new System.EventHandler(this.StartNeedsLocationBox_SelectionChangeCommitted);
            // 
            // StartNeedsLocationLabel
            // 
            this.StartNeedsLocationLabel.AutoSize = true;
            this.StartNeedsLocationLabel.Location = new System.Drawing.Point(15, 188);
            this.StartNeedsLocationLabel.Name = "StartNeedsLocationLabel";
            this.StartNeedsLocationLabel.Size = new System.Drawing.Size(107, 17);
            this.StartNeedsLocationLabel.TabIndex = 82;
            this.StartNeedsLocationLabel.Text = "NeedsLocation:";
            // 
            // StartItemIDLabel
            // 
            this.StartItemIDLabel.AutoSize = true;
            this.StartItemIDLabel.Location = new System.Drawing.Point(280, 163);
            this.StartItemIDLabel.Name = "StartItemIDLabel";
            this.StartItemIDLabel.Size = new System.Drawing.Size(25, 17);
            this.StartItemIDLabel.TabIndex = 80;
            this.StartItemIDLabel.Text = "ID:";
            // 
            // StartItemLotLabel
            // 
            this.StartItemLotLabel.AutoSize = true;
            this.StartItemLotLabel.Location = new System.Drawing.Point(385, 163);
            this.StartItemLotLabel.Name = "StartItemLotLabel";
            this.StartItemLotLabel.Size = new System.Drawing.Size(32, 17);
            this.StartItemLotLabel.TabIndex = 78;
            this.StartItemLotLabel.Text = "Lot:";
            // 
            // StartItemLotBox
            // 
            this.StartItemLotBox.HasCustomDomain = false;
            this.StartItemLotBox.Location = new System.Drawing.Point(418, 160);
            this.StartItemLotBox.Max = 0D;
            this.StartItemLotBox.Min = 0D;
            this.StartItemLotBox.Name = "StartItemLotBox";
            this.StartItemLotBox.NumberType = NumberBox.NumberType.USHORT;
            this.StartItemLotBox.Size = new System.Drawing.Size(62, 22);
            this.StartItemLotBox.TabIndex = 111;
            // 
            // StartNeedsItemBox
            // 
            this.StartNeedsItemBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StartNeedsItemBox.FormattingEnabled = true;
            this.StartNeedsItemBox.Location = new System.Drawing.Point(128, 155);
            this.StartNeedsItemBox.Name = "StartNeedsItemBox";
            this.StartNeedsItemBox.Size = new System.Drawing.Size(62, 24);
            this.StartNeedsItemBox.TabIndex = 75;
            this.StartNeedsItemBox.TabStop = false;
            this.StartNeedsItemBox.SelectionChangeCommitted += new System.EventHandler(this.StartNeedsItemBox_SelectionChangeCommitted);
            // 
            // StartNeedsItemLabel
            // 
            this.StartNeedsItemLabel.AutoSize = true;
            this.StartNeedsItemLabel.Location = new System.Drawing.Point(43, 158);
            this.StartNeedsItemLabel.Name = "StartNeedsItemLabel";
            this.StartNeedsItemLabel.Size = new System.Drawing.Size(79, 17);
            this.StartNeedsItemLabel.TabIndex = 74;
            this.StartNeedsItemLabel.Text = "NeedsItem:";
            // 
            // StartNPCIDLabel
            // 
            this.StartNPCIDLabel.AutoSize = true;
            this.StartNPCIDLabel.Location = new System.Drawing.Point(280, 132);
            this.StartNPCIDLabel.Name = "StartNPCIDLabel";
            this.StartNPCIDLabel.Size = new System.Drawing.Size(25, 17);
            this.StartNPCIDLabel.TabIndex = 71;
            this.StartNPCIDLabel.Text = "ID:";
            // 
            // StartNeedsNPCBox
            // 
            this.StartNeedsNPCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StartNeedsNPCBox.FormattingEnabled = true;
            this.StartNeedsNPCBox.Location = new System.Drawing.Point(128, 125);
            this.StartNeedsNPCBox.Name = "StartNeedsNPCBox";
            this.StartNeedsNPCBox.Size = new System.Drawing.Size(62, 24);
            this.StartNeedsNPCBox.TabIndex = 69;
            this.StartNeedsNPCBox.TabStop = false;
            this.StartNeedsNPCBox.SelectionChangeCommitted += new System.EventHandler(this.StartNeedsNPCBox_SelectionChangeCommitted);
            // 
            // StartNeedsNPCLabel
            // 
            this.StartNeedsNPCLabel.AutoSize = true;
            this.StartNeedsNPCLabel.Location = new System.Drawing.Point(41, 128);
            this.StartNeedsNPCLabel.Name = "StartNeedsNPCLabel";
            this.StartNeedsNPCLabel.Size = new System.Drawing.Size(81, 17);
            this.StartNeedsNPCLabel.TabIndex = 68;
            this.StartNeedsNPCLabel.Text = "NeedsNPC:";
            // 
            // StartMaxLevelLabel
            // 
            this.StartMaxLevelLabel.AutoSize = true;
            this.StartMaxLevelLabel.Location = new System.Drawing.Point(380, 102);
            this.StartMaxLevelLabel.Name = "StartMaxLevelLabel";
            this.StartMaxLevelLabel.Size = new System.Drawing.Size(37, 17);
            this.StartMaxLevelLabel.TabIndex = 67;
            this.StartMaxLevelLabel.Text = "Max:";
            // 
            // StartIsWaitListProgressBox
            // 
            this.StartIsWaitListProgressBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StartIsWaitListProgressBox.FormattingEnabled = true;
            this.StartIsWaitListProgressBox.Location = new System.Drawing.Point(418, 64);
            this.StartIsWaitListProgressBox.Name = "StartIsWaitListProgressBox";
            this.StartIsWaitListProgressBox.Size = new System.Drawing.Size(62, 24);
            this.StartIsWaitListProgressBox.TabIndex = 65;
            this.StartIsWaitListProgressBox.TabStop = false;
            // 
            // StartMinLevelLabel
            // 
            this.StartMinLevelLabel.AutoSize = true;
            this.StartMinLevelLabel.Location = new System.Drawing.Point(272, 102);
            this.StartMinLevelLabel.Name = "StartMinLevelLabel";
            this.StartMinLevelLabel.Size = new System.Drawing.Size(34, 17);
            this.StartMinLevelLabel.TabIndex = 34;
            this.StartMinLevelLabel.Text = "Min:";
            // 
            // StartIsInstantAcceptBox
            // 
            this.StartIsInstantAcceptBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StartIsInstantAcceptBox.FormattingEnabled = true;
            this.StartIsInstantAcceptBox.Location = new System.Drawing.Point(128, 35);
            this.StartIsInstantAcceptBox.Name = "StartIsInstantAcceptBox";
            this.StartIsInstantAcceptBox.Size = new System.Drawing.Size(62, 24);
            this.StartIsInstantAcceptBox.TabIndex = 61;
            this.StartIsInstantAcceptBox.TabStop = false;
            // 
            // StartNeedsLevelBox
            // 
            this.StartNeedsLevelBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StartNeedsLevelBox.FormattingEnabled = true;
            this.StartNeedsLevelBox.Location = new System.Drawing.Point(128, 94);
            this.StartNeedsLevelBox.Name = "StartNeedsLevelBox";
            this.StartNeedsLevelBox.Size = new System.Drawing.Size(62, 24);
            this.StartNeedsLevelBox.TabIndex = 33;
            this.StartNeedsLevelBox.TabStop = false;
            this.StartNeedsLevelBox.SelectionChangeCommitted += new System.EventHandler(this.StartNeedsLevelBox_SelectionChangeCommitted);
            // 
            // StartNeedsLevelLabel
            // 
            this.StartNeedsLevelLabel.AutoSize = true;
            this.StartNeedsLevelLabel.Location = new System.Drawing.Point(36, 99);
            this.StartNeedsLevelLabel.Name = "StartNeedsLevelLabel";
            this.StartNeedsLevelLabel.Size = new System.Drawing.Size(87, 17);
            this.StartNeedsLevelLabel.TabIndex = 32;
            this.StartNeedsLevelLabel.Text = "NeedsLevel:";
            // 
            // StartIsWaitListProgressLabel
            // 
            this.StartIsWaitListProgressLabel.AutoSize = true;
            this.StartIsWaitListProgressLabel.Location = new System.Drawing.Point(283, 67);
            this.StartIsWaitListProgressLabel.Name = "StartIsWaitListProgressLabel";
            this.StartIsWaitListProgressLabel.Size = new System.Drawing.Size(129, 17);
            this.StartIsWaitListProgressLabel.TabIndex = 64;
            this.StartIsWaitListProgressLabel.Text = "IsWaitListProgress:";
            // 
            // StartIsWaitListViewLabel
            // 
            this.StartIsWaitListViewLabel.AutoSize = true;
            this.StartIsWaitListViewLabel.Location = new System.Drawing.Point(22, 68);
            this.StartIsWaitListViewLabel.Name = "StartIsWaitListViewLabel";
            this.StartIsWaitListViewLabel.Size = new System.Drawing.Size(101, 17);
            this.StartIsWaitListViewLabel.TabIndex = 62;
            this.StartIsWaitListViewLabel.Text = "IsWaitListView:";
            // 
            // StartIsWaitListViewBox
            // 
            this.StartIsWaitListViewBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StartIsWaitListViewBox.FormattingEnabled = true;
            this.StartIsWaitListViewBox.Location = new System.Drawing.Point(128, 65);
            this.StartIsWaitListViewBox.Name = "StartIsWaitListViewBox";
            this.StartIsWaitListViewBox.Size = new System.Drawing.Size(62, 24);
            this.StartIsWaitListViewBox.TabIndex = 63;
            this.StartIsWaitListViewBox.TabStop = false;
            // 
            // StartIsInstantAcceptLabel
            // 
            this.StartIsInstantAcceptLabel.AutoSize = true;
            this.StartIsInstantAcceptLabel.Location = new System.Drawing.Point(18, 38);
            this.StartIsInstantAcceptLabel.Name = "StartIsInstantAcceptLabel";
            this.StartIsInstantAcceptLabel.Size = new System.Drawing.Size(107, 17);
            this.StartIsInstantAcceptLabel.TabIndex = 60;
            this.StartIsInstantAcceptLabel.Text = "IsInstantAccept:";
            // 
            // BaseInfoTab
            // 
            this.BaseInfoTab.Controls.Add(this.BaseInfoGroupBox);
            this.BaseInfoTab.Location = new System.Drawing.Point(4, 25);
            this.BaseInfoTab.Name = "BaseInfoTab";
            this.BaseInfoTab.Padding = new System.Windows.Forms.Padding(3);
            this.BaseInfoTab.Size = new System.Drawing.Size(738, 489);
            this.BaseInfoTab.TabIndex = 0;
            this.BaseInfoTab.Text = "Base Info";
            this.BaseInfoTab.UseVisualStyleBackColor = true;
            // 
            // BaseInfoGroupBox
            // 
            this.BaseInfoGroupBox.Controls.Add(this.RegionBox);
            this.BaseInfoGroupBox.Controls.Add(this.DescriptionBox);
            this.BaseInfoGroupBox.Controls.Add(this.TitleBox);
            this.BaseInfoGroupBox.Controls.Add(this.IDBox);
            this.BaseInfoGroupBox.Controls.Add(this.IsEnabledBox);
            this.BaseInfoGroupBox.Controls.Add(this.IsEnabledLabel);
            this.BaseInfoGroupBox.Controls.Add(this.QuestTypeBox);
            this.BaseInfoGroupBox.Controls.Add(this.DailyQuestTypeLabel);
            this.BaseInfoGroupBox.Controls.Add(this.DailyQuestTypeBox);
            this.BaseInfoGroupBox.Controls.Add(this.IDLabel);
            this.BaseInfoGroupBox.Controls.Add(this.IsDailyQuestBox);
            this.BaseInfoGroupBox.Controls.Add(this.IsDailyQuestLabel);
            this.BaseInfoGroupBox.Controls.Add(this.TitleLabel);
            this.BaseInfoGroupBox.Controls.Add(this.IsRepeatableBox);
            this.BaseInfoGroupBox.Controls.Add(this.IsRepeatableLabel);
            this.BaseInfoGroupBox.Controls.Add(this.QuestTypeLabel);
            this.BaseInfoGroupBox.Controls.Add(this.DescriptionLabel);
            this.BaseInfoGroupBox.Controls.Add(this.RegionLabel);
            this.BaseInfoGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BaseInfoGroupBox.Location = new System.Drawing.Point(3, 3);
            this.BaseInfoGroupBox.Name = "BaseInfoGroupBox";
            this.BaseInfoGroupBox.Size = new System.Drawing.Size(732, 483);
            this.BaseInfoGroupBox.TabIndex = 26;
            this.BaseInfoGroupBox.TabStop = false;
            this.BaseInfoGroupBox.Text = "Base Info";
            // 
            // RegionBox
            // 
            this.RegionBox.HasCustomDomain = false;
            this.RegionBox.Location = new System.Drawing.Point(128, 185);
            this.RegionBox.Max = 0D;
            this.RegionBox.Min = 0D;
            this.RegionBox.Name = "RegionBox";
            this.RegionBox.NumberType = NumberBox.NumberType.BYTE;
            this.RegionBox.Size = new System.Drawing.Size(62, 22);
            this.RegionBox.TabIndex = 70;
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.HasCustomDomain = false;
            this.DescriptionBox.Location = new System.Drawing.Point(128, 148);
            this.DescriptionBox.Max = 0D;
            this.DescriptionBox.Min = 0D;
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.NumberType = NumberBox.NumberType.UINT;
            this.DescriptionBox.Size = new System.Drawing.Size(62, 22);
            this.DescriptionBox.TabIndex = 69;
            // 
            // TitleBox
            // 
            this.TitleBox.HasCustomDomain = false;
            this.TitleBox.Location = new System.Drawing.Point(128, 111);
            this.TitleBox.Max = 0D;
            this.TitleBox.Min = 0D;
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.NumberType = NumberBox.NumberType.UINT;
            this.TitleBox.Size = new System.Drawing.Size(62, 22);
            this.TitleBox.TabIndex = 68;
            // 
            // IDBox
            // 
            this.IDBox.HasCustomDomain = false;
            this.IDBox.Location = new System.Drawing.Point(128, 74);
            this.IDBox.Max = 0D;
            this.IDBox.Min = 0D;
            this.IDBox.Name = "IDBox";
            this.IDBox.NumberType = NumberBox.NumberType.UINT;
            this.IDBox.Size = new System.Drawing.Size(62, 22);
            this.IDBox.TabIndex = 64;
            this.IDBox.TextChanged += new System.EventHandler(this.IDBox_TextChanged);
            this.IDBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IDBox_KeyDown);
            // 
            // IsEnabledBox
            // 
            this.IsEnabledBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IsEnabledBox.FormattingEnabled = true;
            this.IsEnabledBox.Location = new System.Drawing.Point(128, 35);
            this.IsEnabledBox.Name = "IsEnabledBox";
            this.IsEnabledBox.Size = new System.Drawing.Size(62, 24);
            this.IsEnabledBox.TabIndex = 63;
            this.IsEnabledBox.TabStop = false;
            this.IsEnabledBox.SelectionChangeCommitted += new System.EventHandler(this.IsEnabledBox_SelectionChangeCommitted);
            // 
            // IsEnabledLabel
            // 
            this.IsEnabledLabel.AutoSize = true;
            this.IsEnabledLabel.Location = new System.Drawing.Point(49, 38);
            this.IsEnabledLabel.Name = "IsEnabledLabel";
            this.IsEnabledLabel.Size = new System.Drawing.Size(74, 17);
            this.IsEnabledLabel.TabIndex = 62;
            this.IsEnabledLabel.Text = "IsEnabled:";
            // 
            // QuestTypeBox
            // 
            this.QuestTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.QuestTypeBox.FormattingEnabled = true;
            this.QuestTypeBox.Location = new System.Drawing.Point(128, 222);
            this.QuestTypeBox.Name = "QuestTypeBox";
            this.QuestTypeBox.Size = new System.Drawing.Size(126, 24);
            this.QuestTypeBox.TabIndex = 11;
            this.QuestTypeBox.TabStop = false;
            // 
            // DailyQuestTypeLabel
            // 
            this.DailyQuestTypeLabel.AutoSize = true;
            this.DailyQuestTypeLabel.Location = new System.Drawing.Point(285, 307);
            this.DailyQuestTypeLabel.Name = "DailyQuestTypeLabel";
            this.DailyQuestTypeLabel.Size = new System.Drawing.Size(121, 17);
            this.DailyQuestTypeLabel.TabIndex = 25;
            this.DailyQuestTypeLabel.Text = "Daily Quest Type:";
            // 
            // DailyQuestTypeBox
            // 
            this.DailyQuestTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DailyQuestTypeBox.FormattingEnabled = true;
            this.DailyQuestTypeBox.Location = new System.Drawing.Point(412, 304);
            this.DailyQuestTypeBox.Name = "DailyQuestTypeBox";
            this.DailyQuestTypeBox.Size = new System.Drawing.Size(91, 24);
            this.DailyQuestTypeBox.TabIndex = 24;
            this.DailyQuestTypeBox.TabStop = false;
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(97, 77);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(25, 17);
            this.IDLabel.TabIndex = 1;
            this.IDLabel.Text = "ID:";
            // 
            // IsDailyQuestBox
            // 
            this.IsDailyQuestBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IsDailyQuestBox.FormattingEnabled = true;
            this.IsDailyQuestBox.Location = new System.Drawing.Point(128, 300);
            this.IsDailyQuestBox.Name = "IsDailyQuestBox";
            this.IsDailyQuestBox.Size = new System.Drawing.Size(62, 24);
            this.IsDailyQuestBox.TabIndex = 23;
            this.IsDailyQuestBox.TabStop = false;
            this.IsDailyQuestBox.SelectionChangeCommitted += new System.EventHandler(this.IsDailyQuestBox_SelectionChangeCommitted);
            // 
            // IsDailyQuestLabel
            // 
            this.IsDailyQuestLabel.AutoSize = true;
            this.IsDailyQuestLabel.Location = new System.Drawing.Point(32, 303);
            this.IsDailyQuestLabel.Name = "IsDailyQuestLabel";
            this.IsDailyQuestLabel.Size = new System.Drawing.Size(91, 17);
            this.IsDailyQuestLabel.TabIndex = 22;
            this.IsDailyQuestLabel.Text = "IsDailyQuest:";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(83, 114);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(39, 17);
            this.TitleLabel.TabIndex = 3;
            this.TitleLabel.Text = "Title:";
            // 
            // IsRepeatableBox
            // 
            this.IsRepeatableBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IsRepeatableBox.FormattingEnabled = true;
            this.IsRepeatableBox.Location = new System.Drawing.Point(128, 261);
            this.IsRepeatableBox.Name = "IsRepeatableBox";
            this.IsRepeatableBox.Size = new System.Drawing.Size(62, 24);
            this.IsRepeatableBox.TabIndex = 21;
            this.IsRepeatableBox.TabStop = false;
            // 
            // IsRepeatableLabel
            // 
            this.IsRepeatableLabel.AutoSize = true;
            this.IsRepeatableLabel.Location = new System.Drawing.Point(28, 264);
            this.IsRepeatableLabel.Name = "IsRepeatableLabel";
            this.IsRepeatableLabel.Size = new System.Drawing.Size(95, 17);
            this.IsRepeatableLabel.TabIndex = 14;
            this.IsRepeatableLabel.Text = "IsRepeatable:";
            // 
            // QuestTypeLabel
            // 
            this.QuestTypeLabel.AutoSize = true;
            this.QuestTypeLabel.Location = new System.Drawing.Point(39, 225);
            this.QuestTypeLabel.Name = "QuestTypeLabel";
            this.QuestTypeLabel.Size = new System.Drawing.Size(86, 17);
            this.QuestTypeLabel.TabIndex = 12;
            this.QuestTypeLabel.Text = "Quest Type:";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(40, 151);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(83, 17);
            this.DescriptionLabel.TabIndex = 6;
            this.DescriptionLabel.Text = "Description:";
            // 
            // RegionLabel
            // 
            this.RegionLabel.AutoSize = true;
            this.RegionLabel.Location = new System.Drawing.Point(65, 185);
            this.RegionLabel.Name = "RegionLabel";
            this.RegionLabel.Size = new System.Drawing.Size(57, 17);
            this.RegionLabel.TabIndex = 8;
            this.RegionLabel.Text = "Region:";
            // 
            // Tabs
            // 
            this.Tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tabs.Controls.Add(this.BaseInfoTab);
            this.Tabs.Controls.Add(this.StartInfoTab);
            this.Tabs.Controls.Add(this.EndInfoTab);
            this.Tabs.Controls.Add(this.StartScriptTab);
            this.Tabs.Controls.Add(this.ActiveScriptTab);
            this.Tabs.Controls.Add(this.EndScriptTab);
            this.Tabs.Controls.Add(this.MobInfoTab);
            this.Tabs.Controls.Add(this.ItemInfoTab);
            this.Tabs.Controls.Add(this.RewardInfoTab);
            this.Tabs.Location = new System.Drawing.Point(260, 58);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(746, 518);
            this.Tabs.TabIndex = 6;
            this.Tabs.TabStop = false;
            // 
            // QuestEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 606);
            this.Controls.Add(this.Credits);
            this.Controls.Add(this.Tabs);
            this.Controls.Add(this.CompareOptions);
            this.Controls.Add(this.SearchOptions);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.QuestListBox);
            this.Controls.Add(this.MenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "QuestEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fiesta Quest Editor";
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.Credits.ResumeLayout(false);
            this.Credits.PerformLayout();
            this.RewardInfoTab.ResumeLayout(false);
            this.RewardInfoTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RewardDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questRewardBindingSource)).EndInit();
            this.EndScriptTab.ResumeLayout(false);
            this.EndScriptTab.PerformLayout();
            this.ActiveScriptTab.ResumeLayout(false);
            this.ActiveScriptTab.PerformLayout();
            this.StartScriptTab.ResumeLayout(false);
            this.StartScriptTab.PerformLayout();
            this.EndInfoTab.ResumeLayout(false);
            this.EndGroupBox.ResumeLayout(false);
            this.EndGroupBox.PerformLayout();
            this.StartInfoTab.ResumeLayout(false);
            this.StartGroupBox.ResumeLayout(false);
            this.StartGroupBox.PerformLayout();
            this.BaseInfoTab.ResumeLayout(false);
            this.BaseInfoGroupBox.ResumeLayout(false);
            this.BaseInfoGroupBox.PerformLayout();
            this.Tabs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ListBox QuestListBox;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.ComboBox SearchOptions;
        private System.Windows.Forms.ComboBox CompareOptions;
		private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
		private System.Windows.Forms.StatusStrip Credits;
		private System.Windows.Forms.ToolStripMenuItem DeleteAllToolStripMenuItem;
		private System.Windows.Forms.ToolStripStatusLabel CreditsLabel;
		private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem SaveAsToolStripMenuItem;
		private System.Windows.Forms.TabPage RewardInfoTab;
		private System.Windows.Forms.TabPage ItemInfoTab;
		private System.Windows.Forms.TabPage MobInfoTab;
		private System.Windows.Forms.TabPage EndScriptTab;
		private System.Windows.Forms.TextBox EndScriptBox;
		private System.Windows.Forms.TabPage ActiveScriptTab;
		private System.Windows.Forms.TextBox ActiveScriptBox;
		private System.Windows.Forms.TabPage StartScriptTab;
		private System.Windows.Forms.TabPage EndInfoTab;
		private System.Windows.Forms.GroupBox EndGroupBox;
		private System.Windows.Forms.ComboBox EndClassBox;
		private System.Windows.Forms.ComboBox EndRaceBox;
		private NumberBox.NumberBox EndTimeLimitBox;
		private System.Windows.Forms.Label EndTimeLimitLabel;
		private System.Windows.Forms.ComboBox EndHasTimeLimitBox;
		private System.Windows.Forms.Label EndHasTimeLimitLabel;
		private System.Windows.Forms.Label EndRaceLabel;
		private System.Windows.Forms.ComboBox EndNeedsRaceBox;
		private System.Windows.Forms.Label EndNeedsRaceLabel;
		private System.Windows.Forms.Label EndClassLabel;
		private System.Windows.Forms.ComboBox EndNeedsClassBox;
		private System.Windows.Forms.Label EndNeedsClassLabel;
		private NumberBox.NumberBox EndScenarioIDBox;
		private System.Windows.Forms.Label EndScenarioIDLabel;
		private System.Windows.Forms.ComboBox EndNeedsScenarioBox;
		private System.Windows.Forms.Label EndNeedsScenarioLabel;
		private NumberBox.NumberBox EndLocationBox;
		private System.Windows.Forms.Label EndLocationLabel;
		private NumberBox.NumberBox EndUnkBox;
		private System.Windows.Forms.Label EndUnkLabel;
		private NumberBox.NumberBox EndRangeBox;
		private System.Windows.Forms.Label EndRangeLabel;
		private NumberBox.NumberBox EndYBox;
		private System.Windows.Forms.Label EndYLabel;
		private NumberBox.NumberBox EndXBox;
		private System.Windows.Forms.Label EndXLabel;
		private System.Windows.Forms.ComboBox EndNeedsLocationBox;
		private System.Windows.Forms.Label EndNeedsLocationLabel;
		private System.Windows.Forms.Label EndLevelLabel;
		private System.Windows.Forms.ComboBox EndNeedsLevelBox;
		private System.Windows.Forms.Label EndIsInstantHandInLabel;
		private System.Windows.Forms.Label EndNeedsLevelLabel;
		private System.Windows.Forms.ComboBox EndIsInstantHandInBox;
		private System.Windows.Forms.TabPage StartInfoTab;
		private System.Windows.Forms.GroupBox StartGroupBox;
		private System.Windows.Forms.ComboBox StartDateModeBox;
		private System.Windows.Forms.Label StartDateModeLabel;
		private System.Windows.Forms.ComboBox StartNeedsDateBox;
		private System.Windows.Forms.Label StartNeedsDateLabel;
		private System.Windows.Forms.ComboBox StartGenderBox;
		private System.Windows.Forms.Label StartGenderLabel;
		private System.Windows.Forms.ComboBox StartNeedsGenderBox;
		private System.Windows.Forms.Label StartNeedsGenderLabel;
		private System.Windows.Forms.ComboBox StartClassBox;
		private System.Windows.Forms.ComboBox StartRaceBox;
		private NumberBox.NumberBox StartPreviousQuestBox;
		private System.Windows.Forms.Label StartRaceLabel;
		private System.Windows.Forms.Label StartPreviousQuestLabel;
		private System.Windows.Forms.ComboBox StartNeedsRaceBox;
		private System.Windows.Forms.Label StartNeedsRaceLabel;
		private System.Windows.Forms.ComboBox StartNeedsQuestBox;
		private System.Windows.Forms.Label StartClassLabel;
		private System.Windows.Forms.Label StartNeedsQuestLabel;
		private System.Windows.Forms.ComboBox StartNeedsClassBox;
		private NumberBox.NumberBox StartLocationBox;
		private System.Windows.Forms.Label StartNeedsClassLabel;
		private System.Windows.Forms.Label StartLocationLabel;
		private NumberBox.NumberBox StartUnkBox;
		private System.Windows.Forms.Label StartUnkLabel;
		private NumberBox.NumberBox StartRangeBox;
		private System.Windows.Forms.Label StartRangeLabel;
		private NumberBox.NumberBox StartYBox;
		private System.Windows.Forms.Label StartYLabel;
		private NumberBox.NumberBox StartXBox;
		private System.Windows.Forms.Label StartXLabel;
		private System.Windows.Forms.ComboBox StartNeedsLocationBox;
		private System.Windows.Forms.Label StartNeedsLocationLabel;
		private System.Windows.Forms.Label StartItemIDLabel;
		private System.Windows.Forms.Label StartItemLotLabel;
		private NumberBox.NumberBox StartItemLotBox;
		private System.Windows.Forms.ComboBox StartNeedsItemBox;
		private System.Windows.Forms.Label StartNeedsItemLabel;
		private System.Windows.Forms.Label StartNPCIDLabel;
		private System.Windows.Forms.ComboBox StartNeedsNPCBox;
		private System.Windows.Forms.Label StartNeedsNPCLabel;
		private System.Windows.Forms.Label StartMaxLevelLabel;
		private System.Windows.Forms.ComboBox StartIsWaitListProgressBox;
		private System.Windows.Forms.Label StartMinLevelLabel;
		private System.Windows.Forms.ComboBox StartIsInstantAcceptBox;
		private System.Windows.Forms.ComboBox StartNeedsLevelBox;
		private System.Windows.Forms.Label StartNeedsLevelLabel;
		private System.Windows.Forms.Label StartIsWaitListProgressLabel;
		private System.Windows.Forms.Label StartIsWaitListViewLabel;
		private System.Windows.Forms.ComboBox StartIsWaitListViewBox;
		private System.Windows.Forms.Label StartIsInstantAcceptLabel;
		private System.Windows.Forms.TabPage BaseInfoTab;
		private System.Windows.Forms.GroupBox BaseInfoGroupBox;
		private System.Windows.Forms.ComboBox IsEnabledBox;
		private System.Windows.Forms.Label IsEnabledLabel;
		private System.Windows.Forms.ComboBox QuestTypeBox;
		private System.Windows.Forms.Label DailyQuestTypeLabel;
		private System.Windows.Forms.ComboBox DailyQuestTypeBox;
		private System.Windows.Forms.Label IDLabel;
		private System.Windows.Forms.ComboBox IsDailyQuestBox;
		private System.Windows.Forms.Label IsDailyQuestLabel;
		private System.Windows.Forms.Label TitleLabel;
		private System.Windows.Forms.ComboBox IsRepeatableBox;
		private System.Windows.Forms.Label IsRepeatableLabel;
		private System.Windows.Forms.Label QuestTypeLabel;
		private System.Windows.Forms.Label DescriptionLabel;
		private System.Windows.Forms.Label RegionLabel;
		private System.Windows.Forms.TabControl Tabs;
		private NumberBox.NumberBox EndLevelBox;
		private NumberBox.NumberBox IDBox;
		private NumberBox.NumberBox RegionBox;
		private NumberBox.NumberBox DescriptionBox;
		private NumberBox.NumberBox TitleBox;
		private NumberBox.NumberBox StartItemIDBox;
		private NumberBox.NumberBox StartNPCIDBox;
		private NumberBox.NumberBox StartMaxLevelBox;
		private NumberBox.NumberBox StartMinLevelBox;
		private System.Windows.Forms.TextBox StartScriptBox;
		private System.Windows.Forms.ToolStripMenuItem CloseToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator ToolStripSeparator;
		private NumberBox.NumberBox StartDateStartBox;
		private System.Windows.Forms.Label StartDateStartLabel;
		private NumberBox.NumberBox StartDateEndBox;
		private System.Windows.Forms.Label StartDateEndLabel;
		private System.Windows.Forms.DataGridView RewardDataGridView;
		private System.Windows.Forms.BindingSource questRewardBindingSource;
		private NumberBox.NumberBox ExpRewardBox;
		private System.Windows.Forms.Label ExpRewardLabel;
		private System.Windows.Forms.Label MoneyRewardLabel;
		private NumberBox.NumberBox MoneyRewardBox;
		private System.Windows.Forms.Label ItemLotRewardLabel;
		private NumberBox.NumberBox ItemLotRewardBox;
		private System.Windows.Forms.Label ItemIDRewardLabel;
		private NumberBox.NumberBox ItemIDRewardBox;
		private System.Windows.Forms.Label AbstateStrengthRewardLabel;
		private NumberBox.NumberBox AbstateStrengthRewardBox;
		private System.Windows.Forms.Label AbstateTimeRewardLabel;
		private NumberBox.NumberBox AbstateTimeRewardBox;
		private System.Windows.Forms.Label AbstateIDRewardLabel;
		private NumberBox.NumberBox AbstateIDRewardBox;
		private System.Windows.Forms.Label ElementNoRewardLabel;
		private NumberBox.NumberBox ElementNoRewardBox;
		private System.Windows.Forms.Label TitleTypeRewardLabel;
		private System.Windows.Forms.ComboBox TitleTypeRewardComboBox;
		private System.Windows.Forms.Label FameRewardLabel;
		private NumberBox.NumberBox FameRewardBox;
		private System.Windows.Forms.Label KillPointRewardLabel;
		private NumberBox.NumberBox KillPointRewardBox;
		private System.Windows.Forms.Label MiniHouseIDRewardLabel;
		private NumberBox.NumberBox MiniHouseIDRewardBox;
		private System.Windows.Forms.Label PetIDRewardLabel;
		private NumberBox.NumberBox PetIDRewardBox;
		private System.Windows.Forms.DataGridViewComboBoxColumn useDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewComboBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem DuplicateSelectedToolStripMenuItem;
    }
}
