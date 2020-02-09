namespace MapBlockEditor
{
	partial class MapBlockEditor
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapBlockEditor));
			this.CreditsStrip = new System.Windows.Forms.StatusStrip();
			this.CreditsLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.elementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AddNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.setBackgroundImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewSHBDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sHBDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sHBDToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.TempToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MBETabControl = new System.Windows.Forms.TabControl();
			this.AIDPage = new System.Windows.Forms.TabPage();
			this.AIDListBox = new System.Windows.Forms.ListBox();
			this.AIDPropertyGrid = new System.Windows.Forms.PropertyGrid();
			this.SBIPage = new System.Windows.Forms.TabPage();
			this.PictureBoxPanel = new System.Windows.Forms.Panel();
			this.PictureBox = new System.Windows.Forms.PictureBox();
			this.SHABPage = new System.Windows.Forms.TabPage();
			this.SHBDPage = new System.Windows.Forms.TabPage();
			this.SHMDPage = new System.Windows.Forms.TabPage();
			this.SHMDTabs = new System.Windows.Forms.TabControl();
			this.GeneralTab = new System.Windows.Forms.TabPage();
			this.GeneralProperties = new System.Windows.Forms.PropertyGrid();
			this.SkyTab = new System.Windows.Forms.TabPage();
			this.DeleteSelectedSkyObjectButton = new System.Windows.Forms.Button();
			this.AddSkyObjectButton = new System.Windows.Forms.Button();
			this.AddSkyObjectTextBox = new System.Windows.Forms.TextBox();
			this.SkyBox = new System.Windows.Forms.ListBox();
			this.WaterTab = new System.Windows.Forms.TabPage();
			this.DeleteSelectedWaterObjectButton = new System.Windows.Forms.Button();
			this.AddWaterObjectButton = new System.Windows.Forms.Button();
			this.AddWaterObjectTextBox = new System.Windows.Forms.TextBox();
			this.WaterBox = new System.Windows.Forms.ListBox();
			this.GroundObjectsTab = new System.Windows.Forms.TabPage();
			this.DeleteSelectedGroundObjectButton = new System.Windows.Forms.Button();
			this.AddGroundObjectButton = new System.Windows.Forms.Button();
			this.AddGroundObjectTextBox = new System.Windows.Forms.TextBox();
			this.GroundObjectsBox = new System.Windows.Forms.ListBox();
			this.MapObjectsTab = new System.Windows.Forms.TabPage();
			this.DeleteSelectedMapObjectButton = new System.Windows.Forms.Button();
			this.AddMapObjectButton = new System.Windows.Forms.Button();
			this.AddMapObjectTextBox = new System.Windows.Forms.TextBox();
			this.MapObjectsProperties = new System.Windows.Forms.PropertyGrid();
			this.MapObjectsBox = new System.Windows.Forms.ListBox();
			this.DoorsListBox = new System.Windows.Forms.ListBox();
			this.DoorPropertyGrid = new System.Windows.Forms.PropertyGrid();
			this.DoorsGroupBox = new System.Windows.Forms.GroupBox();
			this.CreditsStrip.SuspendLayout();
			this.menuStrip.SuspendLayout();
			this.MBETabControl.SuspendLayout();
			this.AIDPage.SuspendLayout();
			this.SBIPage.SuspendLayout();
			this.PictureBoxPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
			this.SHMDPage.SuspendLayout();
			this.SHMDTabs.SuspendLayout();
			this.GeneralTab.SuspendLayout();
			this.SkyTab.SuspendLayout();
			this.WaterTab.SuspendLayout();
			this.GroundObjectsTab.SuspendLayout();
			this.MapObjectsTab.SuspendLayout();
			this.DoorsGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// CreditsStrip
			// 
			this.CreditsStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.CreditsStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreditsLabel});
			this.CreditsStrip.Location = new System.Drawing.Point(0, 985);
			this.CreditsStrip.Name = "CreditsStrip";
			this.CreditsStrip.Padding = new System.Windows.Forms.Padding(2, 0, 20, 0);
			this.CreditsStrip.Size = new System.Drawing.Size(1491, 42);
			this.CreditsStrip.SizingGrip = false;
			this.CreditsStrip.Stretch = false;
			this.CreditsStrip.TabIndex = 7;
			this.CreditsStrip.Text = "CreditsStrip";
			// 
			// CreditsLabel
			// 
			this.CreditsLabel.Name = "CreditsLabel";
			this.CreditsLabel.Size = new System.Drawing.Size(243, 32);
			this.CreditsLabel.Text = "Created by Gherblino";
			// 
			// menuStrip
			// 
			this.menuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
			this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.elementToolStripMenuItem,
            this.ViewToolStripMenuItem,
            this.TempToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
			this.menuStrip.Size = new System.Drawing.Size(1491, 48);
			this.menuStrip.TabIndex = 9;
			this.menuStrip.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveFolderToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.closeToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(72, 42);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.openToolStripMenuItem.Size = new System.Drawing.Size(451, 44);
			this.openToolStripMenuItem.Text = "Open";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
			// 
			// saveFolderToolStripMenuItem
			// 
			this.saveFolderToolStripMenuItem.Name = "saveFolderToolStripMenuItem";
			this.saveFolderToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.saveFolderToolStripMenuItem.Size = new System.Drawing.Size(451, 44);
			this.saveFolderToolStripMenuItem.Text = "Save Folder";
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(451, 44);
			this.saveToolStripMenuItem.Text = "Save Folder As";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(448, 6);
			// 
			// closeToolStripMenuItem
			// 
			this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
			this.closeToolStripMenuItem.Size = new System.Drawing.Size(451, 44);
			this.closeToolStripMenuItem.Text = "Close";
			this.closeToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
			// 
			// elementToolStripMenuItem
			// 
			this.elementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddNewToolStripMenuItem,
            this.deleteToolStripMenuItem});
			this.elementToolStripMenuItem.Name = "elementToolStripMenuItem";
			this.elementToolStripMenuItem.Size = new System.Drawing.Size(122, 42);
			this.elementToolStripMenuItem.Text = "Element";
			// 
			// AddNewToolStripMenuItem
			// 
			this.AddNewToolStripMenuItem.Name = "AddNewToolStripMenuItem";
			this.AddNewToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.AddNewToolStripMenuItem.Size = new System.Drawing.Size(333, 44);
			this.AddNewToolStripMenuItem.Text = "Add New";
			this.AddNewToolStripMenuItem.Click += new System.EventHandler(this.AddNewToolStripMenuItem_Click);
			// 
			// deleteToolStripMenuItem
			// 
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
			this.deleteToolStripMenuItem.Size = new System.Drawing.Size(333, 44);
			this.deleteToolStripMenuItem.Text = "Delete";
			// 
			// ViewToolStripMenuItem
			// 
			this.ViewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setBackgroundImageToolStripMenuItem,
            this.viewSHBDToolStripMenuItem,
            this.sHBDToolStripMenuItem,
            this.sHBDToolStripMenuItem1});
			this.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem";
			this.ViewToolStripMenuItem.Size = new System.Drawing.Size(86, 42);
			this.ViewToolStripMenuItem.Text = "View";
			// 
			// setBackgroundImageToolStripMenuItem
			// 
			this.setBackgroundImageToolStripMenuItem.Name = "setBackgroundImageToolStripMenuItem";
			this.setBackgroundImageToolStripMenuItem.Size = new System.Drawing.Size(210, 44);
			this.setBackgroundImageToolStripMenuItem.Text = "AID";
			this.setBackgroundImageToolStripMenuItem.Click += new System.EventHandler(this.SetBackgroundImageToolStripMenuItem_Click);
			// 
			// viewSHBDToolStripMenuItem
			// 
			this.viewSHBDToolStripMenuItem.Name = "viewSHBDToolStripMenuItem";
			this.viewSHBDToolStripMenuItem.Size = new System.Drawing.Size(210, 44);
			this.viewSHBDToolStripMenuItem.Text = "SBI";
			// 
			// sHBDToolStripMenuItem
			// 
			this.sHBDToolStripMenuItem.Name = "sHBDToolStripMenuItem";
			this.sHBDToolStripMenuItem.Size = new System.Drawing.Size(210, 44);
			this.sHBDToolStripMenuItem.Text = "SHAB";
			// 
			// sHBDToolStripMenuItem1
			// 
			this.sHBDToolStripMenuItem1.Name = "sHBDToolStripMenuItem1";
			this.sHBDToolStripMenuItem1.Size = new System.Drawing.Size(210, 44);
			this.sHBDToolStripMenuItem1.Text = "SHBD";
			// 
			// TempToolStripMenuItem
			// 
			this.TempToolStripMenuItem.Name = "TempToolStripMenuItem";
			this.TempToolStripMenuItem.Size = new System.Drawing.Size(94, 42);
			this.TempToolStripMenuItem.Text = "Temp";
			this.TempToolStripMenuItem.Click += new System.EventHandler(this.TempToolStripMenuItem_Click);
			// 
			// MBETabControl
			// 
			this.MBETabControl.Controls.Add(this.AIDPage);
			this.MBETabControl.Controls.Add(this.SBIPage);
			this.MBETabControl.Controls.Add(this.SHABPage);
			this.MBETabControl.Controls.Add(this.SHBDPage);
			this.MBETabControl.Controls.Add(this.SHMDPage);
			this.MBETabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MBETabControl.Location = new System.Drawing.Point(0, 48);
			this.MBETabControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MBETabControl.Name = "MBETabControl";
			this.MBETabControl.SelectedIndex = 0;
			this.MBETabControl.Size = new System.Drawing.Size(1122, 937);
			this.MBETabControl.TabIndex = 13;
			this.MBETabControl.SelectedIndexChanged += new System.EventHandler(this.MBETabControl_SelectedIndexChanged);
			// 
			// AIDPage
			// 
			this.AIDPage.Controls.Add(this.AIDListBox);
			this.AIDPage.Controls.Add(this.AIDPropertyGrid);
			this.AIDPage.Location = new System.Drawing.Point(8, 39);
			this.AIDPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.AIDPage.Name = "AIDPage";
			this.AIDPage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.AIDPage.Size = new System.Drawing.Size(1106, 890);
			this.AIDPage.TabIndex = 3;
			this.AIDPage.Text = "AID";
			this.AIDPage.UseVisualStyleBackColor = true;
			// 
			// AIDListBox
			// 
			this.AIDListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.AIDListBox.FormattingEnabled = true;
			this.AIDListBox.ItemHeight = 25;
			this.AIDListBox.Location = new System.Drawing.Point(0, 0);
			this.AIDListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.AIDListBox.Name = "AIDListBox";
			this.AIDListBox.Size = new System.Drawing.Size(1114, 479);
			this.AIDListBox.TabIndex = 4;
			this.AIDListBox.SelectedIndexChanged += new System.EventHandler(this.AIDListBox_SelectedIndexChanged);
			// 
			// AIDPropertyGrid
			// 
			this.AIDPropertyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.AIDPropertyGrid.Location = new System.Drawing.Point(0, 488);
			this.AIDPropertyGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.AIDPropertyGrid.Name = "AIDPropertyGrid";
			this.AIDPropertyGrid.PropertySort = System.Windows.Forms.PropertySort.NoSort;
			this.AIDPropertyGrid.Size = new System.Drawing.Size(1116, 404);
			this.AIDPropertyGrid.TabIndex = 3;
			// 
			// SBIPage
			// 
			this.SBIPage.Controls.Add(this.PictureBoxPanel);
			this.SBIPage.Location = new System.Drawing.Point(8, 39);
			this.SBIPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.SBIPage.Name = "SBIPage";
			this.SBIPage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.SBIPage.Size = new System.Drawing.Size(1106, 897);
			this.SBIPage.TabIndex = 0;
			this.SBIPage.Text = "SBI";
			this.SBIPage.UseVisualStyleBackColor = true;
			// 
			// PictureBoxPanel
			// 
			this.PictureBoxPanel.AutoScroll = true;
			this.PictureBoxPanel.Controls.Add(this.PictureBox);
			this.PictureBoxPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PictureBoxPanel.Location = new System.Drawing.Point(4, 5);
			this.PictureBoxPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.PictureBoxPanel.Name = "PictureBoxPanel";
			this.PictureBoxPanel.Size = new System.Drawing.Size(1098, 887);
			this.PictureBoxPanel.TabIndex = 13;
			// 
			// PictureBox
			// 
			this.PictureBox.Location = new System.Drawing.Point(-10, -9);
			this.PictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.PictureBox.Name = "PictureBox";
			this.PictureBox.Size = new System.Drawing.Size(1122, 909);
			this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PictureBox.TabIndex = 13;
			this.PictureBox.TabStop = false;
			this.PictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseMove);
			// 
			// SHABPage
			// 
			this.SHABPage.Location = new System.Drawing.Point(8, 39);
			this.SHABPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.SHABPage.Name = "SHABPage";
			this.SHABPage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.SHABPage.Size = new System.Drawing.Size(1106, 897);
			this.SHABPage.TabIndex = 2;
			this.SHABPage.Text = "SHAB";
			this.SHABPage.UseVisualStyleBackColor = true;
			// 
			// SHBDPage
			// 
			this.SHBDPage.Location = new System.Drawing.Point(8, 39);
			this.SHBDPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.SHBDPage.Name = "SHBDPage";
			this.SHBDPage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.SHBDPage.Size = new System.Drawing.Size(1106, 897);
			this.SHBDPage.TabIndex = 1;
			this.SHBDPage.Text = "SHBD";
			this.SHBDPage.UseVisualStyleBackColor = true;
			// 
			// SHMDPage
			// 
			this.SHMDPage.Controls.Add(this.SHMDTabs);
			this.SHMDPage.Location = new System.Drawing.Point(8, 39);
			this.SHMDPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.SHMDPage.Name = "SHMDPage";
			this.SHMDPage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.SHMDPage.Size = new System.Drawing.Size(1106, 897);
			this.SHMDPage.TabIndex = 4;
			this.SHMDPage.Text = "SHMD";
			this.SHMDPage.UseVisualStyleBackColor = true;
			// 
			// SHMDTabs
			// 
			this.SHMDTabs.Controls.Add(this.GeneralTab);
			this.SHMDTabs.Controls.Add(this.SkyTab);
			this.SHMDTabs.Controls.Add(this.WaterTab);
			this.SHMDTabs.Controls.Add(this.GroundObjectsTab);
			this.SHMDTabs.Controls.Add(this.MapObjectsTab);
			this.SHMDTabs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SHMDTabs.Location = new System.Drawing.Point(4, 5);
			this.SHMDTabs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.SHMDTabs.Name = "SHMDTabs";
			this.SHMDTabs.SelectedIndex = 0;
			this.SHMDTabs.Size = new System.Drawing.Size(1098, 887);
			this.SHMDTabs.TabIndex = 3;
			// 
			// GeneralTab
			// 
			this.GeneralTab.Controls.Add(this.GeneralProperties);
			this.GeneralTab.Location = new System.Drawing.Point(8, 39);
			this.GeneralTab.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.GeneralTab.Name = "GeneralTab";
			this.GeneralTab.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.GeneralTab.Size = new System.Drawing.Size(1082, 840);
			this.GeneralTab.TabIndex = 0;
			this.GeneralTab.Text = "General";
			this.GeneralTab.UseVisualStyleBackColor = true;
			// 
			// GeneralProperties
			// 
			this.GeneralProperties.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GeneralProperties.Location = new System.Drawing.Point(4, 3);
			this.GeneralProperties.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.GeneralProperties.Name = "GeneralProperties";
			this.GeneralProperties.PropertySort = System.Windows.Forms.PropertySort.NoSort;
			this.GeneralProperties.Size = new System.Drawing.Size(1074, 834);
			this.GeneralProperties.TabIndex = 0;
			// 
			// SkyTab
			// 
			this.SkyTab.Controls.Add(this.DeleteSelectedSkyObjectButton);
			this.SkyTab.Controls.Add(this.AddSkyObjectButton);
			this.SkyTab.Controls.Add(this.AddSkyObjectTextBox);
			this.SkyTab.Controls.Add(this.SkyBox);
			this.SkyTab.Location = new System.Drawing.Point(8, 39);
			this.SkyTab.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.SkyTab.Name = "SkyTab";
			this.SkyTab.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.SkyTab.Size = new System.Drawing.Size(1085, 842);
			this.SkyTab.TabIndex = 1;
			this.SkyTab.Text = "Sky";
			this.SkyTab.UseVisualStyleBackColor = true;
			// 
			// DeleteSelectedSkyObjectButton
			// 
			this.DeleteSelectedSkyObjectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.DeleteSelectedSkyObjectButton.Location = new System.Drawing.Point(854, 756);
			this.DeleteSelectedSkyObjectButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.DeleteSelectedSkyObjectButton.Name = "DeleteSelectedSkyObjectButton";
			this.DeleteSelectedSkyObjectButton.Size = new System.Drawing.Size(219, 47);
			this.DeleteSelectedSkyObjectButton.TabIndex = 8;
			this.DeleteSelectedSkyObjectButton.Text = "Delete Selected";
			this.DeleteSelectedSkyObjectButton.UseVisualStyleBackColor = true;
			this.DeleteSelectedSkyObjectButton.Click += new System.EventHandler(this.DeleteSelectedSkyObjectButton_Click);
			// 
			// AddSkyObjectButton
			// 
			this.AddSkyObjectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.AddSkyObjectButton.Location = new System.Drawing.Point(687, 756);
			this.AddSkyObjectButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.AddSkyObjectButton.Name = "AddSkyObjectButton";
			this.AddSkyObjectButton.Size = new System.Drawing.Size(158, 47);
			this.AddSkyObjectButton.TabIndex = 7;
			this.AddSkyObjectButton.Text = "Add New";
			this.AddSkyObjectButton.UseVisualStyleBackColor = true;
			this.AddSkyObjectButton.Click += new System.EventHandler(this.AddSkyObjectButton_Click);
			// 
			// AddSkyObjectTextBox
			// 
			this.AddSkyObjectTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.AddSkyObjectTextBox.Location = new System.Drawing.Point(4, 759);
			this.AddSkyObjectTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.AddSkyObjectTextBox.Name = "AddSkyObjectTextBox";
			this.AddSkyObjectTextBox.Size = new System.Drawing.Size(672, 31);
			this.AddSkyObjectTextBox.TabIndex = 6;
			this.AddSkyObjectTextBox.TextChanged += new System.EventHandler(this.AddSkyObjectTextBox_TextChanged);
			// 
			// SkyBox
			// 
			this.SkyBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.SkyBox.FormattingEnabled = true;
			this.SkyBox.ItemHeight = 25;
			this.SkyBox.Location = new System.Drawing.Point(4, 3);
			this.SkyBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.SkyBox.Name = "SkyBox";
			this.SkyBox.Size = new System.Drawing.Size(1066, 704);
			this.SkyBox.TabIndex = 0;
			// 
			// WaterTab
			// 
			this.WaterTab.Controls.Add(this.DeleteSelectedWaterObjectButton);
			this.WaterTab.Controls.Add(this.AddWaterObjectButton);
			this.WaterTab.Controls.Add(this.AddWaterObjectTextBox);
			this.WaterTab.Controls.Add(this.WaterBox);
			this.WaterTab.Location = new System.Drawing.Point(8, 39);
			this.WaterTab.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.WaterTab.Name = "WaterTab";
			this.WaterTab.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.WaterTab.Size = new System.Drawing.Size(1085, 842);
			this.WaterTab.TabIndex = 2;
			this.WaterTab.Text = "Water";
			this.WaterTab.UseVisualStyleBackColor = true;
			// 
			// DeleteSelectedWaterObjectButton
			// 
			this.DeleteSelectedWaterObjectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.DeleteSelectedWaterObjectButton.Location = new System.Drawing.Point(854, 756);
			this.DeleteSelectedWaterObjectButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.DeleteSelectedWaterObjectButton.Name = "DeleteSelectedWaterObjectButton";
			this.DeleteSelectedWaterObjectButton.Size = new System.Drawing.Size(219, 47);
			this.DeleteSelectedWaterObjectButton.TabIndex = 11;
			this.DeleteSelectedWaterObjectButton.Text = "Delete Selected";
			this.DeleteSelectedWaterObjectButton.UseVisualStyleBackColor = true;
			this.DeleteSelectedWaterObjectButton.Click += new System.EventHandler(this.DeleteSelectedWaterObjectButton_Click);
			// 
			// AddWaterObjectButton
			// 
			this.AddWaterObjectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.AddWaterObjectButton.Location = new System.Drawing.Point(687, 756);
			this.AddWaterObjectButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.AddWaterObjectButton.Name = "AddWaterObjectButton";
			this.AddWaterObjectButton.Size = new System.Drawing.Size(158, 47);
			this.AddWaterObjectButton.TabIndex = 10;
			this.AddWaterObjectButton.Text = "Add New";
			this.AddWaterObjectButton.UseVisualStyleBackColor = true;
			this.AddWaterObjectButton.Click += new System.EventHandler(this.AddWaterObjectButton_Click);
			// 
			// AddWaterObjectTextBox
			// 
			this.AddWaterObjectTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.AddWaterObjectTextBox.Location = new System.Drawing.Point(4, 759);
			this.AddWaterObjectTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.AddWaterObjectTextBox.Name = "AddWaterObjectTextBox";
			this.AddWaterObjectTextBox.Size = new System.Drawing.Size(672, 31);
			this.AddWaterObjectTextBox.TabIndex = 9;
			this.AddWaterObjectTextBox.TextChanged += new System.EventHandler(this.AddWaterObjectTextBox_TextChanged);
			// 
			// WaterBox
			// 
			this.WaterBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.WaterBox.FormattingEnabled = true;
			this.WaterBox.ItemHeight = 25;
			this.WaterBox.Location = new System.Drawing.Point(4, 3);
			this.WaterBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.WaterBox.Name = "WaterBox";
			this.WaterBox.Size = new System.Drawing.Size(1066, 704);
			this.WaterBox.TabIndex = 1;
			// 
			// GroundObjectsTab
			// 
			this.GroundObjectsTab.Controls.Add(this.DeleteSelectedGroundObjectButton);
			this.GroundObjectsTab.Controls.Add(this.AddGroundObjectButton);
			this.GroundObjectsTab.Controls.Add(this.AddGroundObjectTextBox);
			this.GroundObjectsTab.Controls.Add(this.GroundObjectsBox);
			this.GroundObjectsTab.Location = new System.Drawing.Point(8, 39);
			this.GroundObjectsTab.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.GroundObjectsTab.Name = "GroundObjectsTab";
			this.GroundObjectsTab.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.GroundObjectsTab.Size = new System.Drawing.Size(1085, 842);
			this.GroundObjectsTab.TabIndex = 3;
			this.GroundObjectsTab.Text = "GroundObjects";
			this.GroundObjectsTab.UseVisualStyleBackColor = true;
			// 
			// DeleteSelectedGroundObjectButton
			// 
			this.DeleteSelectedGroundObjectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.DeleteSelectedGroundObjectButton.Location = new System.Drawing.Point(854, 756);
			this.DeleteSelectedGroundObjectButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.DeleteSelectedGroundObjectButton.Name = "DeleteSelectedGroundObjectButton";
			this.DeleteSelectedGroundObjectButton.Size = new System.Drawing.Size(219, 47);
			this.DeleteSelectedGroundObjectButton.TabIndex = 14;
			this.DeleteSelectedGroundObjectButton.Text = "Delete Selected";
			this.DeleteSelectedGroundObjectButton.UseVisualStyleBackColor = true;
			this.DeleteSelectedGroundObjectButton.Click += new System.EventHandler(this.DeleteSelectedGroundObjectButton_Click);
			// 
			// AddGroundObjectButton
			// 
			this.AddGroundObjectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.AddGroundObjectButton.Location = new System.Drawing.Point(687, 756);
			this.AddGroundObjectButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.AddGroundObjectButton.Name = "AddGroundObjectButton";
			this.AddGroundObjectButton.Size = new System.Drawing.Size(158, 47);
			this.AddGroundObjectButton.TabIndex = 13;
			this.AddGroundObjectButton.Text = "Add New";
			this.AddGroundObjectButton.UseVisualStyleBackColor = true;
			this.AddGroundObjectButton.Click += new System.EventHandler(this.AddGroundObjectButton_Click);
			// 
			// AddGroundObjectTextBox
			// 
			this.AddGroundObjectTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.AddGroundObjectTextBox.Location = new System.Drawing.Point(4, 759);
			this.AddGroundObjectTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.AddGroundObjectTextBox.Name = "AddGroundObjectTextBox";
			this.AddGroundObjectTextBox.Size = new System.Drawing.Size(672, 31);
			this.AddGroundObjectTextBox.TabIndex = 12;
			this.AddGroundObjectTextBox.TextChanged += new System.EventHandler(this.AddGroundObjectTextBox_TextChanged);
			// 
			// GroundObjectsBox
			// 
			this.GroundObjectsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.GroundObjectsBox.FormattingEnabled = true;
			this.GroundObjectsBox.ItemHeight = 25;
			this.GroundObjectsBox.Location = new System.Drawing.Point(4, 3);
			this.GroundObjectsBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.GroundObjectsBox.Name = "GroundObjectsBox";
			this.GroundObjectsBox.Size = new System.Drawing.Size(1066, 704);
			this.GroundObjectsBox.TabIndex = 2;
			// 
			// MapObjectsTab
			// 
			this.MapObjectsTab.Controls.Add(this.DeleteSelectedMapObjectButton);
			this.MapObjectsTab.Controls.Add(this.AddMapObjectButton);
			this.MapObjectsTab.Controls.Add(this.AddMapObjectTextBox);
			this.MapObjectsTab.Controls.Add(this.MapObjectsProperties);
			this.MapObjectsTab.Controls.Add(this.MapObjectsBox);
			this.MapObjectsTab.Location = new System.Drawing.Point(8, 39);
			this.MapObjectsTab.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.MapObjectsTab.Name = "MapObjectsTab";
			this.MapObjectsTab.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.MapObjectsTab.Size = new System.Drawing.Size(1085, 842);
			this.MapObjectsTab.TabIndex = 4;
			this.MapObjectsTab.Text = "MapObjects";
			this.MapObjectsTab.UseVisualStyleBackColor = true;
			// 
			// DeleteSelectedMapObjectButton
			// 
			this.DeleteSelectedMapObjectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.DeleteSelectedMapObjectButton.Location = new System.Drawing.Point(854, 336);
			this.DeleteSelectedMapObjectButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.DeleteSelectedMapObjectButton.Name = "DeleteSelectedMapObjectButton";
			this.DeleteSelectedMapObjectButton.Size = new System.Drawing.Size(219, 47);
			this.DeleteSelectedMapObjectButton.TabIndex = 5;
			this.DeleteSelectedMapObjectButton.Text = "Delete Selected";
			this.DeleteSelectedMapObjectButton.UseVisualStyleBackColor = true;
			this.DeleteSelectedMapObjectButton.Click += new System.EventHandler(this.DeleteSelectedMapObjectButton_Click);
			// 
			// AddMapObjectButton
			// 
			this.AddMapObjectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.AddMapObjectButton.Location = new System.Drawing.Point(687, 336);
			this.AddMapObjectButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.AddMapObjectButton.Name = "AddMapObjectButton";
			this.AddMapObjectButton.Size = new System.Drawing.Size(158, 47);
			this.AddMapObjectButton.TabIndex = 4;
			this.AddMapObjectButton.Text = "Add New";
			this.AddMapObjectButton.UseVisualStyleBackColor = true;
			this.AddMapObjectButton.Click += new System.EventHandler(this.AddMapObjectButton_Click);
			// 
			// AddMapObjectTextBox
			// 
			this.AddMapObjectTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.AddMapObjectTextBox.Location = new System.Drawing.Point(4, 338);
			this.AddMapObjectTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.AddMapObjectTextBox.Name = "AddMapObjectTextBox";
			this.AddMapObjectTextBox.Size = new System.Drawing.Size(672, 31);
			this.AddMapObjectTextBox.TabIndex = 3;
			this.AddMapObjectTextBox.TextChanged += new System.EventHandler(this.AddMapObjectTextBox_TextChanged);
			// 
			// MapObjectsProperties
			// 
			this.MapObjectsProperties.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.MapObjectsProperties.Location = new System.Drawing.Point(4, 422);
			this.MapObjectsProperties.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.MapObjectsProperties.Name = "MapObjectsProperties";
			this.MapObjectsProperties.PropertySort = System.Windows.Forms.PropertySort.NoSort;
			this.MapObjectsProperties.Size = new System.Drawing.Size(1077, 417);
			this.MapObjectsProperties.TabIndex = 2;
			// 
			// MapObjectsBox
			// 
			this.MapObjectsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.MapObjectsBox.FormattingEnabled = true;
			this.MapObjectsBox.ItemHeight = 25;
			this.MapObjectsBox.Location = new System.Drawing.Point(0, 0);
			this.MapObjectsBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.MapObjectsBox.Name = "MapObjectsBox";
			this.MapObjectsBox.Size = new System.Drawing.Size(1070, 304);
			this.MapObjectsBox.TabIndex = 1;
			this.MapObjectsBox.SelectedIndexChanged += new System.EventHandler(this.MapObjectsBox_SelectedIndexChanged);
			// 
			// DoorsListBox
			// 
			this.DoorsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.DoorsListBox.FormattingEnabled = true;
			this.DoorsListBox.HorizontalScrollbar = true;
			this.DoorsListBox.ItemHeight = 25;
			this.DoorsListBox.Location = new System.Drawing.Point(0, 31);
			this.DoorsListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.DoorsListBox.Name = "DoorsListBox";
			this.DoorsListBox.Size = new System.Drawing.Size(358, 329);
			this.DoorsListBox.TabIndex = 0;
			this.DoorsListBox.SelectedIndexChanged += new System.EventHandler(this.DoorsListBox_SelectedIndexChanged);
			// 
			// DoorPropertyGrid
			// 
			this.DoorPropertyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.DoorPropertyGrid.Location = new System.Drawing.Point(0, 372);
			this.DoorPropertyGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.DoorPropertyGrid.Name = "DoorPropertyGrid";
			this.DoorPropertyGrid.PropertySort = System.Windows.Forms.PropertySort.NoSort;
			this.DoorPropertyGrid.Size = new System.Drawing.Size(360, 565);
			this.DoorPropertyGrid.TabIndex = 0;
			this.DoorPropertyGrid.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.DoorPropertyGrid_PropertyValueChanged);
			// 
			// DoorsGroupBox
			// 
			this.DoorsGroupBox.Controls.Add(this.DoorPropertyGrid);
			this.DoorsGroupBox.Controls.Add(this.DoorsListBox);
			this.DoorsGroupBox.Dock = System.Windows.Forms.DockStyle.Right;
			this.DoorsGroupBox.Location = new System.Drawing.Point(1122, 48);
			this.DoorsGroupBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.DoorsGroupBox.Name = "DoorsGroupBox";
			this.DoorsGroupBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.DoorsGroupBox.Size = new System.Drawing.Size(369, 937);
			this.DoorsGroupBox.TabIndex = 12;
			this.DoorsGroupBox.TabStop = false;
			this.DoorsGroupBox.Text = "Doors";
			this.DoorsGroupBox.Visible = false;
			// 
			// MapBlockEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1491, 1027);
			this.Controls.Add(this.MBETabControl);
			this.Controls.Add(this.DoorsGroupBox);
			this.Controls.Add(this.CreditsStrip);
			this.Controls.Add(this.menuStrip);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MainMenuStrip = this.menuStrip;
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Name = "MapBlockEditor";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Fiesta Map Block Editor";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.MapBlockEditor_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MapBlockEditorForm_KeyDown);
			this.CreditsStrip.ResumeLayout(false);
			this.CreditsStrip.PerformLayout();
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.MBETabControl.ResumeLayout(false);
			this.AIDPage.ResumeLayout(false);
			this.SBIPage.ResumeLayout(false);
			this.PictureBoxPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
			this.SHMDPage.ResumeLayout(false);
			this.SHMDTabs.ResumeLayout(false);
			this.GeneralTab.ResumeLayout(false);
			this.SkyTab.ResumeLayout(false);
			this.SkyTab.PerformLayout();
			this.WaterTab.ResumeLayout(false);
			this.WaterTab.PerformLayout();
			this.GroundObjectsTab.ResumeLayout(false);
			this.GroundObjectsTab.PerformLayout();
			this.MapObjectsTab.ResumeLayout(false);
			this.MapObjectsTab.PerformLayout();
			this.DoorsGroupBox.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.StatusStrip CreditsStrip;
		private System.Windows.Forms.ToolStripStatusLabel CreditsLabel;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ViewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem setBackgroundImageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewSHBDToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sHBDToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sHBDToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem TempToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem elementToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem AddNewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveFolderToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
		private System.Windows.Forms.TabControl MBETabControl;
		private System.Windows.Forms.TabPage SBIPage;
		private System.Windows.Forms.TabPage SHBDPage;
		private System.Windows.Forms.Panel PictureBoxPanel;
		private System.Windows.Forms.PictureBox PictureBox;
		private System.Windows.Forms.ListBox DoorsListBox;
		private System.Windows.Forms.PropertyGrid DoorPropertyGrid;
		private System.Windows.Forms.GroupBox DoorsGroupBox;
		private System.Windows.Forms.TabPage SHABPage;
		private System.Windows.Forms.TabPage AIDPage;
		private System.Windows.Forms.TabPage SHMDPage;
		private System.Windows.Forms.ListBox AIDListBox;
		private System.Windows.Forms.PropertyGrid AIDPropertyGrid;
		private System.Windows.Forms.TabControl SHMDTabs;
		private System.Windows.Forms.TabPage GeneralTab;
		private System.Windows.Forms.PropertyGrid GeneralProperties;
		private System.Windows.Forms.TabPage SkyTab;
		private System.Windows.Forms.Button DeleteSelectedSkyObjectButton;
		private System.Windows.Forms.Button AddSkyObjectButton;
		private System.Windows.Forms.TextBox AddSkyObjectTextBox;
		private System.Windows.Forms.ListBox SkyBox;
		private System.Windows.Forms.TabPage WaterTab;
		private System.Windows.Forms.Button DeleteSelectedWaterObjectButton;
		private System.Windows.Forms.Button AddWaterObjectButton;
		private System.Windows.Forms.TextBox AddWaterObjectTextBox;
		private System.Windows.Forms.ListBox WaterBox;
		private System.Windows.Forms.TabPage GroundObjectsTab;
		private System.Windows.Forms.Button DeleteSelectedGroundObjectButton;
		private System.Windows.Forms.Button AddGroundObjectButton;
		private System.Windows.Forms.TextBox AddGroundObjectTextBox;
		private System.Windows.Forms.ListBox GroundObjectsBox;
		private System.Windows.Forms.TabPage MapObjectsTab;
		private System.Windows.Forms.Button DeleteSelectedMapObjectButton;
		private System.Windows.Forms.Button AddMapObjectButton;
		private System.Windows.Forms.TextBox AddMapObjectTextBox;
		private System.Windows.Forms.PropertyGrid MapObjectsProperties;
		private System.Windows.Forms.ListBox MapObjectsBox;
	}
}

