namespace BTWindownForm2
{
    partial class frmBai3
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNhapHo = new System.Windows.Forms.TextBox();
            this.tbNhapTen = new System.Windows.Forms.TextBox();
            this.tbNhapSoN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbKetQua = new System.Windows.Forms.Label();
            this.btnXemKetQua = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdNoiChuoi = new System.Windows.Forms.RadioButton();
            this.rdTinhGiaiThua = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập họ: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập tên: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhập số n: ";
            // 
            // tbNhapHo
            // 
            this.tbNhapHo.Location = new System.Drawing.Point(182, 34);
            this.tbNhapHo.Name = "tbNhapHo";
            this.tbNhapHo.Size = new System.Drawing.Size(115, 20);
            this.tbNhapHo.TabIndex = 0;
            // 
            // tbNhapTen
            // 
            this.tbNhapTen.Location = new System.Drawing.Point(182, 73);
            this.tbNhapTen.Name = "tbNhapTen";
            this.tbNhapTen.Size = new System.Drawing.Size(115, 20);
            this.tbNhapTen.TabIndex = 1;
            // 
            // tbNhapSoN
            // 
            this.tbNhapSoN.Location = new System.Drawing.Point(182, 111);
            this.tbNhapSoN.Name = "tbNhapSoN";
            this.tbNhapSoN.Size = new System.Drawing.Size(115, 20);
            this.tbNhapSoN.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(90, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kết quả:";
            // 
            // lbKetQua
            // 
            this.lbKetQua.AutoSize = true;
            this.lbKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKetQua.Location = new System.Drawing.Point(190, 359);
            this.lbKetQua.Name = "lbKetQua";
            this.lbKetQua.Size = new System.Drawing.Size(18, 25);
            this.lbKetQua.TabIndex = 0;
            this.lbKetQua.Text = ".";
            // 
            // btnXemKetQua
            // 
            this.btnXemKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemKetQua.Location = new System.Drawing.Point(148, 294);
            this.btnXemKetQua.Name = "btnXemKetQua";
            this.btnXemKetQua.Size = new System.Drawing.Size(126, 33);
            this.btnXemKetQua.TabIndex = 4;
            this.btnXemKetQua.Text = "Xem kết quả";
            this.btnXemKetQua.UseVisualStyleBackColor = true;
            this.btnXemKetQua.Click += new System.EventHandler(this.btnXemKetQua_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdTinhGiaiThua);
            this.groupBox1.Controls.Add(this.rdNoiChuoi);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(116, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn bài";
            // 
            // rdNoiChuoi
            // 
            this.rdNoiChuoi.AutoSize = true;
            this.rdNoiChuoi.Location = new System.Drawing.Point(16, 32);
            this.rdNoiChuoi.Name = "rdNoiChuoi";
            this.rdNoiChuoi.Size = new System.Drawing.Size(129, 21);
            this.rdNoiChuoi.TabIndex = 0;
            this.rdNoiChuoi.TabStop = true;
            this.rdNoiChuoi.Text = "Nối chuỗi họ tên";
            this.rdNoiChuoi.UseVisualStyleBackColor = true;
            // 
            // rdTinhGiaiThua
            // 
            this.rdTinhGiaiThua.AutoSize = true;
            this.rdTinhGiaiThua.Location = new System.Drawing.Point(16, 59);
            this.rdTinhGiaiThua.Name = "rdTinhGiaiThua";
            this.rdTinhGiaiThua.Size = new System.Drawing.Size(112, 21);
            this.rdTinhGiaiThua.TabIndex = 1;
            this.rdTinhGiaiThua.TabStop = true;
            this.rdTinhGiaiThua.Text = "Tính giai thừa";
            this.rdTinhGiaiThua.UseVisualStyleBackColor = true;
            // 
            // frmBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnXemKetQua);
            this.Controls.Add(this.tbNhapSoN);
            this.Controls.Add(this.tbNhapTen);
            this.Controls.Add(this.tbNhapHo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbKetQua);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "frmBai3";
            this.Text = "Học toán tiếp";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNhapHo;
        private System.Windows.Forms.TextBox tbNhapTen;
        private System.Windows.Forms.TextBox tbNhapSoN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbKetQua;
        private System.Windows.Forms.Button btnXemKetQua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdNoiChuoi;
        private System.Windows.Forms.RadioButton rdTinhGiaiThua;
    }
}