using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTWindowsForm
{
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void cbTenHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            int stt = cbTenHang.SelectedIndex;
            switch(stt)
            {
                case 0:
                    tbDonGia.Text = "100000";
                    break;
                case 1:
                    tbDonGia.Text = "2000000";
                    break;
                case 2:
                    tbDonGia.Text = "150000";
                    break;
            }
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            int donGia = int.Parse(tbDonGia.Text);
            int soLuong = int.Parse(tbSoLuong.Text);
            double thanhTien = donGia * soLuong;
            if (rdChuyenKhoan.Checked)
                thanhTien = donGia * soLuong * 0.95;
            
            lbTongTien.Text = thanhTien.ToString();
                
        }
    }
}
