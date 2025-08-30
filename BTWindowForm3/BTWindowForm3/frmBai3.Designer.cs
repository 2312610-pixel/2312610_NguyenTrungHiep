namespace BTWindowForm3
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
            this.tbNhapHoTen = new System.Windows.Forms.TextBox();
            this.tbSo1 = new System.Windows.Forms.TextBox();
            this.tbSo2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdThuTu = new System.Windows.Forms.RadioButton();
            this.rdTachChuoi = new System.Windows.Forms.RadioButton();
            this.btnXemKetQua = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbKetQua = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập họ tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập số nguyên 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhập số nguyên 2:";
            // 
            // tbNhapHoTen
            // 
            this.tbNhapHoTen.Location = new System.Drawing.Point(188, 27);
            this.tbNhapHoTen.Name = "tbNhapHoTen";
            this.tbNhapHoTen.Size = new System.Drawing.Size(212, 20);
            this.tbNhapHoTen.TabIndex = 1;
            // 
            // tbSo1
            // 
            this.tbSo1.Location = new System.Drawing.Point(188, 58);
            this.tbSo1.Name = "tbSo1";
            this.tbSo1.Size = new System.Drawing.Size(145, 20);
            this.tbSo1.TabIndex = 1;
            // 
            // tbSo2
            // 
            this.tbSo2.Location = new System.Drawing.Point(188, 89);
            this.tbSo2.Name = "tbSo2";
            this.tbSo2.Size = new System.Drawing.Size(145, 20);
            this.tbSo2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdThuTu);
            this.groupBox1.Controls.Add(this.rdTachChuoi);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(103, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn công việc";
            // 
            // rdThuTu
            // 
            this.rdThuTu.AutoSize = true;
            this.rdThuTu.Location = new System.Drawing.Point(20, 55);
            this.rdThuTu.Name = "rdThuTu";
            this.rdThuTu.Size = new System.Drawing.Size(72, 24);
            this.rdThuTu.TabIndex = 0;
            this.rdThuTu.TabStop = true;
            this.rdThuTu.Text = "Thứ tự";
            this.rdThuTu.UseVisualStyleBackColor = true;
            // 
            // rdTachChuoi
            // 
            this.rdTachChuoi.AutoSize = true;
            this.rdTachChuoi.Location = new System.Drawing.Point(20, 25);
            this.rdTachChuoi.Name = "rdTachChuoi";
            this.rdTachChuoi.Size = new System.Drawing.Size(104, 24);
            this.rdTachChuoi.TabIndex = 0;
            this.rdTachChuoi.TabStop = true;
            this.rdTachChuoi.Text = "Tách chuỗi";
            this.rdTachChuoi.UseVisualStyleBackColor = true;
            // 
            // btnXemKetQua
            // 
            this.btnXemKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemKetQua.Location = new System.Drawing.Point(169, 269);
            this.btnXemKetQua.Name = "btnXemKetQua";
            this.btnXemKetQua.Size = new System.Drawing.Size(145, 39);
            this.btnXemKetQua.TabIndex = 3;
            this.btnXemKetQua.Text = "Xem kết quả";
            this.btnXemKetQua.UseVisualStyleBackColor = true;
            this.btnXemKetQua.Click += new System.EventHandler(this.btnXemKetQua_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kết quả:";
            // 
            // lbKetQua
            // 
            this.lbKetQua.AutoSize = true;
            this.lbKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKetQua.Location = new System.Drawing.Point(164, 340);
            this.lbKetQua.Name = "lbKetQua";
            this.lbKetQua.Size = new System.Drawing.Size(18, 25);
            this.lbKetQua.TabIndex = 0;
            this.lbKetQua.Text = ".";
            // 
            // frmBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 427);
            this.Controls.Add(this.btnXemKetQua);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbSo2);
            this.Controls.Add(this.tbSo1);
            this.Controls.Add(this.tbNhapHoTen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbKetQua);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "frmBai3";
            this.Text = "frmBai3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNhapHoTen;
        private System.Windows.Forms.TextBox tbSo1;
        private System.Windows.Forms.TextBox tbSo2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdThuTu;
        private System.Windows.Forms.RadioButton rdTachChuoi;
        private System.Windows.Forms.Button btnXemKetQua;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbKetQua;
    }
}