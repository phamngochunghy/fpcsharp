//Chương trình 4.1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuongTrinh_4_1
{
    class ChuongTrinh41
    {
        static int a, b, c, Max;
        static void SoLonNhat()
        {
            Console.Write("Nhap so a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so b: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Nhap so c: ");
            c = int.Parse(Console.ReadLine());
            if (a > b)
                Max = a;
            else
                Max = b;
            if (Max < c) Max = c;
            Console.WriteLine("Gia tri lon nhat la: {0}", Max);
            Console.ReadKey();
        }
    }
}
