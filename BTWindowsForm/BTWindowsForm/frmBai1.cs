using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTWindowsForm
{
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void frmBai1_Load(object sender, EventArgs e)
        {
            HangHoa hh = new HangHoa();
            hh.MaHang = "BP04";
            hh.TenHang = "Bàn phím";
            hh.DVT = "Cái";
            hh.SoLuong = 4;
            hh.DonGia = 24000;

            lbThongBao.Text = hh.HienThi();
        }
    }
}
