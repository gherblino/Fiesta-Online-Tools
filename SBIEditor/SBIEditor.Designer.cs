namespace SBIEditor
{
    partial class SBIEditor
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SBIEditor));
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SaveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SaveAsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.elementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AddNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.DoorsGroupBox = new System.Windows.Forms.GroupBox();
			this.DoorPropertyGrid = new System.Windows.Forms.PropertyGrid();
			this.DoorsListBox = new System.Windows.Forms.ListBox();
			this.CreditsStrip = new System.Windows.Forms.StatusStrip();
			this.CreditsLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.PictureBoxPanel = new System.Windows.Forms.Panel();
			this.PictureBox = new System.Windows.Forms.PictureBox();
			this.menuStrip.SuspendLayout();
			this.DoorsGroupBox.SuspendLayout();
			this.CreditsStrip.SuspendLayout();
			this.PictureBoxPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip
			// 
			this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.elementToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
			this.menuStrip.Size = new System.Drawing.Size(1540, 48);
			this.menuStrip.TabIndex = 10;
			this.menuStrip.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.SaveMenuItem,
            this.SaveAsMenuItem,
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
			this.openToolStripMenuItem.Size = new System.Drawing.Size(377, 44);
			this.openToolStripMenuItem.Text = "Open";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
			// 
			// SaveMenuItem
			// 
			this.SaveMenuItem.Name = "SaveMenuItem";
			this.SaveMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.SaveMenuItem.Size = new System.Drawing.Size(377, 44);
			this.SaveMenuItem.Text = "Save";
			this.SaveMenuItem.Click += new System.EventHandler(this.SaveMenuItem_Click);
			// 
			// SaveAsMenuItem
			// 
			this.SaveAsMenuItem.Name = "SaveAsMenuItem";
			this.SaveAsMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
			this.SaveAsMenuItem.Size = new System.Drawing.Size(377, 44);
			this.SaveAsMenuItem.Text = "Save As";
			this.SaveAsMenuItem.Click += new System.EventHandler(this.SaveAsMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(374, 6);
			// 
			// closeToolStripMenuItem
			// 
			this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
			this.closeToolStripMenuItem.Size = new System.Drawing.Size(377, 44);
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
			this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
			// 
			// DoorsGroupBox
			// 
			this.DoorsGroupBox.Controls.Add(this.DoorPropertyGrid);
			this.DoorsGroupBox.Controls.Add(this.DoorsListBox);
			this.DoorsGroupBox.Dock = System.Windows.Forms.DockStyle.Right;
			this.DoorsGroupBox.Location = new System.Drawing.Point(1171, 48);
			this.DoorsGroupBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.DoorsGroupBox.Name = "DoorsGroupBox";
			this.DoorsGroupBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.DoorsGroupBox.Size = new System.Drawing.Size(369, 1007);
			this.DoorsGroupBox.TabIndex = 13;
			this.DoorsGroupBox.TabStop = false;
			this.DoorsGroupBox.Text = "Doors";
			this.DoorsGroupBox.Visible = false;
			// 
			// DoorPropertyGrid
			// 
			this.DoorPropertyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.DoorPropertyGrid.Location = new System.Drawing.Point(0, 372);
			this.DoorPropertyGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.DoorPropertyGrid.Name = "DoorPropertyGrid";
			this.DoorPropertyGrid.PropertySort = System.Windows.Forms.PropertySort.NoSort;
			this.DoorPropertyGrid.Size = new System.Drawing.Size(360, 635);
			this.DoorPropertyGrid.TabIndex = 0;
			this.DoorPropertyGrid.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.DoorPropertyGrid_PropertyValueChanged);
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
			// CreditsStrip
			// 
			this.CreditsStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.CreditsStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreditsLabel});
			this.CreditsStrip.Location = new System.Drawing.Point(0, 1013);
			this.CreditsStrip.Name = "CreditsStrip";
			this.CreditsStrip.Padding = new System.Windows.Forms.Padding(2, 0, 20, 0);
			this.CreditsStrip.Size = new System.Drawing.Size(1171, 42);
			this.CreditsStrip.SizingGrip = false;
			this.CreditsStrip.Stretch = false;
			this.CreditsStrip.TabIndex = 15;
			this.CreditsStrip.Text = "CreditsStrip";
			// 
			// CreditsLabel
			// 
			this.CreditsLabel.Name = "CreditsLabel";
			this.CreditsLabel.Size = new System.Drawing.Size(243, 32);
			this.CreditsLabel.Text = "Created by Gherblino";
			// 
			// PictureBoxPanel
			// 
			this.PictureBoxPanel.AutoScroll = true;
			this.PictureBoxPanel.Controls.Add(this.PictureBox);
			this.PictureBoxPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PictureBoxPanel.Location = new System.Drawing.Point(0, 48);
			this.PictureBoxPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.PictureBoxPanel.Name = "PictureBoxPanel";
			this.PictureBoxPanel.Size = new System.Drawing.Size(1171, 965);
			this.PictureBoxPanel.TabIndex = 16;
			// 
			// PictureBox
			// 
			this.PictureBox.Location = new System.Drawing.Point(4, 0);
			this.PictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.PictureBox.Name = "PictureBox";
			this.PictureBox.Size = new System.Drawing.Size(1162, 967);
			this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PictureBox.TabIndex = 13;
			this.PictureBox.TabStop = false;
			this.PictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseMove);
			// 
			// SBIEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1540, 1055);
			this.Controls.Add(this.PictureBoxPanel);
			this.Controls.Add(this.CreditsStrip);
			this.Controls.Add(this.DoorsGroupBox);
			this.Controls.Add(this.menuStrip);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "SBIEditor";
			this.Text = "SBI Editor";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SBIEditor_KeyDown);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.DoorsGroupBox.ResumeLayout(false);
			this.CreditsStrip.ResumeLayout(false);
			this.CreditsStrip.PerformLayout();
			this.PictureBoxPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAsMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.GroupBox DoorsGroupBox;
        private System.Windows.Forms.PropertyGrid DoorPropertyGrid;
        private System.Windows.Forms.ListBox DoorsListBox;
        private System.Windows.Forms.StatusStrip CreditsStrip;
        private System.Windows.Forms.ToolStripStatusLabel CreditsLabel;
        private System.Windows.Forms.Panel PictureBoxPanel;
        private System.Windows.Forms.PictureBox PictureBox;
    }
}

