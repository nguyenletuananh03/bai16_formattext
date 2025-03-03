namespace bai16_formattext
{
    partial class Formattext
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
            this.txtnhapten = new System.Windows.Forms.TextBox();
            this.radRed = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radgreen = new System.Windows.Forms.RadioButton();
            this.radblue = new System.Windows.Forms.RadioButton();
            this.radblack = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkunderline = new System.Windows.Forms.CheckBox();
            this.chkBold = new System.Windows.Forms.CheckBox();
            this.chkitalic = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbllaptrinh = new System.Windows.Forms.Label();
            this.btnthoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(183, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập tên ";
            // 
            // txtnhapten
            // 
            this.txtnhapten.Location = new System.Drawing.Point(268, 34);
            this.txtnhapten.Name = "txtnhapten";
            this.txtnhapten.Size = new System.Drawing.Size(100, 20);
            this.txtnhapten.TabIndex = 1;
            this.txtnhapten.TextChanged += new System.EventHandler(this.txtnhapten_TextChanged);
            // 
            // radRed
            // 
            this.radRed.AutoSize = true;
            this.radRed.ForeColor = System.Drawing.Color.Red;
            this.radRed.Location = new System.Drawing.Point(9, 28);
            this.radRed.Name = "radRed";
            this.radRed.Size = new System.Drawing.Size(45, 17);
            this.radRed.TabIndex = 2;
            this.radRed.TabStop = true;
            this.radRed.Text = "Red";
            this.radRed.UseVisualStyleBackColor = true;
            this.radRed.CheckedChanged += new System.EventHandler(this.radRed_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.radblack);
            this.groupBox1.Controls.Add(this.radblue);
            this.groupBox1.Controls.Add(this.radgreen);
            this.groupBox1.Controls.Add(this.radRed);
            this.groupBox1.Location = new System.Drawing.Point(168, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(125, 133);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "color";
            // 
            // radgreen
            // 
            this.radgreen.AutoSize = true;
            this.radgreen.ForeColor = System.Drawing.Color.Lime;
            this.radgreen.Location = new System.Drawing.Point(9, 51);
            this.radgreen.Name = "radgreen";
            this.radgreen.Size = new System.Drawing.Size(54, 17);
            this.radgreen.TabIndex = 2;
            this.radgreen.TabStop = true;
            this.radgreen.Text = "Green";
            this.radgreen.UseVisualStyleBackColor = true;
            this.radgreen.CheckedChanged += new System.EventHandler(this.radgreen_CheckedChanged);
            // 
            // radblue
            // 
            this.radblue.AutoSize = true;
            this.radblue.ForeColor = System.Drawing.Color.Blue;
            this.radblue.Location = new System.Drawing.Point(9, 74);
            this.radblue.Name = "radblue";
            this.radblue.Size = new System.Drawing.Size(46, 17);
            this.radblue.TabIndex = 2;
            this.radblue.TabStop = true;
            this.radblue.Text = "Blue";
            this.radblue.UseVisualStyleBackColor = true;
            this.radblue.CheckedChanged += new System.EventHandler(this.radblue_CheckedChanged);
            // 
            // radblack
            // 
            this.radblack.AutoSize = true;
            this.radblack.Location = new System.Drawing.Point(9, 97);
            this.radblack.Name = "radblack";
            this.radblack.Size = new System.Drawing.Size(52, 17);
            this.radblack.TabIndex = 2;
            this.radblack.TabStop = true;
            this.radblack.Text = "Black";
            this.radblack.UseVisualStyleBackColor = true;
            this.radblack.CheckedChanged += new System.EventHandler(this.radblack_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.chkBold);
            this.groupBox2.Controls.Add(this.chkitalic);
            this.groupBox2.Controls.Add(this.chkunderline);
            this.groupBox2.Location = new System.Drawing.Point(373, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(148, 133);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "font";
            // 
            // chkunderline
            // 
            this.chkunderline.AutoSize = true;
            this.chkunderline.Location = new System.Drawing.Point(6, 74);
            this.chkunderline.Name = "chkunderline";
            this.chkunderline.Size = new System.Drawing.Size(80, 17);
            this.chkunderline.TabIndex = 0;
            this.chkunderline.Text = "gạch chân ";
            this.chkunderline.UseVisualStyleBackColor = true;
            this.chkunderline.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chkBold
            // 
            this.chkBold.AutoSize = true;
            this.chkBold.Location = new System.Drawing.Point(6, 28);
            this.chkBold.Name = "chkBold";
            this.chkBold.Size = new System.Drawing.Size(72, 17);
            this.chkBold.TabIndex = 0;
            this.chkBold.Text = "Đậm Bold";
            this.chkBold.UseVisualStyleBackColor = true;
            this.chkBold.CheckedChanged += new System.EventHandler(this.chkBold_CheckedChanged);
            // 
            // chkitalic
            // 
            this.chkitalic.AutoSize = true;
            this.chkitalic.Location = new System.Drawing.Point(6, 52);
            this.chkitalic.Name = "chkitalic";
            this.chkitalic.Size = new System.Drawing.Size(90, 17);
            this.chkitalic.TabIndex = 0;
            this.chkitalic.Text = "Nghiêng italic";
            this.chkitalic.UseVisualStyleBackColor = true;
            this.chkitalic.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(147, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "lập trình bởi :";
            // 
            // lbllaptrinh
            // 
            this.lbllaptrinh.AutoSize = true;
            this.lbllaptrinh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbllaptrinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbllaptrinh.Location = new System.Drawing.Point(279, 239);
            this.lbllaptrinh.Name = "lbllaptrinh";
            this.lbllaptrinh.Size = new System.Drawing.Size(51, 15);
            this.lbllaptrinh.TabIndex = 5;
            this.lbllaptrinh.Text = "tèo 2011";
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(396, 239);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(63, 20);
            this.btnthoat.TabIndex = 6;
            this.btnthoat.Text = "thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // Formattext
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.lbllaptrinh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtnhapten);
            this.Controls.Add(this.label1);
            this.Name = "Formattext";
            this.Text = "Formattext";
            this.Load += new System.EventHandler(this.Formattext_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnhapten;
        private System.Windows.Forms.RadioButton radRed;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radblack;
        private System.Windows.Forms.RadioButton radblue;
        private System.Windows.Forms.RadioButton radgreen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkBold;
        private System.Windows.Forms.CheckBox chkunderline;
        private System.Windows.Forms.CheckBox chkitalic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbllaptrinh;
        private System.Windows.Forms.Button btnthoat;
    }
}