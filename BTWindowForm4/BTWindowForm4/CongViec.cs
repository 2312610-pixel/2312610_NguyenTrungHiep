using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace BTWindowForm4
{
    internal class CongViec
    {
        public static void ChaoHoi(string hoten, bool gioitinh, System.Windows.Forms.Label lbKetQua)
        {
            if (gioitinh)
                lbKetQua.Text = $"Chào Ông \"{hoten}\"";
            else
                lbKetQua.Text = $"Chào Bà \"{hoten}\"";
        }
        public static int USCLN(int m, int n)
        {
            while (n != 0)
            {
                int temp = n;
                n = m % n;
                m = temp;
            }
            return m;
        }
    }
}
