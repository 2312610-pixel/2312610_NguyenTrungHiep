using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BTWindowForm3
{
    internal class NhanVien
    {
        public string MaNV {  get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; } 
        public int HeSoLuong { get; set; }
        public int HeSoPhuCap { get; set; }

        public NhanVien()
        {
            MaNV = "NV004";
            HoTen = "Nguyễn Trung Hiệp";
            NgaySinh = new DateTime(2005, 2, 18);
            HeSoLuong = 4;
            HeSoPhuCap = 5;
        }
        public int TongLuong()
        {
            int tl = 0;
            tl = (HeSoLuong + HeSoPhuCap) * 1150000;
            return tl;
        }
        public string HienThi()
        {
            return string.Format("{0}, {1}, {2}, {3}, {4}", MaNV, HoTen, NgaySinh, HeSoLuong, HeSoPhuCap);
        }
    }
}
