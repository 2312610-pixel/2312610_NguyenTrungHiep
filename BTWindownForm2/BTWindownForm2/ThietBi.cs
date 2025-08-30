using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTWindownForm2
{
    internal class ThietBi
    {
        public string MaThietBi {  get; set; }
        public string TenThietBi { get; set; }
        public string NuocSanXuat {  get; set; }
        public int DonGia { get; set; }
        public int SoLuong {  get; set; }
        public ThietBi()
        {
            MaThietBi = "TB001";
            TenThietBi = "Máy tính";
            NuocSanXuat = "Việt Nam";
            DonGia = 300000;
            SoLuong = 4;
        }
        public int ThanhTien()
        {
            return DonGia * SoLuong;
        }
        public string HienThi()
        {
            return string.Format("{0}, {1}, {2}, {3}, {4}", MaThietBi, TenThietBi, NuocSanXuat, DonGia, SoLuong);
        }
    }
}
