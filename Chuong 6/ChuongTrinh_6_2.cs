using System;
using System.Collections.Generic;
using System.Text;
namespace Chuong6
{
    //Chương trình 6.2
    class ChuongTrinh_6_2
    {
        static double x;
        static int n;
        static void Nhap()
        {
            Console.Write("Nhap x="); x = double.Parse(Console.ReadLine());
            Console.Write("Nhap n="); n = int.Parse(Console.ReadLine());
        }
        static double Mu(double x, int n)
        {
            double s;
            int i;
            for (s = 1, i = 1; i <= n; ++i)
                s = s * x;
            return s;
        }
        static int GiaiThua(int n)
        {
            int s, i;
            for (i = 1, s = 1; i <= n; ++i)
                s = s * i;
            return s;
        }
        static void Main()
        {
            double s = 0;
            int i;
            Nhap();
            for (i = 1; i <= n; ++i)
                s = s + Mu(x, i) / GiaiThua(i);
            Console.Write("S={0:N2}", s);
            Console.ReadKey();
        }
    }

}
