namespace SHBDEditor
{
	partial class SHBDEditor
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SHBDEditor));
			this.MenuStrip = new System.Windows.Forms.MenuStrip();
			this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.NewSHBD = new System.Windows.Forms.ToolStripMenuItem();
			this.OpenMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.SaveMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.SaveAsMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.CloseMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.CreditsStrip = new System.Windows.Forms.StatusStrip();
			this.CreditsLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.ZoomBar = new System.Windows.Forms.TrackBar();
			this.isColoringWhite = new System.Windows.Forms.CheckBox();
			this.isColoringBlack = new System.Windows.Forms.CheckBox();
			this.PanelGroupBox = new System.Windows.Forms.Panel();
			this.PictureBox = new System.Windows.Forms.PictureBox();
			this.GroupBoxTools = new System.Windows.Forms.GroupBox();
			this.BrushSizeLabel = new System.Windows.Forms.Label();
			this.BrushSize = new System.Windows.Forms.NumericUpDown();
			this.MenuStrip.SuspendLayout();
			this.CreditsStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ZoomBar)).BeginInit();
			this.PanelGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
			this.GroupBoxTools.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.BrushSize)).BeginInit();
			this.SuspendLayout();
			// 
			// MenuStrip
			// 
			this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem});
			this.MenuStrip.Location = new System.Drawing.Point(0, 0);
			this.MenuStrip.Name = "MenuStrip";
			this.MenuStrip.Size = new System.Drawing.Size(600, 28);
			this.MenuStrip.TabIndex = 1;
			this.MenuStrip.Text = "menuStrip1";
			// 
			// FileMenuItem
			// 
			this.FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewSHBD,
            this.OpenMenu,
            this.SaveMenu,
            this.SaveAsMenu,
            this.toolStripSeparator1,
            this.CloseMenu});
			this.FileMenuItem.Name = "FileMenuItem";
			this.FileMenuItem.Size = new System.Drawing.Size(44, 24);
			this.FileMenuItem.Text = "File";
			// 
			// NewSHBD
			// 
			this.NewSHBD.Name = "NewSHBD";
			this.NewSHBD.Size = new System.Drawing.Size(225, 26);
			this.NewSHBD.Text = "New";
			// 
			// OpenMenu
			// 
			this.OpenMenu.Name = "OpenMenu";
			this.OpenMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.OpenMenu.Size = new System.Drawing.Size(225, 26);
			this.OpenMenu.Text = "Open";
			this.OpenMenu.Click += new System.EventHandler(this.OpenMenu_Click);
			// 
			// SaveMenu
			// 
			this.SaveMenu.Name = "SaveMenu";
			this.SaveMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.SaveMenu.Size = new System.Drawing.Size(225, 26);
			this.SaveMenu.Text = "Save";
			this.SaveMenu.Click += new System.EventHandler(this.SaveMenu_Click);
			// 
			// SaveAsMenu
			// 
			this.SaveAsMenu.Name = "SaveAsMenu";
			this.SaveAsMenu.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
			this.SaveAsMenu.Size = new System.Drawing.Size(225, 26);
			this.SaveAsMenu.Text = "Save As";
			this.SaveAsMenu.Click += new System.EventHandler(this.SaveAsMenu_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(222, 6);
			// 
			// CloseMenu
			// 
			this.CloseMenu.Name = "CloseMenu";
			this.CloseMenu.Size = new System.Drawing.Size(225, 26);
			this.CloseMenu.Text = "Close";
			this.CloseMenu.Click += new System.EventHandler(this.CloseMenu_Click);
			// 
			// CreditsStrip
			// 
			this.CreditsStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.CreditsStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreditsLabel});
			this.CreditsStrip.Location = new System.Drawing.Point(0, 661);
			this.CreditsStrip.Name = "CreditsStrip";
			this.CreditsStrip.Size = new System.Drawing.Size(600, 25);
			this.CreditsStrip.SizingGrip = false;
			this.CreditsStrip.Stretch = false;
			this.CreditsStrip.TabIndex = 6;
			this.CreditsStrip.Text = "CreditsStrip";
			// 
			// CreditsLabel
			// 
			this.CreditsLabel.Name = "CreditsLabel";
			this.CreditsLabel.Size = new System.Drawing.Size(150, 20);
			this.CreditsLabel.Text = "Created by Gherblino";
			// 
			// ZoomBar
			// 
			this.ZoomBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ZoomBar.LargeChange = 1;
			this.ZoomBar.Location = new System.Drawing.Point(0, 15);
			this.ZoomBar.Minimum = -10;
			this.ZoomBar.Name = "ZoomBar";
			this.ZoomBar.Size = new System.Drawing.Size(305, 56);
			this.ZoomBar.TabIndex = 7;
			this.ZoomBar.TickFrequency = 2;
			this.ZoomBar.Scroll += new System.EventHandler(this.ZoomBar_Scroll);
			// 
			// isColoringWhite
			// 
			this.isColoringWhite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.isColoringWhite.AutoSize = true;
			this.isColoringWhite.Checked = true;
			this.isColoringWhite.CheckState = System.Windows.Forms.CheckState.Checked;
			this.isColoringWhite.Location = new System.Drawing.Point(314, 13);
			this.isColoringWhite.Name = "isColoringWhite";
			this.isColoringWhite.Size = new System.Drawing.Size(66, 21);
			this.isColoringWhite.TabIndex = 9;
			this.isColoringWhite.Text = "White";
			this.isColoringWhite.UseVisualStyleBackColor = true;
			this.isColoringWhite.CheckedChanged += new System.EventHandler(this.IsColoringWhite_CheckedChanged);
			// 
			// isColoringBlack
			// 
			this.isColoringBlack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.isColoringBlack.AutoSize = true;
			this.isColoringBlack.Location = new System.Drawing.Point(314, 40);
			this.isColoringBlack.Name = "isColoringBlack";
			this.isColoringBlack.Size = new System.Drawing.Size(64, 21);
			this.isColoringBlack.TabIndex = 10;
			this.isColoringBlack.Text = "Black";
			this.isColoringBlack.UseVisualStyleBackColor = true;
			this.isColoringBlack.CheckedChanged += new System.EventHandler(this.IsColoringBlack_CheckedChanged);
			// 
			// PanelGroupBox
			// 
			this.PanelGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.PanelGroupBox.AutoScroll = true;
			this.PanelGroupBox.Controls.Add(this.PictureBox);
			this.PanelGroupBox.Location = new System.Drawing.Point(1, 35);
			this.PanelGroupBox.Name = "PanelGroupBox";
			this.PanelGroupBox.Size = new System.Drawing.Size(599, 543);
			this.PanelGroupBox.TabIndex = 0;
			// 
			// PictureBox
			// 
			this.PictureBox.Location = new System.Drawing.Point(0, 3);
			this.PictureBox.Name = "PictureBox";
			this.PictureBox.Size = new System.Drawing.Size(596, 540);
			this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.PictureBox.TabIndex = 0;
			this.PictureBox.TabStop = false;
			this.PictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox_Paint);
			this.PictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseDown);
			this.PictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseMove);
			this.PictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseUp);
			// 
			// GroupBoxTools
			// 
			this.GroupBoxTools.Controls.Add(this.BrushSizeLabel);
			this.GroupBoxTools.Controls.Add(this.BrushSize);
			this.GroupBoxTools.Controls.Add(this.ZoomBar);
			this.GroupBoxTools.Controls.Add(this.isColoringWhite);
			this.GroupBoxTools.Controls.Add(this.isColoringBlack);
			this.GroupBoxTools.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.GroupBoxTools.Location = new System.Drawing.Point(0, 584);
			this.GroupBoxTools.Name = "GroupBoxTools";
			this.GroupBoxTools.Size = new System.Drawing.Size(600, 77);
			this.GroupBoxTools.TabIndex = 12;
			this.GroupBoxTools.TabStop = false;
			// 
			// BrushSizeLabel
			// 
			this.BrushSizeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BrushSizeLabel.AutoSize = true;
			this.BrushSizeLabel.Location = new System.Drawing.Point(386, 14);
			this.BrushSizeLabel.Name = "BrushSizeLabel";
			this.BrushSizeLabel.Size = new System.Drawing.Size(76, 17);
			this.BrushSizeLabel.TabIndex = 12;
			this.BrushSizeLabel.Text = "Brush Size";
			// 
			// BrushSize
			// 
			this.BrushSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BrushSize.Location = new System.Drawing.Point(389, 39);
			this.BrushSize.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.BrushSize.Name = "BrushSize";
			this.BrushSize.Size = new System.Drawing.Size(73, 22);
			this.BrushSize.TabIndex = 11;
			this.BrushSize.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
			// 
			// SHBDEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(600, 686);
			this.Controls.Add(this.PanelGroupBox);
			this.Controls.Add(this.GroupBoxTools);
			this.Controls.Add(this.CreditsStrip);
			this.Controls.Add(this.MenuStrip);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.MenuStrip;
			this.Name = "SHBDEditor";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Fiesta SHBD Editor";
			this.Load += new System.EventHandler(this.SHBDEditor_Load);
			this.MenuStrip.ResumeLayout(false);
			this.MenuStrip.PerformLayout();
			this.CreditsStrip.ResumeLayout(false);
			this.CreditsStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ZoomBar)).EndInit();
			this.PanelGroupBox.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
			this.GroupBoxTools.ResumeLayout(false);
			this.GroupBoxTools.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.BrushSize)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.MenuStrip MenuStrip;
		private System.Windows.Forms.ToolStripMenuItem FileMenuItem;
		private System.Windows.Forms.ToolStripMenuItem OpenMenu;
		private System.Windows.Forms.ToolStripMenuItem SaveAsMenu;
		private System.Windows.Forms.StatusStrip CreditsStrip;
		private System.Windows.Forms.ToolStripStatusLabel CreditsLabel;
		private System.Windows.Forms.TrackBar ZoomBar;
		private System.Windows.Forms.CheckBox isColoringWhite;
		private System.Windows.Forms.CheckBox isColoringBlack;
		private System.Windows.Forms.GroupBox GroupBoxTools;
		private System.Windows.Forms.Panel PanelGroupBox;
		private System.Windows.Forms.PictureBox PictureBox;
		private System.Windows.Forms.Label BrushSizeLabel;
		private System.Windows.Forms.NumericUpDown BrushSize;
		private System.Windows.Forms.ToolStripMenuItem SaveMenu;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem CloseMenu;
		private System.Windows.Forms.ToolStripMenuItem NewSHBD;
	}
}

