﻿using System;
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
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void frmBai1_Load(object sender, EventArgs e)
        {
            SanPham sp = new SanPham();
            sp.MaSanPham = "SP004";
            sp.TenSanPham = "Máy ảnh";
            sp.LoaiSanPham = "Nội thất";
            sp.NgaySanXuat = new DateTime(2008, 01, 18);

            lbThongTin.Text = sp.HienThi();

            lbNamHetHan.Text = sp.NamHetHan().ToString();
        }
    }
}
