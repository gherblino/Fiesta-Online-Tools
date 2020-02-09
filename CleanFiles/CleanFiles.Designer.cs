namespace CleanFiles
{
    partial class CleanFiles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CleanFiles));
            this.IsCleaningClient = new System.Windows.Forms.CheckBox();
            this.IsCleaningServer = new System.Windows.Forms.CheckBox();
            this.CleanButton = new System.Windows.Forms.Button();
            this.LogBox = new System.Windows.Forms.TextBox();
            this.MarkButton = new System.Windows.Forms.Button();
            this.CreditsStrip = new System.Windows.Forms.StatusStrip();
            this.CreditsLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.CreditsStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // IsCleaningClient
            // 
            this.IsCleaningClient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.IsCleaningClient.AutoSize = true;
            this.IsCleaningClient.Location = new System.Drawing.Point(194, 26);
            this.IsCleaningClient.Name = "IsCleaningClient";
            this.IsCleaningClient.Size = new System.Drawing.Size(105, 21);
            this.IsCleaningClient.TabIndex = 0;
            this.IsCleaningClient.Text = "Clean Client";
            this.IsCleaningClient.UseVisualStyleBackColor = true;
            this.IsCleaningClient.CheckedChanged += new System.EventHandler(this.IsCleaningClient_CheckedChanged);
            // 
            // IsCleaningServer
            // 
            this.IsCleaningServer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.IsCleaningServer.AutoSize = true;
            this.IsCleaningServer.Location = new System.Drawing.Point(194, 53);
            this.IsCleaningServer.Name = "IsCleaningServer";
            this.IsCleaningServer.Size = new System.Drawing.Size(112, 21);
            this.IsCleaningServer.TabIndex = 1;
            this.IsCleaningServer.Text = "Clean Server";
            this.IsCleaningServer.UseVisualStyleBackColor = true;
            this.IsCleaningServer.CheckedChanged += new System.EventHandler(this.IsCleaningServer_CheckedChanged);
            // 
            // CleanButton
            // 
            this.CleanButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CleanButton.Location = new System.Drawing.Point(261, 95);
            this.CleanButton.Name = "CleanButton";
            this.CleanButton.Size = new System.Drawing.Size(105, 35);
            this.CleanButton.TabIndex = 2;
            this.CleanButton.Text = "Clean";
            this.CleanButton.UseVisualStyleBackColor = true;
            this.CleanButton.Click += new System.EventHandler(this.CleanButton_Click);
            // 
            // LogBox
            // 
            this.LogBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogBox.Location = new System.Drawing.Point(50, 136);
            this.LogBox.Multiline = true;
            this.LogBox.Name = "LogBox";
            this.LogBox.ReadOnly = true;
            this.LogBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.LogBox.Size = new System.Drawing.Size(401, 171);
            this.LogBox.TabIndex = 3;
            // 
            // MarkButton
            // 
            this.MarkButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MarkButton.Location = new System.Drawing.Point(131, 95);
            this.MarkButton.Name = "MarkButton";
            this.MarkButton.Size = new System.Drawing.Size(105, 35);
            this.MarkButton.TabIndex = 4;
            this.MarkButton.Text = "Mark";
            this.MarkButton.UseVisualStyleBackColor = true;
            this.MarkButton.Click += new System.EventHandler(this.MarkButton_Click);
            // 
            // CreditsStrip
            // 
            this.CreditsStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CreditsStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreditsLabel});
            this.CreditsStrip.Location = new System.Drawing.Point(0, 348);
            this.CreditsStrip.Name = "CreditsStrip";
            this.CreditsStrip.Size = new System.Drawing.Size(502, 25);
            this.CreditsStrip.SizingGrip = false;
            this.CreditsStrip.Stretch = false;
            this.CreditsStrip.TabIndex = 5;
            this.CreditsStrip.Text = "CreditsStrip";
            // 
            // CreditsLabel
            // 
            this.CreditsLabel.Name = "CreditsLabel";
            this.CreditsLabel.Size = new System.Drawing.Size(150, 20);
            this.CreditsLabel.Text = "Created by Gherblino";
            // 
            // ProgressBar
            // 
            this.ProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgressBar.Location = new System.Drawing.Point(50, 313);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(401, 23);
            this.ProgressBar.TabIndex = 6;
            // 
            // Clean
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(502, 373);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.CreditsStrip);
            this.Controls.Add(this.MarkButton);
            this.Controls.Add(this.LogBox);
            this.Controls.Add(this.CleanButton);
            this.Controls.Add(this.IsCleaningServer);
            this.Controls.Add(this.IsCleaningClient);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(380, 415);
            this.Name = "CleanFiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fiesta Cleaning Tool";
            this.Load += new System.EventHandler(this.CleanFiles_Load);
            this.CreditsStrip.ResumeLayout(false);
            this.CreditsStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox IsCleaningClient;
        private System.Windows.Forms.CheckBox IsCleaningServer;
        private System.Windows.Forms.Button CleanButton;
        private System.Windows.Forms.TextBox LogBox;
        private System.Windows.Forms.Button MarkButton;
		private System.Windows.Forms.StatusStrip CreditsStrip;
		private System.Windows.Forms.ToolStripStatusLabel CreditsLabel;
		private System.Windows.Forms.ProgressBar ProgressBar;
	}
}

