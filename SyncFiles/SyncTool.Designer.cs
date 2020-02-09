namespace SyncFiles
{
	partial class Sync
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sync));
            this.SyncShine = new System.Windows.Forms.Button();
            this.LogBox = new System.Windows.Forms.TextBox();
            this.SyncRessystem = new System.Windows.Forms.Button();
            this.ScanFiles = new System.Windows.Forms.Button();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectRessystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectShineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.useDefaultPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.CreditsStrip = new System.Windows.Forms.StatusStrip();
            this.CreditsLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.MenuStrip.SuspendLayout();
            this.CreditsStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // SyncShine
            // 
            this.SyncShine.Location = new System.Drawing.Point(259, 82);
            this.SyncShine.Name = "SyncShine";
            this.SyncShine.Size = new System.Drawing.Size(172, 38);
            this.SyncShine.TabIndex = 1;
            this.SyncShine.Text = "Sync Shine";
            this.SyncShine.UseVisualStyleBackColor = true;
            // 
            // LogBox
            // 
            this.LogBox.Location = new System.Drawing.Point(46, 153);
            this.LogBox.Multiline = true;
            this.LogBox.Name = "LogBox";
            this.LogBox.ReadOnly = true;
            this.LogBox.Size = new System.Drawing.Size(385, 172);
            this.LogBox.TabIndex = 0;
            // 
            // SyncRessystem
            // 
            this.SyncRessystem.Location = new System.Drawing.Point(259, 38);
            this.SyncRessystem.Name = "SyncRessystem";
            this.SyncRessystem.Size = new System.Drawing.Size(172, 38);
            this.SyncRessystem.TabIndex = 2;
            this.SyncRessystem.Text = "Sync Ressystem";
            this.SyncRessystem.UseVisualStyleBackColor = true;
            // 
            // ScanFiles
            // 
            this.ScanFiles.Location = new System.Drawing.Point(46, 38);
            this.ScanFiles.Name = "ScanFiles";
            this.ScanFiles.Size = new System.Drawing.Size(172, 82);
            this.ScanFiles.TabIndex = 3;
            this.ScanFiles.Text = "Scan Files";
            this.ScanFiles.UseVisualStyleBackColor = true;
            // 
            // MenuStrip
            // 
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(488, 28);
            this.MenuStrip.TabIndex = 4;
            this.MenuStrip.Text = "MenuStrip";
            this.MenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectRessystemToolStripMenuItem,
            this.selectShineToolStripMenuItem,
            this.toolStripMenuItem1,
            this.useDefaultPathToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // selectRessystemToolStripMenuItem
            // 
            this.selectRessystemToolStripMenuItem.Name = "selectRessystemToolStripMenuItem";
            this.selectRessystemToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.selectRessystemToolStripMenuItem.Text = "Select ressystem";
            this.selectRessystemToolStripMenuItem.Click += new System.EventHandler(this.selectRessystemToolStripMenuItem_Click);
            // 
            // selectShineToolStripMenuItem
            // 
            this.selectShineToolStripMenuItem.Name = "selectShineToolStripMenuItem";
            this.selectShineToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.selectShineToolStripMenuItem.Text = "Select Shine";
            this.selectShineToolStripMenuItem.Click += new System.EventHandler(this.selectShineToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(190, 6);
            // 
            // useDefaultPathToolStripMenuItem
            // 
            this.useDefaultPathToolStripMenuItem.Name = "useDefaultPathToolStripMenuItem";
            this.useDefaultPathToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.useDefaultPathToolStripMenuItem.Text = "Use Default Path";
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(46, 327);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(385, 23);
            this.ProgressBar.TabIndex = 5;
            // 
            // CreditsStrip
            // 
            this.CreditsStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CreditsStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreditsLabel});
            this.CreditsStrip.Location = new System.Drawing.Point(0, 367);
            this.CreditsStrip.Name = "CreditsStrip";
            this.CreditsStrip.Size = new System.Drawing.Size(488, 25);
            this.CreditsStrip.SizingGrip = false;
            this.CreditsStrip.TabIndex = 6;
            this.CreditsStrip.Tag = "";
            this.CreditsStrip.Text = "CreditsStrip";
            // 
            // CreditsLabel
            // 
            this.CreditsLabel.Name = "CreditsLabel";
            this.CreditsLabel.Size = new System.Drawing.Size(150, 20);
            this.CreditsLabel.Text = "Created by Gherblino";
            // 
            // Sync
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 392);
            this.Controls.Add(this.CreditsStrip);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.ScanFiles);
            this.Controls.Add(this.SyncRessystem);
            this.Controls.Add(this.SyncShine);
            this.Controls.Add(this.LogBox);
            this.Controls.Add(this.MenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Sync";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fiesta Sync Tool";
            this.Load += new System.EventHandler(this.Sync_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.CreditsStrip.ResumeLayout(false);
            this.CreditsStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SyncShine;
        private System.Windows.Forms.TextBox LogBox;
        private System.Windows.Forms.Button SyncRessystem;
        private System.Windows.Forms.Button ScanFiles;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectRessystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectShineToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem useDefaultPathToolStripMenuItem;
		private System.Windows.Forms.ProgressBar ProgressBar;
		private System.Windows.Forms.StatusStrip CreditsStrip;
		private System.Windows.Forms.ToolStripStatusLabel CreditsLabel;
		private System.ServiceProcess.ServiceController serviceController1;
	}
}

