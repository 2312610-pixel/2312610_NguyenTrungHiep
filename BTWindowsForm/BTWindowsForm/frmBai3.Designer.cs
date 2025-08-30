namespace BTWindowsForm
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
            this.tbSoA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSoB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSoN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbKetQua = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdTongDayN = new System.Windows.Forms.RadioButton();
            this.rdTongAB = new System.Windows.Forms.RadioButton();
            this.btnKetQua = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số a: ";
            // 
            // tbSoA
            // 
            this.tbSoA.Location = new System.Drawing.Point(111, 34);
            this.tbSoA.Name = "tbSoA";
            this.tbSoA.Size = new System.Drawing.Size(100, 20);
            this.tbSoA.TabIndex = 1;
            this.tbSoA.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số b: ";
            // 
            // tbSoB
            // 
            this.tbSoB.Location = new System.Drawing.Point(111, 75);
            this.tbSoB.Name = "tbSoB";
            this.tbSoB.Size = new System.Drawing.Size(100, 20);
            this.tbSoB.TabIndex = 1;
            this.tbSoB.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số n: ";
            // 
            // tbSoN
            // 
            this.tbSoN.Location = new System.Drawing.Point(111, 113);
            this.tbSoN.Name = "tbSoN";
            this.tbSoN.Size = new System.Drawing.Size(100, 20);
            this.tbSoN.TabIndex = 1;
            this.tbSoN.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kết quả: ";
            // 
            // lbKetQua
            // 
            this.lbKetQua.AutoSize = true;
            this.lbKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKetQua.Location = new System.Drawing.Point(149, 324);
            this.lbKetQua.Name = "lbKetQua";
            this.lbKetQua.Size = new System.Drawing.Size(18, 25);
            this.lbKetQua.TabIndex = 0;
            this.lbKetQua.Text = ".";

            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdTongDayN);
            this.groupBox1.Controls.Add(this.rdTongAB);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(48, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn phép tính ";
            // 
            // rdTongDayN
            // 
            this.rdTongDayN.AutoSize = true;
            this.rdTongDayN.Location = new System.Drawing.Point(17, 59);
            this.rdTongDayN.Name = "rdTongDayN";
            this.rdTongDayN.Size = new System.Drawing.Size(165, 21);
            this.rdTongDayN.TabIndex = 0;
            this.rdTongDayN.TabStop = true;
            this.rdTongDayN.Text = "Tính tổng của 1 đến n";
            this.rdTongDayN.UseVisualStyleBackColor = true;
            // 
            // rdTongAB
            // 
            this.rdTongAB.AutoSize = true;
            this.rdTongAB.Location = new System.Drawing.Point(17, 32);
            this.rdTongAB.Name = "rdTongAB";
            this.rdTongAB.Size = new System.Drawing.Size(156, 21);
            this.rdTongAB.TabIndex = 0;
            this.rdTongAB.TabStop = true;
            this.rdTongAB.Text = "Tính tổng của a và b";
            this.rdTongAB.UseVisualStyleBackColor = true;
            // 
            // btnKetQua
            // 
            this.btnKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKetQua.Location = new System.Drawing.Point(65, 266);
            this.btnKetQua.Name = "btnKetQua";
            this.btnKetQua.Size = new System.Drawing.Size(119, 29);
            this.btnKetQua.TabIndex = 3;
            this.btnKetQua.Text = "Xem kết quả ";
            this.btnKetQua.UseVisualStyleBackColor = true;
            this.btnKetQua.Click += new System.EventHandler(this.btnKetQua_Click);
            // 
            // frmBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 398);
            this.Controls.Add(this.btnKetQua);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbSoN);
            this.Controls.Add(this.lbKetQua);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSoB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSoA);
            this.Controls.Add(this.label1);
            this.Name = "frmBai3";
            this.Text = "Học toán ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSoA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSoB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSoN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbKetQua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdTongDayN;
        private System.Windows.Forms.RadioButton rdTongAB;
        private System.Windows.Forms.Button btnKetQua;
    }
}