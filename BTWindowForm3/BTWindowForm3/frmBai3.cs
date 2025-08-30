using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTWindowForm3
{
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        private void btnXemKetQua_Click(object sender, EventArgs e)
        {
            string hoten = tbNhapHoTen.Text;
            int so1 = int.Parse(tbSo1.Text);
            int so2 = int.Parse(tbSo2.Text);

            if (rdThuTu.Checked)
                lbKetQua.Text = TinhToan.ThuTu(so1, so2).ToString();
            else
            {
                string s1 = "";
                string s2 = "";
                TinhToan.TachChuoi(hoten, ref s1, ref s2);
                lbKetQua.Text = $"Họ: {s1}\nTên: {s2}";
            }
        }
    }
}
