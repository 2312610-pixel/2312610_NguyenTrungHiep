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
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void btnXemKetQua_Click(object sender, EventArgs e)
        {
            int so1 = int.Parse(tbSoThuNhat.Text);
            int so2 = int.Parse(tbSoThuHai.Text);
            int kq = 0;

            if (rdCong.Checked)
                kq = so1 + so2;
            if (rdTru.Checked)
                kq = so1 - so2;
            if (rdNhan.Checked)
                kq = so1 * so2;
            if (rdChia.Checked)
                kq = so1 / so2;

            lbKetQua.Text = kq.ToString();
        }
    }
}
