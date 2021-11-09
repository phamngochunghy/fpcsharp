using System;
using System.Collections.Generic;
using System.Text;
namespace Chuong6
{
    //Chương trình 6.3
    class ChuongTrinh_6_3
    {
        static void HoanVi(ref int x, ref int y)
        {
            int tg = x; x = y; y = tg;
        }
        static void Main()
        {
            int a, b, c;
            Console.Write("Nhap a=");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap b=");
            b = int.Parse(Console.ReadLine());
            Console.Write("Nhap c=");
            c = int.Parse(Console.ReadLine());
            if (a > b) HoanVi(ref a, ref b);
            if (a > c) HoanVi(ref a, ref c);
            if (b > c) HoanVi(ref b, ref c);
            Console.Write("a={0}\tb={1}\tc={2}", a, b, c);
            Console.ReadKey();
        }
    }

}
