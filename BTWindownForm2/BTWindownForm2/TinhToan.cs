using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTWindownForm2
{
    internal class TinhToan
    {
        public static string NoiChuoi(string ho, string ten, ref string s)
        {

            s = ho + " " + ten;
            return s;
        }
        public static long GiaiThua(int n)
        {
            long kq = 1;
            for (int i = 1; i <= n; i++)
                kq *= i;
            return kq;
        }
    }
}
