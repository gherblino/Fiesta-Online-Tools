namespace DropTableEditor
{
    partial class frmOpenFile
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
            this.txtDropTable = new System.Windows.Forms.TextBox();
            this.btnBrowseDropTable = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBrowseDropGroup = new System.Windows.Forms.Button();
            this.txtDropGroup = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBrowseItemInfoServer = new System.Windows.Forms.Button();
            this.txtItemInfoServer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBrowseMobInfo = new System.Windows.Forms.Button();
            this.txtMobInfo = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDropTable
            // 
            this.txtDropTable.Location = new System.Drawing.Point(12, 30);
            this.txtDropTable.Name = "txtDropTable";
            this.txtDropTable.Size = new System.Drawing.Size(275, 20);
            this.txtDropTable.TabIndex = 0;
            // 
            // btnBrowseDropTable
            // 
            this.btnBrowseDropTable.Location = new System.Drawing.Point(293, 28);
            this.btnBrowseDropTable.Name = "btnBrowseDropTable";
            this.btnBrowseDropTable.Size = new System.Drawing.Size(40, 23);
            this.btnBrowseDropTable.TabIndex = 1;
            this.btnBrowseDropTable.Text = "...";
            this.btnBrowseDropTable.UseVisualStyleBackColor = true;
            this.btnBrowseDropTable.Click += new System.EventHandler(this.btnBrowseDropTable_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ItemDropTable.txt";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "ItemDropGroup.txt";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnBrowseDropGroup
            // 
            this.btnBrowseDropGroup.Location = new System.Drawing.Point(293, 74);
            this.btnBrowseDropGroup.Name = "btnBrowseDropGroup";
            this.btnBrowseDropGroup.Size = new System.Drawing.Size(40, 23);
            this.btnBrowseDropGroup.TabIndex = 4;
            this.btnBrowseDropGroup.Text = "...";
            this.btnBrowseDropGroup.UseVisualStyleBackColor = true;
            this.btnBrowseDropGroup.Click += new System.EventHandler(this.btnBrowseDropGroup_Click);
            // 
            // txtDropGroup
            // 
            this.txtDropGroup.Location = new System.Drawing.Point(12, 76);
            this.txtDropGroup.Name = "txtDropGroup";
            this.txtDropGroup.Size = new System.Drawing.Size(275, 20);
            this.txtDropGroup.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(321, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "ItemInfoServer.shn";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnBrowseItemInfoServer
            // 
            this.btnBrowseItemInfoServer.Location = new System.Drawing.Point(293, 121);
            this.btnBrowseItemInfoServer.Name = "btnBrowseItemInfoServer";
            this.btnBrowseItemInfoServer.Size = new System.Drawing.Size(40, 23);
            this.btnBrowseItemInfoServer.TabIndex = 7;
            this.btnBrowseItemInfoServer.Text = "...";
            this.btnBrowseItemInfoServer.UseVisualStyleBackColor = true;
            this.btnBrowseItemInfoServer.Click += new System.EventHandler(this.btnBrowseItemInfoServer_Click);
            // 
            // txtItemInfoServer
            // 
            this.txtItemInfoServer.Location = new System.Drawing.Point(12, 123);
            this.txtItemInfoServer.Name = "txtItemInfoServer";
            this.txtItemInfoServer.Size = new System.Drawing.Size(275, 20);
            this.txtItemInfoServer.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(321, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "MobInfo.shn";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnBrowseMobInfo
            // 
            this.btnBrowseMobInfo.Location = new System.Drawing.Point(293, 167);
            this.btnBrowseMobInfo.Name = "btnBrowseMobInfo";
            this.btnBrowseMobInfo.Size = new System.Drawing.Size(40, 23);
            this.btnBrowseMobInfo.TabIndex = 10;
            this.btnBrowseMobInfo.Text = "...";
            this.btnBrowseMobInfo.UseVisualStyleBackColor = true;
            this.btnBrowseMobInfo.Click += new System.EventHandler(this.btnBrowseMobInfo_Click);
            // 
            // txtMobInfo
            // 
            this.txtMobInfo.Location = new System.Drawing.Point(12, 169);
            this.txtMobInfo.Name = "txtMobInfo";
            this.txtMobInfo.Size = new System.Drawing.Size(275, 20);
            this.txtMobInfo.TabIndex = 9;
            // 
            // btnOpen
            // 
            this.btnOpen.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOpen.Location = new System.Drawing.Point(239, 211);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(94, 23);
            this.btnOpen.TabIndex = 12;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // frmOpenFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(345, 246);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBrowseMobInfo);
            this.Controls.Add(this.txtMobInfo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBrowseItemInfoServer);
            this.Controls.Add(this.txtItemInfoServer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBrowseDropGroup);
            this.Controls.Add(this.txtDropGroup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBrowseDropTable);
            this.Controls.Add(this.txtDropTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmOpenFile";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Open";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDropTable;
        private System.Windows.Forms.Button btnBrowseDropTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBrowseDropGroup;
        private System.Windows.Forms.TextBox txtDropGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBrowseItemInfoServer;
        private System.Windows.Forms.TextBox txtItemInfoServer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBrowseMobInfo;
        private System.Windows.Forms.TextBox txtMobInfo;
        private System.Windows.Forms.Button btnOpen;
    }
}