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
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        private void btnXemKetQua_Click(object sender, EventArgs e)
        {
            string hoten = tbHoTen.Text;
            bool gioitinh = false;
            int m = int.Parse(tbSoM.Text);
            int n = int.Parse(tbSoN.Text);
            if (rdNam.Checked)
                gioitinh = true;

            if (rdChaoHoi.Checked)
            {
                CongViec.ChaoHoi(hoten, gioitinh, lbKetQua);
            }

            if (rdUSCLN.Checked)
                lbKetQua.Text = CongViec.USCLN(m, n).ToString();

                
        }
    }
}
