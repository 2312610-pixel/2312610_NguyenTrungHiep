using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTWindowForm4
{
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void btnXepLoai_Click(object sender, EventArgs e)
        {
            int lt = int.Parse(tbLyThuyet.Text);
            int th = int.Parse(tbThucHanh.Text);

            int dtb = (lt + th) / 2;

            if (lt > 10 && th > 10)
            {
                MessageBox.Show("Chỉ nhập điểm nhỏ hơn hoặc bằng 10", "Thông báo", MessageBoxButtons.OK);
                tbLyThuyet.Text = "";
                tbThucHanh.Text = "";
            }
            else
            {
                if (lt < 5 || th < 5)
                    lbXepLoai.Text = "Yếu";
                else
                {
                    if (dtb < 7)
                        lbXepLoai.Text = "Trung bình";
                    if (7 <= dtb && dtb < 8)
                        lbXepLoai.Text = "Khá";
                    if (8 <= dtb && dtb < 9)
                        lbXepLoai.Text = "Giỏi";
                    if (dtb >= 9)
                        lbXepLoai.Text = "Xuất sắc";
                }
            }

        }
    }
}
