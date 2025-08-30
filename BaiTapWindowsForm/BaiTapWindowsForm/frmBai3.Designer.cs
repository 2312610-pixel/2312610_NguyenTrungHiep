namespace BaiTapWindowsForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.tbTuMoi = new System.Windows.Forms.TextBox();
            this.tbNghiaCuaTu = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnThemTuMoi = new System.Windows.Forms.Button();
            this.tbXemNghia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ mới:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nghĩa của từ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(129, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "DANH SÁCH TỪ MỚI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(526, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "NGHĨA CỦA TỪ";
            // 
            // tbTuMoi
            // 
            this.tbTuMoi.Location = new System.Drawing.Point(143, 34);
            this.tbTuMoi.Name = "tbTuMoi";
            this.tbTuMoi.Size = new System.Drawing.Size(190, 20);
            this.tbTuMoi.TabIndex = 0;
            // 
            // tbNghiaCuaTu
            // 
            this.tbNghiaCuaTu.Location = new System.Drawing.Point(143, 64);
            this.tbNghiaCuaTu.Name = "tbNghiaCuaTu";
            this.tbNghiaCuaTu.Size = new System.Drawing.Size(190, 20);
            this.tbNghiaCuaTu.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(66, 150);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(267, 172);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnThemTuMoi
            // 
            this.btnThemTuMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTuMoi.Location = new System.Drawing.Point(164, 98);
            this.btnThemTuMoi.Name = "btnThemTuMoi";
            this.btnThemTuMoi.Size = new System.Drawing.Size(75, 23);
            this.btnThemTuMoi.TabIndex = 2;
            this.btnThemTuMoi.Text = "Thêm từ mới ";
            this.btnThemTuMoi.UseVisualStyleBackColor = true;
            this.btnThemTuMoi.Click += new System.EventHandler(this.btnThemTuMoi_Click);
            // 
            // tbXemNghia
            // 
            this.tbXemNghia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbXemNghia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbXemNghia.Location = new System.Drawing.Point(445, 150);
            this.tbXemNghia.Multiline = true;
            this.tbXemNghia.Name = "tbXemNghia";
            this.tbXemNghia.ReadOnly = true;
            this.tbXemNghia.Size = new System.Drawing.Size(267, 172);
            this.tbXemNghia.TabIndex = 4;
            // 
            // frmBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 348);
            this.Controls.Add(this.tbXemNghia);
            this.Controls.Add(this.btnThemTuMoi);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.tbNghiaCuaTu);
            this.Controls.Add(this.tbTuMoi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBai3";
            this.Text = "Từ điển Anh-Việt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTuMoi;
        private System.Windows.Forms.TextBox tbNghiaCuaTu;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnThemTuMoi;
        private System.Windows.Forms.TextBox tbXemNghia;
    }
}