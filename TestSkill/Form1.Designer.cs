namespace TestSkill
{
    partial class Form1
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
            this.JheadderLB = new System.Windows.Forms.Label();
            this.VheaderLB = new System.Windows.Forms.Label();
            this.UnitLB = new System.Windows.Forms.Label();
            this.MinLB = new System.Windows.Forms.Label();
            this.MaxLB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtJHeader = new System.Windows.Forms.TextBox();
            this.txtVHeader = new System.Windows.Forms.TextBox();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.cbMode = new System.Windows.Forms.ComboBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // JheadderLB
            // 
            this.JheadderLB.AutoSize = true;
            this.JheadderLB.Location = new System.Drawing.Point(15, 12);
            this.JheadderLB.Name = "JheadderLB";
            this.JheadderLB.Size = new System.Drawing.Size(60, 16);
            this.JheadderLB.TabIndex = 0;
            this.JheadderLB.Text = "JHeader";
            // 
            // VheaderLB
            // 
            this.VheaderLB.AutoSize = true;
            this.VheaderLB.Location = new System.Drawing.Point(15, 49);
            this.VheaderLB.Name = "VheaderLB";
            this.VheaderLB.Size = new System.Drawing.Size(62, 16);
            this.VheaderLB.TabIndex = 1;
            this.VheaderLB.Text = "VHeader";
            // 
            // UnitLB
            // 
            this.UnitLB.AutoSize = true;
            this.UnitLB.Location = new System.Drawing.Point(15, 85);
            this.UnitLB.Name = "UnitLB";
            this.UnitLB.Size = new System.Drawing.Size(30, 16);
            this.UnitLB.TabIndex = 2;
            this.UnitLB.Text = "Unit";
            // 
            // MinLB
            // 
            this.MinLB.AutoSize = true;
            this.MinLB.Location = new System.Drawing.Point(15, 122);
            this.MinLB.Name = "MinLB";
            this.MinLB.Size = new System.Drawing.Size(28, 16);
            this.MinLB.TabIndex = 3;
            this.MinLB.Text = "Min";
            // 
            // MaxLB
            // 
            this.MaxLB.AutoSize = true;
            this.MaxLB.Location = new System.Drawing.Point(15, 158);
            this.MaxLB.Name = "MaxLB";
            this.MaxLB.Size = new System.Drawing.Size(32, 16);
            this.MaxLB.TabIndex = 4;
            this.MaxLB.Text = "Max";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mode";
            // 
            // txtJHeader
            // 
            this.txtJHeader.Location = new System.Drawing.Point(86, 9);
            this.txtJHeader.Name = "txtJHeader";
            this.txtJHeader.Size = new System.Drawing.Size(399, 22);
            this.txtJHeader.TabIndex = 6;
            // 
            // txtVHeader
            // 
            this.txtVHeader.Location = new System.Drawing.Point(86, 46);
            this.txtVHeader.Name = "txtVHeader";
            this.txtVHeader.Size = new System.Drawing.Size(399, 22);
            this.txtVHeader.TabIndex = 7;
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(86, 82);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(399, 22);
            this.txtUnit.TabIndex = 8;
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(86, 119);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(399, 22);
            this.txtMin.TabIndex = 9;
            this.txtMin.TextChanged += new System.EventHandler(this.txtMin_TextChanged);
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(86, 155);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(399, 22);
            this.txtMax.TabIndex = 10;
            this.txtMax.TextChanged += new System.EventHandler(this.txtMax_TextChanged);
            // 
            // cbMode
            // 
            this.cbMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMode.FormattingEnabled = true;
            this.cbMode.Items.AddRange(new object[] {
            "O",
            "X"});
            this.cbMode.Location = new System.Drawing.Point(86, 193);
            this.cbMode.Name = "cbMode";
            this.cbMode.Size = new System.Drawing.Size(399, 24);
            this.cbMode.TabIndex = 11;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(410, 226);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 31);
            this.btnSend.TabIndex = 12;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 265);
            this.Controls.Add(this.btnSend);
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label JheadderLB;
        private System.Windows.Forms.Label VheaderLB;
        private System.Windows.Forms.Label UnitLB;
        private System.Windows.Forms.Label MinLB;
        private System.Windows.Forms.Label MaxLB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtJHeader;
        private System.Windows.Forms.TextBox txtVHeader;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.ComboBox cbMode;
        private System.Windows.Forms.Button btnSend;
    }
}

