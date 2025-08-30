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
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void btnKetQua_Click(object sender, EventArgs e)
        {
            int n = int.Parse(tbNhapSo.Text); 

            lbKetQua.Text = TinhToan.TinhNGiaiThua(n).ToString();

            if (rdTinhTong.Checked)
                lbKetQua.Text = TinhToan.TinhTong(n).ToString();
        }
    }
}
