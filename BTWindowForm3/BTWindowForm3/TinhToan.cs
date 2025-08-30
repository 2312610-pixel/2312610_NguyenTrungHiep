using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTWindowForm3
{
    internal class TinhToan
    {
        public static int TinhTong(int n)
        {
            int kq = 0;
            for (int i = 1; i <= n; i++)
            {
                kq += i;
            }
            return kq;
        }
        public static int TinhNGiaiThua(int n)
        {
            int kq = 1;
            for (int i = 1; i <= n; i++)
            {
                kq *= i;
            }
            return kq;
        }
        public static void TachChuoi(string hoten, ref string s1, ref string s2)
        {
            string[] parts = hoten.Split(' ');
            s2 = parts[parts.Length - 1];

            if (parts.Length > 1)
                s1 = string.Join(" ", parts, 0, parts.Length - 1);
            else
                s1 = "";
        }
        public static bool ThuTu(int n1, int n2)
        {
            bool kq = false;
            if (n2 == n1 + 1)
                kq = true;
            return kq;
        }
    }
}
