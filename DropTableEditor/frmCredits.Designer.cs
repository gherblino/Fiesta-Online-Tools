namespace DropTableEditor
{
	partial class frmCredits
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCredits));
			this.CreditsBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// CreditsBox
			// 
			this.CreditsBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.CreditsBox.Location = new System.Drawing.Point(0, 0);
			this.CreditsBox.Multiline = true;
			this.CreditsBox.Name = "CreditsBox";
			this.CreditsBox.ReadOnly = true;
			this.CreditsBox.Size = new System.Drawing.Size(411, 112);
			this.CreditsBox.TabIndex = 0;
			this.CreditsBox.TabStop = false;
			this.CreditsBox.Text = "Credits to Wicious for the original code\r\nCredits to Gherblino for updating the t" +
    "ool to work with 2015-2016 files";
			// 
			// frmCredits
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(411, 112);
			this.Controls.Add(this.CreditsBox);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmCredits";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Credits";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox CreditsBox;
	}
}