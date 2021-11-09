using System;
using System.Collections.Generic;
using System.Text;
namespace Chuong6
{
    //Chương trình 6.4
    class ChuongTrinh_6_4
    {
        static double a, b, c;
        static void Nhap()
        {
            Console.Write("Nhap a=");
            a = double.Parse(Console.ReadLine());
            Console.Write("Nhap b=");
            b = double.Parse(Console.ReadLine());
            Console.Write("Nhap c=");
            c = double.Parse(Console.ReadLine());
        }
        static double Delta()
        {
            return b * b - 4 * a * c;
        }
        static void Giai(out double x1, out double x2, out bool coNghiem)
        {
            double d = Delta();
            coNghiem = true;
            if (d < 0)
            {
                coNghiem = false;
                x1 = x2 = 0;
            }
            else if (d == 0)
                x1 = x2 = -b / (2 * a);
            else
            {
                x1 = (-b - Math.Sqrt(d)) / (2 * a);
                x2 = (-b + Math.Sqrt(d)) / (2 * a);
            }
        }
        static void Main()
        {
            double x1, x2;
            bool coNghiem;
            Nhap();
            Giai(out x1, out x2, out coNghiem);
            if (coNghiem == true)
            {
                if (x1 == x2)
                    Console.WriteLine("Phuong trinh co nghiem kep x1=x2={0}", x1);
                else
                {
                    Console.WriteLine("Phuong trinh co hai nghiem phan biet:");
                    Console.WriteLine("x1={0}\nx2={1}", x1, x2);
                }
            }
            else
                Console.WriteLine("Phuong trinh vo nghiem");
            Console.ReadKey();
        }
    }

}
