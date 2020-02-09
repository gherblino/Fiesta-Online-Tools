namespace DropTableEditor.Tools
{
    partial class frmAddToAll
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtGroup = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudMaxLevel = new System.Windows.Forms.NumericUpDown();
            this.nudMinLevel = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nudDropRate = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDropRate)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdd.Location = new System.Drawing.Point(198, 39);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtGroup
            // 
            this.txtGroup.Location = new System.Drawing.Point(46, 8);
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.Size = new System.Drawing.Size(117, 20);
            this.txtGroup.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Group:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nudMaxLevel);
            this.groupBox1.Controls.Add(this.nudMinLevel);
            this.groupBox1.Location = new System.Drawing.Point(10, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 49);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Between Levels";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "&&";
            // 
            // nudMaxLevel
            // 
            this.nudMaxLevel.Location = new System.Drawing.Point(100, 19);
            this.nudMaxLevel.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudMaxLevel.Name = "nudMaxLevel";
            this.nudMaxLevel.Size = new System.Drawing.Size(53, 20);
            this.nudMaxLevel.TabIndex = 0;
            this.nudMaxLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudMaxLevel.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // nudMinLevel
            // 
            this.nudMinLevel.Location = new System.Drawing.Point(25, 19);
            this.nudMinLevel.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudMinLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMinLevel.Name = "nudMinLevel";
            this.nudMinLevel.Size = new System.Drawing.Size(53, 20);
            this.nudMinLevel.TabIndex = 0;
            this.nudMinLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudMinLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMinLevel.ValueChanged += new System.EventHandler(this.nudMinLevel_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(262, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "%";
            // 
            // nudDropRate
            // 
            this.nudDropRate.DecimalPlaces = 5;
            this.nudDropRate.Location = new System.Drawing.Point(205, 8);
            this.nudDropRate.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudDropRate.Name = "nudDropRate";
            this.nudDropRate.Size = new System.Drawing.Size(58, 20);
            this.nudDropRate.TabIndex = 17;
            this.nudDropRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudDropRate.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(165, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Rate:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmAddToAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(285, 92);
            this.Controls.Add(this.nudDropRate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGroup);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmAddToAll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mass Group Add";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDropRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudMaxLevel;
        private System.Windows.Forms.NumericUpDown nudMinLevel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudDropRate;
        private System.Windows.Forms.Label label4;
    }
}