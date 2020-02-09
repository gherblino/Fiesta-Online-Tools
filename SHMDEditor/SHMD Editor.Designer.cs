namespace SHMDEditor
{
	partial class SHMDEditor
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SHMDEditor));
			this.CreditsStrip = new System.Windows.Forms.StatusStrip();
			this.CreditsLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.OpenMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.SaveMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.SaveAsMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.CloseMenu = new System.Windows.Forms.ToolStripMenuItem();
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
			this.CreditsStrip.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SHMDTabs.SuspendLayout();
			this.GeneralTab.SuspendLayout();
			this.SkyTab.SuspendLayout();
			this.WaterTab.SuspendLayout();
			this.GroundObjectsTab.SuspendLayout();
			this.MapObjectsTab.SuspendLayout();
			this.SuspendLayout();
			// 
			// CreditsStrip
			// 
			this.CreditsStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.CreditsStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreditsLabel});
			this.CreditsStrip.Location = new System.Drawing.Point(0, 645);
			this.CreditsStrip.Name = "CreditsStrip";
			this.CreditsStrip.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
			this.CreditsStrip.Size = new System.Drawing.Size(648, 25);
			this.CreditsStrip.SizingGrip = false;
			this.CreditsStrip.TabIndex = 0;
			this.CreditsStrip.Text = "CreditsStrip";
			// 
			// CreditsLabel
			// 
			this.CreditsLabel.Name = "CreditsLabel";
			this.CreditsLabel.Size = new System.Drawing.Size(150, 20);
			this.CreditsLabel.Text = "Created by Gherblino";
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(648, 28);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenMenu,
            this.SaveMenu,
            this.SaveAsMenu,
            this.toolStripSeparator1,
            this.CloseMenu});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// OpenMenu
			// 
			this.OpenMenu.Name = "OpenMenu";
			this.OpenMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.OpenMenu.Size = new System.Drawing.Size(214, 26);
			this.OpenMenu.Text = "Open";
			this.OpenMenu.ToolTipText = "Open SHMD file";
			this.OpenMenu.Click += new System.EventHandler(this.OpenMenu_Click);
			// 
			// SaveMenu
			// 
			this.SaveMenu.Name = "SaveMenu";
			this.SaveMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.SaveMenu.Size = new System.Drawing.Size(214, 26);
			this.SaveMenu.Text = "Save";
			this.SaveMenu.ToolTipText = "Save selected SHMD file";
			this.SaveMenu.Click += new System.EventHandler(this.SaveMenu_Click);
			// 
			// SaveAsMenu
			// 
			this.SaveAsMenu.Name = "SaveAsMenu";
			this.SaveAsMenu.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
			this.SaveAsMenu.Size = new System.Drawing.Size(214, 26);
			this.SaveAsMenu.Text = "Save As";
			this.SaveAsMenu.ToolTipText = "Save SHMD file as";
			this.SaveAsMenu.Click += new System.EventHandler(this.SaveAsMenu_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(211, 6);
			// 
			// CloseMenu
			// 
			this.CloseMenu.Name = "CloseMenu";
			this.CloseMenu.Size = new System.Drawing.Size(214, 26);
			this.CloseMenu.Text = "Close";
			this.CloseMenu.ToolTipText = "Close SHMD file";
			this.CloseMenu.Click += new System.EventHandler(this.CloseMenu_Click);
			// 
			// SHMDTabs
			// 
			this.SHMDTabs.Controls.Add(this.GeneralTab);
			this.SHMDTabs.Controls.Add(this.SkyTab);
			this.SHMDTabs.Controls.Add(this.WaterTab);
			this.SHMDTabs.Controls.Add(this.GroundObjectsTab);
			this.SHMDTabs.Controls.Add(this.MapObjectsTab);
			this.SHMDTabs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SHMDTabs.Location = new System.Drawing.Point(0, 28);
			this.SHMDTabs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.SHMDTabs.Name = "SHMDTabs";
			this.SHMDTabs.SelectedIndex = 0;
			this.SHMDTabs.Size = new System.Drawing.Size(648, 617);
			this.SHMDTabs.TabIndex = 2;
			// 
			// GeneralTab
			// 
			this.GeneralTab.Controls.Add(this.GeneralProperties);
			this.GeneralTab.Location = new System.Drawing.Point(4, 25);
			this.GeneralTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.GeneralTab.Name = "GeneralTab";
			this.GeneralTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.GeneralTab.Size = new System.Drawing.Size(640, 588);
			this.GeneralTab.TabIndex = 0;
			this.GeneralTab.Text = "General";
			this.GeneralTab.UseVisualStyleBackColor = true;
			// 
			// GeneralProperties
			// 
			this.GeneralProperties.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GeneralProperties.Location = new System.Drawing.Point(3, 2);
			this.GeneralProperties.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.GeneralProperties.Name = "GeneralProperties";
			this.GeneralProperties.PropertySort = System.Windows.Forms.PropertySort.NoSort;
			this.GeneralProperties.Size = new System.Drawing.Size(634, 584);
			this.GeneralProperties.TabIndex = 0;
			// 
			// SkyTab
			// 
			this.SkyTab.Controls.Add(this.DeleteSelectedSkyObjectButton);
			this.SkyTab.Controls.Add(this.AddSkyObjectButton);
			this.SkyTab.Controls.Add(this.AddSkyObjectTextBox);
			this.SkyTab.Controls.Add(this.SkyBox);
			this.SkyTab.Location = new System.Drawing.Point(4, 25);
			this.SkyTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.SkyTab.Name = "SkyTab";
			this.SkyTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.SkyTab.Size = new System.Drawing.Size(640, 588);
			this.SkyTab.TabIndex = 1;
			this.SkyTab.Text = "Sky";
			this.SkyTab.UseVisualStyleBackColor = true;
			// 
			// DeleteSelectedSkyObjectButton
			// 
			this.DeleteSelectedSkyObjectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.DeleteSelectedSkyObjectButton.Location = new System.Drawing.Point(491, 550);
			this.DeleteSelectedSkyObjectButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.DeleteSelectedSkyObjectButton.Name = "DeleteSelectedSkyObjectButton";
			this.DeleteSelectedSkyObjectButton.Size = new System.Drawing.Size(146, 30);
			this.DeleteSelectedSkyObjectButton.TabIndex = 8;
			this.DeleteSelectedSkyObjectButton.Text = "Delete Selected";
			this.DeleteSelectedSkyObjectButton.UseVisualStyleBackColor = true;
			this.DeleteSelectedSkyObjectButton.Click += new System.EventHandler(this.DeleteSelectedSkyObjectButton_Click);
			// 
			// AddSkyObjectButton
			// 
			this.AddSkyObjectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.AddSkyObjectButton.Location = new System.Drawing.Point(380, 550);
			this.AddSkyObjectButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.AddSkyObjectButton.Name = "AddSkyObjectButton";
			this.AddSkyObjectButton.Size = new System.Drawing.Size(105, 30);
			this.AddSkyObjectButton.TabIndex = 7;
			this.AddSkyObjectButton.Text = "Add New";
			this.AddSkyObjectButton.UseVisualStyleBackColor = true;
			this.AddSkyObjectButton.Click += new System.EventHandler(this.AddSkyObjectButton_Click);
			// 
			// AddSkyObjectTextBox
			// 
			this.AddSkyObjectTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.AddSkyObjectTextBox.Location = new System.Drawing.Point(3, 552);
			this.AddSkyObjectTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.AddSkyObjectTextBox.Name = "AddSkyObjectTextBox";
			this.AddSkyObjectTextBox.Size = new System.Drawing.Size(371, 22);
			this.AddSkyObjectTextBox.TabIndex = 6;
			this.AddSkyObjectTextBox.TextChanged += new System.EventHandler(this.AddSkyObjectTextBox_TextChanged);
			// 
			// SkyBox
			// 
			this.SkyBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.SkyBox.FormattingEnabled = true;
			this.SkyBox.ItemHeight = 16;
			this.SkyBox.Location = new System.Drawing.Point(3, 2);
			this.SkyBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.SkyBox.Name = "SkyBox";
			this.SkyBox.Size = new System.Drawing.Size(634, 532);
			this.SkyBox.TabIndex = 0;
			// 
			// WaterTab
			// 
			this.WaterTab.Controls.Add(this.DeleteSelectedWaterObjectButton);
			this.WaterTab.Controls.Add(this.AddWaterObjectButton);
			this.WaterTab.Controls.Add(this.AddWaterObjectTextBox);
			this.WaterTab.Controls.Add(this.WaterBox);
			this.WaterTab.Location = new System.Drawing.Point(4, 25);
			this.WaterTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.WaterTab.Name = "WaterTab";
			this.WaterTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.WaterTab.Size = new System.Drawing.Size(640, 588);
			this.WaterTab.TabIndex = 2;
			this.WaterTab.Text = "Water";
			this.WaterTab.UseVisualStyleBackColor = true;
			// 
			// DeleteSelectedWaterObjectButton
			// 
			this.DeleteSelectedWaterObjectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.DeleteSelectedWaterObjectButton.Location = new System.Drawing.Point(491, 550);
			this.DeleteSelectedWaterObjectButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.DeleteSelectedWaterObjectButton.Name = "DeleteSelectedWaterObjectButton";
			this.DeleteSelectedWaterObjectButton.Size = new System.Drawing.Size(146, 30);
			this.DeleteSelectedWaterObjectButton.TabIndex = 11;
			this.DeleteSelectedWaterObjectButton.Text = "Delete Selected";
			this.DeleteSelectedWaterObjectButton.UseVisualStyleBackColor = true;
			this.DeleteSelectedWaterObjectButton.Click += new System.EventHandler(this.DeleteSelectedWaterObjectButton_Click);
			// 
			// AddWaterObjectButton
			// 
			this.AddWaterObjectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.AddWaterObjectButton.Location = new System.Drawing.Point(380, 550);
			this.AddWaterObjectButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.AddWaterObjectButton.Name = "AddWaterObjectButton";
			this.AddWaterObjectButton.Size = new System.Drawing.Size(105, 30);
			this.AddWaterObjectButton.TabIndex = 10;
			this.AddWaterObjectButton.Text = "Add New";
			this.AddWaterObjectButton.UseVisualStyleBackColor = true;
			this.AddWaterObjectButton.Click += new System.EventHandler(this.AddWaterObjectButton_Click);
			// 
			// AddWaterObjectTextBox
			// 
			this.AddWaterObjectTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.AddWaterObjectTextBox.Location = new System.Drawing.Point(3, 552);
			this.AddWaterObjectTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.AddWaterObjectTextBox.Name = "AddWaterObjectTextBox";
			this.AddWaterObjectTextBox.Size = new System.Drawing.Size(371, 22);
			this.AddWaterObjectTextBox.TabIndex = 9;
			this.AddWaterObjectTextBox.TextChanged += new System.EventHandler(this.AddWaterObjectTextBox_TextChanged);
			// 
			// WaterBox
			// 
			this.WaterBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.WaterBox.FormattingEnabled = true;
			this.WaterBox.ItemHeight = 16;
			this.WaterBox.Location = new System.Drawing.Point(3, 2);
			this.WaterBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.WaterBox.Name = "WaterBox";
			this.WaterBox.Size = new System.Drawing.Size(634, 532);
			this.WaterBox.TabIndex = 1;
			// 
			// GroundObjectsTab
			// 
			this.GroundObjectsTab.Controls.Add(this.DeleteSelectedGroundObjectButton);
			this.GroundObjectsTab.Controls.Add(this.AddGroundObjectButton);
			this.GroundObjectsTab.Controls.Add(this.AddGroundObjectTextBox);
			this.GroundObjectsTab.Controls.Add(this.GroundObjectsBox);
			this.GroundObjectsTab.Location = new System.Drawing.Point(4, 25);
			this.GroundObjectsTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.GroundObjectsTab.Name = "GroundObjectsTab";
			this.GroundObjectsTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.GroundObjectsTab.Size = new System.Drawing.Size(640, 588);
			this.GroundObjectsTab.TabIndex = 3;
			this.GroundObjectsTab.Text = "GroundObjects";
			this.GroundObjectsTab.UseVisualStyleBackColor = true;
			// 
			// DeleteSelectedGroundObjectButton
			// 
			this.DeleteSelectedGroundObjectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.DeleteSelectedGroundObjectButton.Location = new System.Drawing.Point(491, 550);
			this.DeleteSelectedGroundObjectButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.DeleteSelectedGroundObjectButton.Name = "DeleteSelectedGroundObjectButton";
			this.DeleteSelectedGroundObjectButton.Size = new System.Drawing.Size(146, 30);
			this.DeleteSelectedGroundObjectButton.TabIndex = 14;
			this.DeleteSelectedGroundObjectButton.Text = "Delete Selected";
			this.DeleteSelectedGroundObjectButton.UseVisualStyleBackColor = true;
			this.DeleteSelectedGroundObjectButton.Click += new System.EventHandler(this.DeleteSelectedGroundObjectButton_Click);
			// 
			// AddGroundObjectButton
			// 
			this.AddGroundObjectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.AddGroundObjectButton.Location = new System.Drawing.Point(380, 550);
			this.AddGroundObjectButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.AddGroundObjectButton.Name = "AddGroundObjectButton";
			this.AddGroundObjectButton.Size = new System.Drawing.Size(105, 30);
			this.AddGroundObjectButton.TabIndex = 13;
			this.AddGroundObjectButton.Text = "Add New";
			this.AddGroundObjectButton.UseVisualStyleBackColor = true;
			this.AddGroundObjectButton.Click += new System.EventHandler(this.AddGroundObjectButton_Click);
			// 
			// AddGroundObjectTextBox
			// 
			this.AddGroundObjectTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.AddGroundObjectTextBox.Location = new System.Drawing.Point(3, 552);
			this.AddGroundObjectTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.AddGroundObjectTextBox.Name = "AddGroundObjectTextBox";
			this.AddGroundObjectTextBox.Size = new System.Drawing.Size(371, 22);
			this.AddGroundObjectTextBox.TabIndex = 12;
			this.AddGroundObjectTextBox.TextChanged += new System.EventHandler(this.AddGroundObjectTextBox_TextChanged);
			// 
			// GroundObjectsBox
			// 
			this.GroundObjectsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.GroundObjectsBox.FormattingEnabled = true;
			this.GroundObjectsBox.ItemHeight = 16;
			this.GroundObjectsBox.Location = new System.Drawing.Point(3, 2);
			this.GroundObjectsBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.GroundObjectsBox.Name = "GroundObjectsBox";
			this.GroundObjectsBox.Size = new System.Drawing.Size(634, 532);
			this.GroundObjectsBox.TabIndex = 2;
			// 
			// MapObjectsTab
			// 
			this.MapObjectsTab.Controls.Add(this.DeleteSelectedMapObjectButton);
			this.MapObjectsTab.Controls.Add(this.AddMapObjectButton);
			this.MapObjectsTab.Controls.Add(this.AddMapObjectTextBox);
			this.MapObjectsTab.Controls.Add(this.MapObjectsProperties);
			this.MapObjectsTab.Controls.Add(this.MapObjectsBox);
			this.MapObjectsTab.Location = new System.Drawing.Point(4, 25);
			this.MapObjectsTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.MapObjectsTab.Name = "MapObjectsTab";
			this.MapObjectsTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.MapObjectsTab.Size = new System.Drawing.Size(640, 588);
			this.MapObjectsTab.TabIndex = 4;
			this.MapObjectsTab.Text = "MapObjects";
			this.MapObjectsTab.UseVisualStyleBackColor = true;
			// 
			// DeleteSelectedMapObjectButton
			// 
			this.DeleteSelectedMapObjectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.DeleteSelectedMapObjectButton.Location = new System.Drawing.Point(491, 281);
			this.DeleteSelectedMapObjectButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.DeleteSelectedMapObjectButton.Name = "DeleteSelectedMapObjectButton";
			this.DeleteSelectedMapObjectButton.Size = new System.Drawing.Size(146, 30);
			this.DeleteSelectedMapObjectButton.TabIndex = 5;
			this.DeleteSelectedMapObjectButton.Text = "Delete Selected";
			this.DeleteSelectedMapObjectButton.UseVisualStyleBackColor = true;
			this.DeleteSelectedMapObjectButton.Click += new System.EventHandler(this.DeleteSelectedMapObjectButton_Click);
			// 
			// AddMapObjectButton
			// 
			this.AddMapObjectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.AddMapObjectButton.Location = new System.Drawing.Point(380, 281);
			this.AddMapObjectButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.AddMapObjectButton.Name = "AddMapObjectButton";
			this.AddMapObjectButton.Size = new System.Drawing.Size(105, 30);
			this.AddMapObjectButton.TabIndex = 4;
			this.AddMapObjectButton.Text = "Add New";
			this.AddMapObjectButton.UseVisualStyleBackColor = true;
			this.AddMapObjectButton.Click += new System.EventHandler(this.AddMapObjectButton_Click);
			// 
			// AddMapObjectTextBox
			// 
			this.AddMapObjectTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.AddMapObjectTextBox.Location = new System.Drawing.Point(3, 282);
			this.AddMapObjectTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.AddMapObjectTextBox.Name = "AddMapObjectTextBox";
			this.AddMapObjectTextBox.Size = new System.Drawing.Size(371, 22);
			this.AddMapObjectTextBox.TabIndex = 3;
			this.AddMapObjectTextBox.TextChanged += new System.EventHandler(this.AddMapObjectTextBox_TextChanged);
			// 
			// MapObjectsProperties
			// 
			this.MapObjectsProperties.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.MapObjectsProperties.Location = new System.Drawing.Point(3, 319);
			this.MapObjectsProperties.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.MapObjectsProperties.Name = "MapObjectsProperties";
			this.MapObjectsProperties.PropertySort = System.Windows.Forms.PropertySort.NoSort;
			this.MapObjectsProperties.Size = new System.Drawing.Size(634, 267);
			this.MapObjectsProperties.TabIndex = 2;
			// 
			// MapObjectsBox
			// 
			this.MapObjectsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.MapObjectsBox.FormattingEnabled = true;
			this.MapObjectsBox.ItemHeight = 16;
			this.MapObjectsBox.Location = new System.Drawing.Point(0, 0);
			this.MapObjectsBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.MapObjectsBox.Name = "MapObjectsBox";
			this.MapObjectsBox.Size = new System.Drawing.Size(637, 276);
			this.MapObjectsBox.TabIndex = 1;
			this.MapObjectsBox.SelectedIndexChanged += new System.EventHandler(this.MapObjectsBox_SelectedIndexChanged);
			// 
			// SHMDEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(648, 670);
			this.Controls.Add(this.SHMDTabs);
			this.Controls.Add(this.CreditsStrip);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "SHMDEditor";
			this.Text = "Fiesta SHMD Editor";
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.SHMDEditor_Paint);
			this.CreditsStrip.ResumeLayout(false);
			this.CreditsStrip.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
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
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.StatusStrip CreditsStrip;
		private System.Windows.Forms.ToolStripStatusLabel CreditsLabel;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem OpenMenu;
		private System.Windows.Forms.ToolStripMenuItem SaveMenu;
		private System.Windows.Forms.ToolStripMenuItem SaveAsMenu;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem CloseMenu;
		private System.Windows.Forms.TabControl SHMDTabs;
		private System.Windows.Forms.TabPage GeneralTab;
		private System.Windows.Forms.TabPage SkyTab;
		private System.Windows.Forms.TabPage GroundObjectsTab;
		private System.Windows.Forms.TabPage MapObjectsTab;
		private System.Windows.Forms.PropertyGrid GeneralProperties;
		private System.Windows.Forms.ListBox SkyBox;
		private System.Windows.Forms.ListBox MapObjectsBox;
		private System.Windows.Forms.PropertyGrid MapObjectsProperties;
		private System.Windows.Forms.Button AddMapObjectButton;
		private System.Windows.Forms.TextBox AddMapObjectTextBox;
		private System.Windows.Forms.Button DeleteSelectedMapObjectButton;
		private System.Windows.Forms.Button DeleteSelectedSkyObjectButton;
		private System.Windows.Forms.Button AddSkyObjectButton;
		private System.Windows.Forms.TextBox AddSkyObjectTextBox;
		private System.Windows.Forms.TabPage WaterTab;
		private System.Windows.Forms.Button DeleteSelectedWaterObjectButton;
		private System.Windows.Forms.Button AddWaterObjectButton;
		private System.Windows.Forms.TextBox AddWaterObjectTextBox;
		private System.Windows.Forms.ListBox WaterBox;
		private System.Windows.Forms.Button DeleteSelectedGroundObjectButton;
		private System.Windows.Forms.Button AddGroundObjectButton;
		private System.Windows.Forms.TextBox AddGroundObjectTextBox;
		private System.Windows.Forms.ListBox GroundObjectsBox;
	}
}

