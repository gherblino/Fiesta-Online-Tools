namespace DropTableEditor
{
    partial class DropTableEditor
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DropTableEditor));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuOpen = new System.Windows.Forms.ToolStripMenuItem();
			this.menuOpenFromPath = new System.Windows.Forms.ToolStripMenuItem();
			this.menuOpenFromShine = new System.Windows.Forms.ToolStripMenuItem();
			this.menuSave = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuAddGroupToAll = new System.Windows.Forms.ToolStripMenuItem();
			this.menuGroupRateEdit = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.menuRemoveAllGroups = new System.Windows.Forms.ToolStripMenuItem();
			this.creditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.groupBox8 = new System.Windows.Forms.GroupBox();
			this.label8 = new System.Windows.Forms.Label();
			this.CenRate = new System.Windows.Forms.NumericUpDown();
			this.CenRateLabel = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.MaxCen = new System.Windows.Forms.NumericUpDown();
			this.MinCen = new System.Windows.Forms.NumericUpDown();
			this.lvMobDropGroups = new System.Windows.Forms.ListView();
			this.chGroupIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chDropRate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.UpGradeMaxLabel = new System.Windows.Forms.Label();
			this.UpGradeMinLabel = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.nudGroupDropRate = new System.Windows.Forms.NumericUpDown();
			this.UpGradeMax = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.UpGradeMin = new System.Windows.Forms.NumericUpDown();
			this.txtGroupIndex = new System.Windows.Forms.TextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnRemoveGroup = new System.Windows.Forms.Button();
			this.txtAddGroup = new System.Windows.Forms.TextBox();
			this.btnAddMobDropGroup = new System.Windows.Forms.Button();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.gbGroupItem = new System.Windows.Forms.GroupBox();
			this.btnAddItem = new System.Windows.Forms.Button();
			this.btnDeleteGroup = new System.Windows.Forms.Button();
			this.btnRemoveItem = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.nudMaximum = new System.Windows.Forms.NumericUpDown();
			this.nudMinimum = new System.Windows.Forms.NumericUpDown();
			this.txtSelectedGroupName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox7 = new System.Windows.Forms.GroupBox();
			this.lbGroupItems = new System.Windows.Forms.ListBox();
			this.gbAllItems = new System.Windows.Forms.GroupBox();
			this.txtAllItemsFilter = new System.Windows.Forms.TextBox();
			this.lbAllItems = new System.Windows.Forms.ListBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtFilter = new System.Windows.Forms.TextBox();
			this.lbMobs = new System.Windows.Forms.ListBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.txtItemGroupFilter = new System.Windows.Forms.TextBox();
			this.txtNewItemGroup = new System.Windows.Forms.TextBox();
			this.btnAddItemGroup = new System.Windows.Forms.Button();
			this.lbItemGroups = new System.Windows.Forms.ListBox();
			this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.menuStrip1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox8.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.CenRate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.MaxCen)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.MinCen)).BeginInit();
			this.groupBox6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudGroupDropRate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.UpGradeMax)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.UpGradeMin)).BeginInit();
			this.groupBox4.SuspendLayout();
			this.gbGroupItem.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudMaximum)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMinimum)).BeginInit();
			this.groupBox7.SuspendLayout();
			this.gbAllItems.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.White;
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.creditsToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(1119, 28);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOpen,
            this.menuOpenFromPath,
            this.menuOpenFromShine,
            this.menuSave,
            this.toolStripMenuItem1,
            this.menuExit});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// menuOpen
			// 
			this.menuOpen.Name = "menuOpen";
			this.menuOpen.Size = new System.Drawing.Size(248, 26);
			this.menuOpen.Text = "Open..";
			this.menuOpen.Click += new System.EventHandler(this.MenuOpen_Click);
			// 
			// menuOpenFromPath
			// 
			this.menuOpenFromPath.Name = "menuOpenFromPath";
			this.menuOpenFromPath.Size = new System.Drawing.Size(248, 26);
			this.menuOpenFromPath.Text = "Open From Current Path..";
			this.menuOpenFromPath.Click += new System.EventHandler(this.menuOpenFromPath_Click);
			// 
			// menuOpenFromShine
			// 
			this.menuOpenFromShine.Name = "menuOpenFromShine";
			this.menuOpenFromShine.Size = new System.Drawing.Size(248, 26);
			this.menuOpenFromShine.Text = "Open From Shine..";
			this.menuOpenFromShine.Click += new System.EventHandler(this.MenuOpenFromShine_Click);
			// 
			// menuSave
			// 
			this.menuSave.Name = "menuSave";
			this.menuSave.Size = new System.Drawing.Size(248, 26);
			this.menuSave.Text = "Save..";
			this.menuSave.Click += new System.EventHandler(this.MenuSave_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(245, 6);
			// 
			// menuExit
			// 
			this.menuExit.Name = "menuExit";
			this.menuExit.Size = new System.Drawing.Size(248, 26);
			this.menuExit.Text = "Exit";
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAddGroupToAll,
            this.menuGroupRateEdit,
            this.toolStripMenuItem2,
            this.menuRemoveAllGroups});
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
			this.editToolStripMenuItem.Text = "Edit";
			// 
			// menuAddGroupToAll
			// 
			this.menuAddGroupToAll.Name = "menuAddGroupToAll";
			this.menuAddGroupToAll.Size = new System.Drawing.Size(249, 26);
			this.menuAddGroupToAll.Text = "Add Group To All Mobs...";
			this.menuAddGroupToAll.Click += new System.EventHandler(this.MenuAddGroupToAll_Click);
			// 
			// menuGroupRateEdit
			// 
			this.menuGroupRateEdit.Name = "menuGroupRateEdit";
			this.menuGroupRateEdit.Size = new System.Drawing.Size(249, 26);
			this.menuGroupRateEdit.Text = "Mass Edit Group Rate...";
			this.menuGroupRateEdit.Click += new System.EventHandler(this.MenuGroupRateEdit_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(246, 6);
			// 
			// menuRemoveAllGroups
			// 
			this.menuRemoveAllGroups.Name = "menuRemoveAllGroups";
			this.menuRemoveAllGroups.Size = new System.Drawing.Size(249, 26);
			this.menuRemoveAllGroups.Text = "Remove All Groups";
			this.menuRemoveAllGroups.Click += new System.EventHandler(this.MenuRemoveAllGroups_Click);
			// 
			// creditsToolStripMenuItem
			// 
			this.creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
			this.creditsToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
			this.creditsToolStripMenuItem.Text = "Credits";
			this.creditsToolStripMenuItem.Click += new System.EventHandler(this.CreditsToolStripMenuItem_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.groupBox5);
			this.groupBox1.Controls.Add(this.groupBox4);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
			this.groupBox1.Location = new System.Drawing.Point(288, 28);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox1.Size = new System.Drawing.Size(831, 626);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.groupBox8);
			this.groupBox5.Controls.Add(this.lvMobDropGroups);
			this.groupBox5.Controls.Add(this.groupBox6);
			this.groupBox5.Controls.Add(this.txtAddGroup);
			this.groupBox5.Controls.Add(this.btnAddMobDropGroup);
			this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox5.Location = new System.Drawing.Point(4, 19);
			this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox5.Size = new System.Drawing.Size(823, 347);
			this.groupBox5.TabIndex = 3;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Mob Drop Groups";
			// 
			// groupBox8
			// 
			this.groupBox8.Controls.Add(this.label8);
			this.groupBox8.Controls.Add(this.CenRate);
			this.groupBox8.Controls.Add(this.CenRateLabel);
			this.groupBox8.Controls.Add(this.label9);
			this.groupBox8.Controls.Add(this.label10);
			this.groupBox8.Controls.Add(this.MaxCen);
			this.groupBox8.Controls.Add(this.MinCen);
			this.groupBox8.Location = new System.Drawing.Point(540, 49);
			this.groupBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox8.Name = "groupBox8";
			this.groupBox8.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox8.Size = new System.Drawing.Size(279, 85);
			this.groupBox8.TabIndex = 15;
			this.groupBox8.TabStop = false;
			this.groupBox8.Text = "Cen Info";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(256, 50);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(20, 17);
			this.label8.TabIndex = 29;
			this.label8.Text = "%";
			// 
			// CenRate
			// 
			this.CenRate.DecimalPlaces = 2;
			this.CenRate.Location = new System.Drawing.Point(184, 48);
			this.CenRate.Margin = new System.Windows.Forms.Padding(4);
			this.CenRate.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.CenRate.Name = "CenRate";
			this.CenRate.Size = new System.Drawing.Size(68, 22);
			this.CenRate.TabIndex = 28;
			this.CenRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.CenRate.ValueChanged += new System.EventHandler(this.CenRate_ValueChanged);
			// 
			// CenRateLabel
			// 
			this.CenRateLabel.Location = new System.Drawing.Point(180, 23);
			this.CenRateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.CenRateLabel.Name = "CenRateLabel";
			this.CenRateLabel.Size = new System.Drawing.Size(75, 21);
			this.CenRateLabel.TabIndex = 27;
			this.CenRateLabel.Text = "Cen Rate";
			this.CenRateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(93, 23);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(85, 21);
			this.label9.TabIndex = 25;
			this.label9.Text = "Max Cen";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(11, 23);
			this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(79, 21);
			this.label10.TabIndex = 24;
			this.label10.Text = "Min Cen";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MaxCen
			// 
			this.MaxCen.Location = new System.Drawing.Point(97, 48);
			this.MaxCen.Margin = new System.Windows.Forms.Padding(4);
			this.MaxCen.Maximum = new decimal(new int[] {
            200000000,
            0,
            0,
            0});
			this.MaxCen.Name = "MaxCen";
			this.MaxCen.Size = new System.Drawing.Size(81, 22);
			this.MaxCen.TabIndex = 23;
			this.MaxCen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.MaxCen.ValueChanged += new System.EventHandler(this.MaxCen_ValueChanged);
			// 
			// MinCen
			// 
			this.MinCen.Location = new System.Drawing.Point(8, 48);
			this.MinCen.Margin = new System.Windows.Forms.Padding(4);
			this.MinCen.Maximum = new decimal(new int[] {
            200000000,
            0,
            0,
            0});
			this.MinCen.Name = "MinCen";
			this.MinCen.Size = new System.Drawing.Size(81, 22);
			this.MinCen.TabIndex = 22;
			this.MinCen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.MinCen.ValueChanged += new System.EventHandler(this.MinCen_ValueChanged);
			// 
			// lvMobDropGroups
			// 
			this.lvMobDropGroups.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chGroupIndex,
            this.chDropRate});
			this.lvMobDropGroups.Dock = System.Windows.Forms.DockStyle.Left;
			this.lvMobDropGroups.FullRowSelect = true;
			this.lvMobDropGroups.GridLines = true;
			this.lvMobDropGroups.HideSelection = false;
			this.lvMobDropGroups.Location = new System.Drawing.Point(4, 19);
			this.lvMobDropGroups.Margin = new System.Windows.Forms.Padding(4);
			this.lvMobDropGroups.MultiSelect = false;
			this.lvMobDropGroups.Name = "lvMobDropGroups";
			this.lvMobDropGroups.Size = new System.Drawing.Size(527, 324);
			this.lvMobDropGroups.TabIndex = 14;
			this.lvMobDropGroups.UseCompatibleStateImageBehavior = false;
			this.lvMobDropGroups.View = System.Windows.Forms.View.Details;
			this.lvMobDropGroups.SelectedIndexChanged += new System.EventHandler(this.LvMobDropGroups_SelectedIndexChanged);
			// 
			// chGroupIndex
			// 
			this.chGroupIndex.Text = "Index";
			this.chGroupIndex.Width = 112;
			// 
			// chDropRate
			// 
			this.chDropRate.Text = "Drop Rate";
			this.chDropRate.Width = 92;
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.UpGradeMaxLabel);
			this.groupBox6.Controls.Add(this.UpGradeMinLabel);
			this.groupBox6.Controls.Add(this.label5);
			this.groupBox6.Controls.Add(this.nudGroupDropRate);
			this.groupBox6.Controls.Add(this.UpGradeMax);
			this.groupBox6.Controls.Add(this.label4);
			this.groupBox6.Controls.Add(this.label3);
			this.groupBox6.Controls.Add(this.UpGradeMin);
			this.groupBox6.Controls.Add(this.txtGroupIndex);
			this.groupBox6.Controls.Add(this.btnSave);
			this.groupBox6.Controls.Add(this.btnRemoveGroup);
			this.groupBox6.Location = new System.Drawing.Point(540, 140);
			this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox6.Size = new System.Drawing.Size(283, 196);
			this.groupBox6.TabIndex = 13;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Group Info";
			// 
			// UpGradeMaxLabel
			// 
			this.UpGradeMaxLabel.Location = new System.Drawing.Point(204, 73);
			this.UpGradeMaxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.UpGradeMaxLabel.Name = "UpGradeMaxLabel";
			this.UpGradeMaxLabel.Size = new System.Drawing.Size(65, 21);
			this.UpGradeMaxLabel.TabIndex = 21;
			this.UpGradeMaxLabel.Text = "UpMax";
			this.UpGradeMaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// UpGradeMinLabel
			// 
			this.UpGradeMinLabel.Location = new System.Drawing.Point(128, 73);
			this.UpGradeMinLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.UpGradeMinLabel.Name = "UpGradeMinLabel";
			this.UpGradeMinLabel.Size = new System.Drawing.Size(64, 21);
			this.UpGradeMinLabel.TabIndex = 20;
			this.UpGradeMinLabel.Text = "UpMin";
			this.UpGradeMinLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(104, 97);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(20, 17);
			this.label5.TabIndex = 15;
			this.label5.Text = "%";
			// 
			// nudGroupDropRate
			// 
			this.nudGroupDropRate.DecimalPlaces = 5;
			this.nudGroupDropRate.Location = new System.Drawing.Point(8, 96);
			this.nudGroupDropRate.Margin = new System.Windows.Forms.Padding(4);
			this.nudGroupDropRate.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.nudGroupDropRate.Name = "nudGroupDropRate";
			this.nudGroupDropRate.Size = new System.Drawing.Size(93, 22);
			this.nudGroupDropRate.TabIndex = 14;
			this.nudGroupDropRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// UpGradeMax
			// 
			this.UpGradeMax.Location = new System.Drawing.Point(208, 95);
			this.UpGradeMax.Margin = new System.Windows.Forms.Padding(4);
			this.UpGradeMax.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
			this.UpGradeMax.Name = "UpGradeMax";
			this.UpGradeMax.Size = new System.Drawing.Size(61, 22);
			this.UpGradeMax.TabIndex = 19;
			this.UpGradeMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.UpGradeMax.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(11, 73);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(91, 21);
			this.label4.TabIndex = 13;
			this.label4.Text = "Drop Rate";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 18);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(271, 21);
			this.label3.TabIndex = 3;
			this.label3.Text = "Index";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// UpGradeMin
			// 
			this.UpGradeMin.Location = new System.Drawing.Point(132, 95);
			this.UpGradeMin.Margin = new System.Windows.Forms.Padding(4);
			this.UpGradeMin.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
			this.UpGradeMin.Name = "UpGradeMin";
			this.UpGradeMin.Size = new System.Drawing.Size(60, 22);
			this.UpGradeMin.TabIndex = 18;
			this.UpGradeMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.UpGradeMin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// txtGroupIndex
			// 
			this.txtGroupIndex.Location = new System.Drawing.Point(8, 44);
			this.txtGroupIndex.Margin = new System.Windows.Forms.Padding(4);
			this.txtGroupIndex.Name = "txtGroupIndex";
			this.txtGroupIndex.ReadOnly = true;
			this.txtGroupIndex.Size = new System.Drawing.Size(271, 22);
			this.txtGroupIndex.TabIndex = 2;
			this.txtGroupIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(7, 128);
			this.btnSave.Margin = new System.Windows.Forms.Padding(4);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(272, 28);
			this.btnSave.TabIndex = 12;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
			// 
			// btnRemoveGroup
			// 
			this.btnRemoveGroup.Location = new System.Drawing.Point(7, 164);
			this.btnRemoveGroup.Margin = new System.Windows.Forms.Padding(4);
			this.btnRemoveGroup.Name = "btnRemoveGroup";
			this.btnRemoveGroup.Size = new System.Drawing.Size(272, 28);
			this.btnRemoveGroup.TabIndex = 12;
			this.btnRemoveGroup.Text = "Remove";
			this.btnRemoveGroup.UseVisualStyleBackColor = true;
			this.btnRemoveGroup.Click += new System.EventHandler(this.BtnRemoveGroup_Click);
			// 
			// txtAddGroup
			// 
			this.txtAddGroup.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.txtAddGroup.Location = new System.Drawing.Point(540, 20);
			this.txtAddGroup.Margin = new System.Windows.Forms.Padding(4);
			this.txtAddGroup.Name = "txtAddGroup";
			this.txtAddGroup.Size = new System.Drawing.Size(239, 22);
			this.txtAddGroup.TabIndex = 11;
			this.txtAddGroup.Text = "Add Group";
			this.txtAddGroup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btnAddMobDropGroup
			// 
			this.btnAddMobDropGroup.Location = new System.Drawing.Point(783, 18);
			this.btnAddMobDropGroup.Margin = new System.Windows.Forms.Padding(4);
			this.btnAddMobDropGroup.Name = "btnAddMobDropGroup";
			this.btnAddMobDropGroup.Size = new System.Drawing.Size(36, 26);
			this.btnAddMobDropGroup.TabIndex = 1;
			this.btnAddMobDropGroup.Text = "+";
			this.btnAddMobDropGroup.UseVisualStyleBackColor = true;
			this.btnAddMobDropGroup.Click += new System.EventHandler(this.BtnAddMobDropGroup_Click);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.gbGroupItem);
			this.groupBox4.Controls.Add(this.groupBox7);
			this.groupBox4.Controls.Add(this.gbAllItems);
			this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.groupBox4.Location = new System.Drawing.Point(4, 366);
			this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox4.Size = new System.Drawing.Size(823, 256);
			this.groupBox4.TabIndex = 1;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Group Editor";
			// 
			// gbGroupItem
			// 
			this.gbGroupItem.Controls.Add(this.btnAddItem);
			this.gbGroupItem.Controls.Add(this.btnDeleteGroup);
			this.gbGroupItem.Controls.Add(this.btnRemoveItem);
			this.gbGroupItem.Controls.Add(this.label1);
			this.gbGroupItem.Controls.Add(this.label6);
			this.gbGroupItem.Controls.Add(this.nudMaximum);
			this.gbGroupItem.Controls.Add(this.nudMinimum);
			this.gbGroupItem.Controls.Add(this.txtSelectedGroupName);
			this.gbGroupItem.Controls.Add(this.label2);
			this.gbGroupItem.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gbGroupItem.Location = new System.Drawing.Point(309, 19);
			this.gbGroupItem.Margin = new System.Windows.Forms.Padding(4);
			this.gbGroupItem.Name = "gbGroupItem";
			this.gbGroupItem.Padding = new System.Windows.Forms.Padding(4);
			this.gbGroupItem.Size = new System.Drawing.Size(223, 233);
			this.gbGroupItem.TabIndex = 4;
			this.gbGroupItem.TabStop = false;
			this.gbGroupItem.Text = "Edit";
			// 
			// btnAddItem
			// 
			this.btnAddItem.Location = new System.Drawing.Point(115, 167);
			this.btnAddItem.Margin = new System.Windows.Forms.Padding(4);
			this.btnAddItem.Name = "btnAddItem";
			this.btnAddItem.Size = new System.Drawing.Size(95, 28);
			this.btnAddItem.TabIndex = 13;
			this.btnAddItem.Text = "Add";
			this.btnAddItem.UseVisualStyleBackColor = true;
			this.btnAddItem.Click += new System.EventHandler(this.BtnAddItem_Click);
			// 
			// btnDeleteGroup
			// 
			this.btnDeleteGroup.Location = new System.Drawing.Point(49, 123);
			this.btnDeleteGroup.Margin = new System.Windows.Forms.Padding(4);
			this.btnDeleteGroup.Name = "btnDeleteGroup";
			this.btnDeleteGroup.Size = new System.Drawing.Size(125, 28);
			this.btnDeleteGroup.TabIndex = 12;
			this.btnDeleteGroup.Text = "Delete Group";
			this.btnDeleteGroup.UseVisualStyleBackColor = true;
			this.btnDeleteGroup.Click += new System.EventHandler(this.BtnDeleteGroup_Click);
			// 
			// btnRemoveItem
			// 
			this.btnRemoveItem.Location = new System.Drawing.Point(19, 167);
			this.btnRemoveItem.Margin = new System.Windows.Forms.Padding(4);
			this.btnRemoveItem.Name = "btnRemoveItem";
			this.btnRemoveItem.Size = new System.Drawing.Size(95, 28);
			this.btnRemoveItem.TabIndex = 12;
			this.btnRemoveItem.Text = "Remove";
			this.btnRemoveItem.UseVisualStyleBackColor = true;
			this.btnRemoveItem.Click += new System.EventHandler(this.BtnRemoveItem_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(13, 69);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(97, 21);
			this.label1.TabIndex = 15;
			this.label1.Text = "Min.";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(19, 18);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(187, 21);
			this.label6.TabIndex = 13;
			this.label6.Text = "Group Name";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// nudMaximum
			// 
			this.nudMaximum.Location = new System.Drawing.Point(116, 91);
			this.nudMaximum.Margin = new System.Windows.Forms.Padding(4);
			this.nudMaximum.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			this.nudMaximum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudMaximum.Name = "nudMaximum";
			this.nudMaximum.Size = new System.Drawing.Size(93, 22);
			this.nudMaximum.TabIndex = 16;
			this.nudMaximum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.nudMaximum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudMaximum.ValueChanged += new System.EventHandler(this.NudMaximum_ValueChanged);
			// 
			// nudMinimum
			// 
			this.nudMinimum.Location = new System.Drawing.Point(17, 91);
			this.nudMinimum.Margin = new System.Windows.Forms.Padding(4);
			this.nudMinimum.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			this.nudMinimum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudMinimum.Name = "nudMinimum";
			this.nudMinimum.Size = new System.Drawing.Size(93, 22);
			this.nudMinimum.TabIndex = 17;
			this.nudMinimum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.nudMinimum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudMinimum.ValueChanged += new System.EventHandler(this.NudMinimum_ValueChanged);
			// 
			// txtSelectedGroupName
			// 
			this.txtSelectedGroupName.Location = new System.Drawing.Point(17, 43);
			this.txtSelectedGroupName.Margin = new System.Windows.Forms.Padding(4);
			this.txtSelectedGroupName.Name = "txtSelectedGroupName";
			this.txtSelectedGroupName.ReadOnly = true;
			this.txtSelectedGroupName.Size = new System.Drawing.Size(188, 22);
			this.txtSelectedGroupName.TabIndex = 12;
			this.txtSelectedGroupName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(112, 69);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(97, 21);
			this.label2.TabIndex = 14;
			this.label2.Text = "Max.";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// groupBox7
			// 
			this.groupBox7.Controls.Add(this.lbGroupItems);
			this.groupBox7.Dock = System.Windows.Forms.DockStyle.Left;
			this.groupBox7.Location = new System.Drawing.Point(4, 19);
			this.groupBox7.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox7.Size = new System.Drawing.Size(305, 233);
			this.groupBox7.TabIndex = 20;
			this.groupBox7.TabStop = false;
			this.groupBox7.Text = "Items";
			// 
			// lbGroupItems
			// 
			this.lbGroupItems.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbGroupItems.FormattingEnabled = true;
			this.lbGroupItems.ItemHeight = 16;
			this.lbGroupItems.Location = new System.Drawing.Point(4, 19);
			this.lbGroupItems.Margin = new System.Windows.Forms.Padding(4);
			this.lbGroupItems.Name = "lbGroupItems";
			this.lbGroupItems.Size = new System.Drawing.Size(297, 210);
			this.lbGroupItems.TabIndex = 4;
			// 
			// gbAllItems
			// 
			this.gbAllItems.Controls.Add(this.txtAllItemsFilter);
			this.gbAllItems.Controls.Add(this.lbAllItems);
			this.gbAllItems.Dock = System.Windows.Forms.DockStyle.Right;
			this.gbAllItems.Location = new System.Drawing.Point(532, 19);
			this.gbAllItems.Margin = new System.Windows.Forms.Padding(4);
			this.gbAllItems.Name = "gbAllItems";
			this.gbAllItems.Padding = new System.Windows.Forms.Padding(4);
			this.gbAllItems.Size = new System.Drawing.Size(287, 233);
			this.gbAllItems.TabIndex = 19;
			this.gbAllItems.TabStop = false;
			this.gbAllItems.Text = "All Items";
			// 
			// txtAllItemsFilter
			// 
			this.txtAllItemsFilter.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.txtAllItemsFilter.Location = new System.Drawing.Point(4, 17);
			this.txtAllItemsFilter.Margin = new System.Windows.Forms.Padding(4);
			this.txtAllItemsFilter.Name = "txtAllItemsFilter";
			this.txtAllItemsFilter.Size = new System.Drawing.Size(279, 22);
			this.txtAllItemsFilter.TabIndex = 7;
			this.txtAllItemsFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtAllItemsFilter.TextChanged += new System.EventHandler(this.TxtAllItemsFilter_TextChanged);
			// 
			// lbAllItems
			// 
			this.lbAllItems.AccessibleDescription = " ";
			this.lbAllItems.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lbAllItems.FormattingEnabled = true;
			this.lbAllItems.ItemHeight = 16;
			this.lbAllItems.Location = new System.Drawing.Point(4, 49);
			this.lbAllItems.Margin = new System.Windows.Forms.Padding(4);
			this.lbAllItems.Name = "lbAllItems";
			this.lbAllItems.Size = new System.Drawing.Size(279, 180);
			this.lbAllItems.TabIndex = 6;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.txtFilter);
			this.groupBox2.Controls.Add(this.lbMobs);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox2.Location = new System.Drawing.Point(0, 28);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox2.Size = new System.Drawing.Size(288, 300);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Mobs";
			// 
			// txtFilter
			// 
			this.txtFilter.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.txtFilter.Location = new System.Drawing.Point(8, 20);
			this.txtFilter.Margin = new System.Windows.Forms.Padding(4);
			this.txtFilter.Name = "txtFilter";
			this.txtFilter.Size = new System.Drawing.Size(271, 22);
			this.txtFilter.TabIndex = 5;
			this.txtFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtFilter.TextChanged += new System.EventHandler(this.TxtFilter_TextChanged);
			// 
			// lbMobs
			// 
			this.lbMobs.AccessibleDescription = " ";
			this.lbMobs.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lbMobs.FormattingEnabled = true;
			this.lbMobs.ItemHeight = 16;
			this.lbMobs.Location = new System.Drawing.Point(4, 52);
			this.lbMobs.Margin = new System.Windows.Forms.Padding(4);
			this.lbMobs.Name = "lbMobs";
			this.lbMobs.Size = new System.Drawing.Size(280, 244);
			this.lbMobs.TabIndex = 4;
			this.lbMobs.SelectedIndexChanged += new System.EventHandler(this.LbMobs_SelectedIndexChanged);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.txtItemGroupFilter);
			this.groupBox3.Controls.Add(this.txtNewItemGroup);
			this.groupBox3.Controls.Add(this.btnAddItemGroup);
			this.groupBox3.Controls.Add(this.lbItemGroups);
			this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.groupBox3.Location = new System.Drawing.Point(0, 339);
			this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox3.Size = new System.Drawing.Size(288, 315);
			this.groupBox3.TabIndex = 6;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Item Groups";
			// 
			// txtItemGroupFilter
			// 
			this.txtItemGroupFilter.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.txtItemGroupFilter.Location = new System.Drawing.Point(8, 21);
			this.txtItemGroupFilter.Margin = new System.Windows.Forms.Padding(4);
			this.txtItemGroupFilter.Name = "txtItemGroupFilter";
			this.txtItemGroupFilter.Size = new System.Drawing.Size(271, 22);
			this.txtItemGroupFilter.TabIndex = 11;
			this.txtItemGroupFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtItemGroupFilter.TextChanged += new System.EventHandler(this.TxtItemGroupFilter_TextChanged);
			// 
			// txtNewItemGroup
			// 
			this.txtNewItemGroup.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.txtNewItemGroup.Location = new System.Drawing.Point(5, 284);
			this.txtNewItemGroup.Margin = new System.Windows.Forms.Padding(4);
			this.txtNewItemGroup.Name = "txtNewItemGroup";
			this.txtNewItemGroup.Size = new System.Drawing.Size(229, 22);
			this.txtNewItemGroup.TabIndex = 10;
			this.txtNewItemGroup.Text = "NewGroup";
			this.txtNewItemGroup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btnAddItemGroup
			// 
			this.btnAddItemGroup.Location = new System.Drawing.Point(240, 283);
			this.btnAddItemGroup.Margin = new System.Windows.Forms.Padding(4);
			this.btnAddItemGroup.Name = "btnAddItemGroup";
			this.btnAddItemGroup.Size = new System.Drawing.Size(43, 28);
			this.btnAddItemGroup.TabIndex = 9;
			this.btnAddItemGroup.Text = "+";
			this.btnAddItemGroup.UseVisualStyleBackColor = true;
			this.btnAddItemGroup.Click += new System.EventHandler(this.BtnAddItemGroup_Click);
			// 
			// lbItemGroups
			// 
			this.lbItemGroups.FormattingEnabled = true;
			this.lbItemGroups.ItemHeight = 16;
			this.lbItemGroups.Location = new System.Drawing.Point(4, 52);
			this.lbItemGroups.Margin = new System.Windows.Forms.Padding(4);
			this.lbItemGroups.Name = "lbItemGroups";
			this.lbItemGroups.Size = new System.Drawing.Size(279, 228);
			this.lbItemGroups.TabIndex = 7;
			this.lbItemGroups.SelectedIndexChanged += new System.EventHandler(this.LbItemGroups_SelectedIndexChanged);
			// 
			// lblStatus
			// 
			this.lblStatus.ForeColor = System.Drawing.Color.White;
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(50, 20);
			this.lblStatus.Text = "Ready";
			// 
			// statusStrip1
			// 
			this.statusStrip1.BackColor = System.Drawing.Color.SteelBlue;
			this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
			this.statusStrip1.Location = new System.Drawing.Point(0, 654);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
			this.statusStrip1.Size = new System.Drawing.Size(1119, 25);
			this.statusStrip1.SizingGrip = false;
			this.statusStrip1.TabIndex = 2;
			// 
			// DropTableEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1119, 679);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "DropTableEditor";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Fiesta Drop Table Editor";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.groupBox8.ResumeLayout(false);
			this.groupBox8.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.CenRate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.MaxCen)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.MinCen)).EndInit();
			this.groupBox6.ResumeLayout(false);
			this.groupBox6.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudGroupDropRate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.UpGradeMax)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.UpGradeMin)).EndInit();
			this.groupBox4.ResumeLayout(false);
			this.gbGroupItem.ResumeLayout(false);
			this.gbGroupItem.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudMaximum)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMinimum)).EndInit();
			this.groupBox7.ResumeLayout(false);
			this.gbAllItems.ResumeLayout(false);
			this.gbAllItems.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuOpen;
        private System.Windows.Forms.ToolStripMenuItem menuSave;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.ListBox lbMobs;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtNewItemGroup;
        private System.Windows.Forms.Button btnAddItemGroup;
        private System.Windows.Forms.ListBox lbItemGroups;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnRemoveGroup;
        private System.Windows.Forms.TextBox txtAddGroup;
        private System.Windows.Forms.Button btnAddMobDropGroup;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ListView lvMobDropGroups;
        private System.Windows.Forms.ColumnHeader chGroupIndex;
        private System.Windows.Forms.ColumnHeader chDropRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGroupIndex;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gbGroupItem;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudGroupDropRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSelectedGroupName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudMaximum;
        private System.Windows.Forms.NumericUpDown nudMinimum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbAllItems;
        private System.Windows.Forms.TextBox txtAllItemsFilter;
        private System.Windows.Forms.ListBox lbAllItems;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ListBox lbGroupItems;
        private System.Windows.Forms.TextBox txtItemGroupFilter;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.Button btnDeleteGroup;
        private System.Windows.Forms.ToolStripMenuItem menuAddGroupToAll;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem menuRemoveAllGroups;
        private System.Windows.Forms.ToolStripMenuItem menuGroupRateEdit;
        private System.Windows.Forms.NumericUpDown UpGradeMax;
        private System.Windows.Forms.NumericUpDown UpGradeMin;
        private System.Windows.Forms.Label UpGradeMaxLabel;
        private System.Windows.Forms.Label UpGradeMinLabel;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown MaxCen;
        private System.Windows.Forms.NumericUpDown MinCen;
        private System.Windows.Forms.Label CenRateLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown CenRate;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripMenuItem creditsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuOpenFromPath;
        private System.Windows.Forms.ToolStripMenuItem menuOpenFromShine;
    }
}

