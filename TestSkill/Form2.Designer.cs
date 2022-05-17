namespace TestSkill
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.MaxLB = new System.Windows.Forms.Label();
            this.MinLB = new System.Windows.Forms.Label();
            this.UnitLB = new System.Windows.Forms.Label();
            this.VheaderLB = new System.Windows.Forms.Label();
            this.JheadderLB = new System.Windows.Forms.Label();
            this.cbMode = new System.Windows.Forms.ComboBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.txtVHeader = new System.Windows.Forms.TextBox();
            this.txtJHeader = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mode";
            // 
            // MaxLB
            // 
            this.MaxLB.AutoSize = true;
            this.MaxLB.Location = new System.Drawing.Point(12, 155);
            this.MaxLB.Name = "MaxLB";
            this.MaxLB.Size = new System.Drawing.Size(32, 16);
            this.MaxLB.TabIndex = 10;
            this.MaxLB.Text = "Max";
            // 
            // MinLB
            // 
            this.MinLB.AutoSize = true;
            this.MinLB.Location = new System.Drawing.Point(12, 119);
            this.MinLB.Name = "MinLB";
            this.MinLB.Size = new System.Drawing.Size(28, 16);
            this.MinLB.TabIndex = 9;
            this.MinLB.Text = "Min";
            // 
            // UnitLB
            // 
            this.UnitLB.AutoSize = true;
            this.UnitLB.Location = new System.Drawing.Point(12, 82);
            this.UnitLB.Name = "UnitLB";
            this.UnitLB.Size = new System.Drawing.Size(30, 16);
            this.UnitLB.TabIndex = 8;
            this.UnitLB.Text = "Unit";
            // 
            // VheaderLB
            // 
            this.VheaderLB.AutoSize = true;
            this.VheaderLB.Location = new System.Drawing.Point(12, 46);
            this.VheaderLB.Name = "VheaderLB";
            this.VheaderLB.Size = new System.Drawing.Size(62, 16);
            this.VheaderLB.TabIndex = 7;
            this.VheaderLB.Text = "VHeader";
            // 
            // JheadderLB
            // 
            this.JheadderLB.AutoSize = true;
            this.JheadderLB.Location = new System.Drawing.Point(12, 9);
            this.JheadderLB.Name = "JheadderLB";
            this.JheadderLB.Size = new System.Drawing.Size(60, 16);
            this.JheadderLB.TabIndex = 6;
            this.JheadderLB.Text = "JHeader";
            // 
            // cbMode
            // 
            this.cbMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMode.FormattingEnabled = true;
            this.cbMode.Items.AddRange(new object[] {
            "O",
            "X"});
            this.cbMode.Location = new System.Drawing.Point(88, 190);
            this.cbMode.Name = "cbMode";
            this.cbMode.Size = new System.Drawing.Size(399, 24);
            this.cbMode.TabIndex = 17;
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(88, 152);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(399, 22);
            this.txtMax.TabIndex = 16;
            this.txtMax.TextChanged += new System.EventHandler(this.txtMax_TextChanged);
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(88, 116);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(399, 22);
            this.txtMin.TabIndex = 15;
            this.txtMin.TextChanged += new System.EventHandler(this.txtMin_TextChanged);
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(88, 79);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(399, 22);
            this.txtUnit.TabIndex = 14;
            // 
            // txtVHeader
            // 
            this.txtVHeader.Location = new System.Drawing.Point(88, 43);
            this.txtVHeader.Name = "txtVHeader";
            this.txtVHeader.Size = new System.Drawing.Size(399, 22);
            this.txtVHeader.TabIndex = 13;
            // 
            // txtJHeader
            // 
            this.txtJHeader.Location = new System.Drawing.Point(88, 6);
            this.txtJHeader.Name = "txtJHeader";
            this.txtJHeader.Size = new System.Drawing.Size(399, 22);
            this.txtJHeader.TabIndex = 12;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(412, 223);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 29);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 260);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.cbMode);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.txtVHeader);
            this.Controls.Add(this.txtJHeader);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MaxLB);
            this.Controls.Add(this.MinLB);
            this.Controls.Add(this.UnitLB);
            this.Controls.Add(this.VheaderLB);
            this.Controls.Add(this.JheadderLB);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MaxLB;
        private System.Windows.Forms.Label MinLB;
        private System.Windows.Forms.Label UnitLB;
        private System.Windows.Forms.Label VheaderLB;
        private System.Windows.Forms.Label JheadderLB;
        private System.Windows.Forms.ComboBox cbMode;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.TextBox txtVHeader;
        private System.Windows.Forms.TextBox txtJHeader;
        private System.Windows.Forms.Button btnUpdate;
    }
}