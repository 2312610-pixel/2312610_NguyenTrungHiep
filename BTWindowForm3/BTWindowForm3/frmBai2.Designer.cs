namespace BTWindowForm3
{
    partial class frmBai2
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
            this.lbKetQua = new System.Windows.Forms.Label();
            this.tbNhapSo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdTinhNGiaiThua = new System.Windows.Forms.RadioButton();
            this.rdTinhTong = new System.Windows.Forms.RadioButton();
            this.btnKetQua = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập một số nguyên dương N:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(179, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kết quả là:";
            // 
            // lbKetQua
            // 
            this.lbKetQua.AutoSize = true;
            this.lbKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKetQua.Location = new System.Drawing.Point(291, 260);
            this.lbKetQua.Name = "lbKetQua";
            this.lbKetQua.Size = new System.Drawing.Size(23, 25);
            this.lbKetQua.TabIndex = 0;
            this.lbKetQua.Text = "0";
            // 
            // tbNhapSo
            // 
            this.tbNhapSo.Location = new System.Drawing.Point(259, 13);
            this.tbNhapSo.Name = "tbNhapSo";
            this.tbNhapSo.Size = new System.Drawing.Size(152, 20);
            this.tbNhapSo.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdTinhNGiaiThua);
            this.groupBox1.Controls.Add(this.rdTinhTong);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(184, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn công việc:";
            // 
            // rdTinhNGiaiThua
            // 
            this.rdTinhNGiaiThua.AutoSize = true;
            this.rdTinhNGiaiThua.Location = new System.Drawing.Point(19, 56);
            this.rdTinhNGiaiThua.Name = "rdTinhNGiaiThua";
            this.rdTinhNGiaiThua.Size = new System.Drawing.Size(165, 24);
            this.rdTinhNGiaiThua.TabIndex = 0;
            this.rdTinhNGiaiThua.TabStop = true;
            this.rdTinhNGiaiThua.Text = "Tính N giai thừa (N!)";
            this.rdTinhNGiaiThua.UseVisualStyleBackColor = true;
            // 
            // rdTinhTong
            // 
            this.rdTinhTong.AutoSize = true;
            this.rdTinhTong.Location = new System.Drawing.Point(19, 26);
            this.rdTinhTong.Name = "rdTinhTong";
            this.rdTinhTong.Size = new System.Drawing.Size(165, 24);
            this.rdTinhTong.TabIndex = 0;
            this.rdTinhTong.TabStop = true;
            this.rdTinhTong.Text = "Tính tổng 1+2+...+N";
            this.rdTinhTong.UseVisualStyleBackColor = true;
            // 
            // btnKetQua
            // 
            this.btnKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKetQua.Location = new System.Drawing.Point(184, 193);
            this.btnKetQua.Name = "btnKetQua";
            this.btnKetQua.Size = new System.Drawing.Size(130, 36);
            this.btnKetQua.TabIndex = 3;
            this.btnKetQua.Text = "Xem kết quả";
            this.btnKetQua.UseVisualStyleBackColor = true;
            this.btnKetQua.Click += new System.EventHandler(this.btnKetQua_Click);
            // 
            // frmBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 312);
            this.Controls.Add(this.btnKetQua);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbNhapSo);
            this.Controls.Add(this.lbKetQua);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBai2";
            this.Text = "Học toán lần nữa";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbKetQua;
        private System.Windows.Forms.TextBox tbNhapSo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdTinhTong;
        private System.Windows.Forms.RadioButton rdTinhNGiaiThua;
        private System.Windows.Forms.Button btnKetQua;
    }
}