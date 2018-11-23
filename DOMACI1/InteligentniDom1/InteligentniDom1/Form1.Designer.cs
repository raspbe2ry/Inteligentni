namespace InteligentniDom1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.gbx2 = new System.Windows.Forms.GroupBox();
            this.rbn1 = new System.Windows.Forms.RadioButton();
            this.rbn2 = new System.Windows.Forms.RadioButton();
            this.tbx1 = new System.Windows.Forms.TextBox();
            this.tbx2 = new System.Windows.Forms.TextBox();
            this.tbx3 = new System.Windows.Forms.TextBox();
            this.tbx4 = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbx = new System.Windows.Forms.ListBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.tbx6 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.gbx2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl3);
            this.groupBox1.Controls.Add(this.tbx6);
            this.groupBox1.Controls.Add(this.lbx);
            this.groupBox1.Controls.Add(this.lbl1);
            this.groupBox1.Controls.Add(this.lbl2);
            this.groupBox1.Controls.Add(this.tbx4);
            this.groupBox1.Controls.Add(this.tbx3);
            this.groupBox1.Controls.Add(this.gbx2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 542);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuration";
            // 
            // dgv
            // 
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(367, 12);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 25;
            this.dgv.Size = new System.Drawing.Size(582, 542);
            this.dgv.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(62, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbx2
            // 
            this.gbx2.Controls.Add(this.tbx2);
            this.gbx2.Controls.Add(this.tbx1);
            this.gbx2.Controls.Add(this.rbn2);
            this.gbx2.Controls.Add(this.rbn1);
            this.gbx2.Location = new System.Drawing.Point(6, 30);
            this.gbx2.Name = "gbx2";
            this.gbx2.Size = new System.Drawing.Size(328, 101);
            this.gbx2.TabIndex = 3;
            this.gbx2.TabStop = false;
            this.gbx2.Text = "Decrementing";
            // 
            // rbn1
            // 
            this.rbn1.AutoSize = true;
            this.rbn1.Location = new System.Drawing.Point(71, 29);
            this.rbn1.Name = "rbn1";
            this.rbn1.Size = new System.Drawing.Size(50, 17);
            this.rbn1.TabIndex = 0;
            this.rbn1.TabStop = true;
            this.rbn1.Text = "Fixed";
            this.rbn1.UseVisualStyleBackColor = true;
            this.rbn1.CheckedChanged += new System.EventHandler(this.rbn1_CheckedChanged);
            // 
            // rbn2
            // 
            this.rbn2.AutoSize = true;
            this.rbn2.Location = new System.Drawing.Point(71, 61);
            this.rbn2.Name = "rbn2";
            this.rbn2.Size = new System.Drawing.Size(67, 17);
            this.rbn2.TabIndex = 1;
            this.rbn2.TabStop = true;
            this.rbn2.Text = "Factored";
            this.rbn2.UseVisualStyleBackColor = true;
            this.rbn2.CheckedChanged += new System.EventHandler(this.rbn2_CheckedChanged);
            // 
            // tbx1
            // 
            this.tbx1.Location = new System.Drawing.Point(164, 28);
            this.tbx1.Name = "tbx1";
            this.tbx1.Size = new System.Drawing.Size(100, 20);
            this.tbx1.TabIndex = 2;
            // 
            // tbx2
            // 
            this.tbx2.Location = new System.Drawing.Point(164, 58);
            this.tbx2.Name = "tbx2";
            this.tbx2.Size = new System.Drawing.Size(100, 20);
            this.tbx2.TabIndex = 3;
            // 
            // tbx3
            // 
            this.tbx3.Location = new System.Drawing.Point(170, 137);
            this.tbx3.Name = "tbx3";
            this.tbx3.Size = new System.Drawing.Size(100, 20);
            this.tbx3.TabIndex = 2;
            // 
            // tbx4
            // 
            this.tbx4.Location = new System.Drawing.Point(170, 179);
            this.tbx4.Name = "tbx4";
            this.tbx4.Size = new System.Drawing.Size(100, 20);
            this.tbx4.TabIndex = 4;
            this.tbx4.TextChanged += new System.EventHandler(this.tbx4_TextChanged_1);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(59, 182);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(92, 13);
            this.lbl2.TabIndex = 5;
            this.lbl2.Text = "Max. temperature:";
            this.lbl2.Click += new System.EventHandler(this.lbl2_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(59, 140);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(89, 13);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Min. temperature:";
            // 
            // lbx
            // 
            this.lbx.FormattingEnabled = true;
            this.lbx.Location = new System.Drawing.Point(16, 313);
            this.lbx.Name = "lbx";
            this.lbx.Size = new System.Drawing.Size(318, 212);
            this.lbx.TabIndex = 2;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(59, 223);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(78, 13);
            this.lbl3.TabIndex = 7;
            this.lbl3.Text = "Max. iterations:";
            this.lbl3.Click += new System.EventHandler(this.lbl3_Click);
            // 
            // tbx6
            // 
            this.tbx6.Location = new System.Drawing.Point(170, 220);
            this.tbx6.Name = "tbx6";
            this.tbx6.Size = new System.Drawing.Size(100, 20);
            this.tbx6.TabIndex = 6;
            this.tbx6.TextChanged += new System.EventHandler(this.tbx3_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 566);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.gbx2.ResumeLayout(false);
            this.gbx2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lbx;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox tbx4;
        private System.Windows.Forms.TextBox tbx3;
        private System.Windows.Forms.GroupBox gbx2;
        private System.Windows.Forms.TextBox tbx2;
        private System.Windows.Forms.TextBox tbx1;
        private System.Windows.Forms.RadioButton rbn2;
        private System.Windows.Forms.RadioButton rbn1;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.TextBox tbx6;
    }
}

