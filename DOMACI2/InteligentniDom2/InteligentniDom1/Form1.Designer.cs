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
            this.lbx = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.tbx1 = new System.Windows.Forms.TextBox();
            this.lbx2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxx = new System.Windows.Forms.GroupBox();
            this.rbn1 = new System.Windows.Forms.RadioButton();
            this.rbn2 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.gbxx.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gbxx);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbx2);
            this.groupBox1.Controls.Add(this.lbx);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 629);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuration";
            // 
            // lbx
            // 
            this.lbx.FormattingEnabled = true;
            this.lbx.Location = new System.Drawing.Point(6, 216);
            this.lbx.Name = "lbx";
            this.lbx.Size = new System.Drawing.Size(328, 251);
            this.lbx.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.dgv.Size = new System.Drawing.Size(610, 629);
            this.dgv.TabIndex = 1;
            // 
            // tbx1
            // 
            this.tbx1.Location = new System.Drawing.Point(158, 41);
            this.tbx1.Name = "tbx1";
            this.tbx1.Size = new System.Drawing.Size(137, 20);
            this.tbx1.TabIndex = 5;
            this.tbx1.TextChanged += new System.EventHandler(this.tbx1_TextChanged);
            // 
            // lbx2
            // 
            this.lbx2.FormattingEnabled = true;
            this.lbx2.Location = new System.Drawing.Point(6, 506);
            this.lbx2.Name = "lbx2";
            this.lbx2.Size = new System.Drawing.Size(328, 108);
            this.lbx2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(85, 478);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "FINAL ROUTES";
            // 
            // gbxx
            // 
            this.gbxx.Controls.Add(this.rbn2);
            this.gbxx.Controls.Add(this.rbn1);
            this.gbxx.Controls.Add(this.tbx1);
            this.gbxx.Location = new System.Drawing.Point(6, 19);
            this.gbxx.Name = "gbxx";
            this.gbxx.Size = new System.Drawing.Size(328, 142);
            this.gbxx.TabIndex = 8;
            this.gbxx.TabStop = false;
            this.gbxx.Text = "Final goal";
            // 
            // rbn1
            // 
            this.rbn1.AutoSize = true;
            this.rbn1.Location = new System.Drawing.Point(30, 42);
            this.rbn1.Name = "rbn1";
            this.rbn1.Size = new System.Drawing.Size(101, 17);
            this.rbn1.TabIndex = 6;
            this.rbn1.TabStop = true;
            this.rbn1.Text = "Max. generation";
            this.rbn1.UseVisualStyleBackColor = true;
            this.rbn1.CheckedChanged += new System.EventHandler(this.rbn1_CheckedChanged_1);
            // 
            // rbn2
            // 
            this.rbn2.AutoSize = true;
            this.rbn2.Location = new System.Drawing.Point(30, 79);
            this.rbn2.Name = "rbn2";
            this.rbn2.Size = new System.Drawing.Size(114, 17);
            this.rbn2.TabIndex = 8;
            this.rbn2.TabStop = true;
            this.rbn2.Text = "Quality percentage";
            this.rbn2.UseVisualStyleBackColor = true;
            this.rbn2.CheckedChanged += new System.EventHandler(this.rbn2_CheckedChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 653);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.gbxx.ResumeLayout(false);
            this.gbxx.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lbx;
        private System.Windows.Forms.TextBox tbx1;
        private System.Windows.Forms.ListBox lbx2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxx;
        private System.Windows.Forms.RadioButton rbn2;
        private System.Windows.Forms.RadioButton rbn1;
    }
}

