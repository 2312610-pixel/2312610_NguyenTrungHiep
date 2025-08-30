using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTWindownForm2
{
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        private void btnXemKetQua_Click(object sender, EventArgs e)
        {
            string ho = tbNhapHo.Text;
            string ten = tbNhapTen.Text;    
            int n = int.Parse(tbNhapSoN.Text);
            string kq = "";

            lbKetQua.Text = TinhToan.GiaiThua(n).ToString();
            if(rdNoiChuoi.Checked)
                lbKetQua.Text = TinhToan.NoiChuoi(ho, ten, ref kq);

        }
    }
}
