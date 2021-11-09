//Chương trình 8.3
using System;
using System.Collections.Generic;
using System.Text;
namespace Chuong8
{
    class ChuongTrinh_8_3
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Chuyen doi he co so 10 sang he 2, 8, 16.\n");
            Console.Write("Moi nhap so nguyen duong n = ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("So {0} trong he co so 2 la: {1}", n, Convert.ToString(n, 2));
            Console.Write("\nSo {0} trong he co so 8 la: {1}", n, Convert.ToString(n, 8));
            Console.Write("\nSo {0} trong he co so 10 la: {1}", n, Convert.ToString(n, 10));
            Console.Write("\nSo {0} trong he co so 16 la: {1}", n, Convert.ToString(n, 16).ToUpper());
            Console.ReadKey();
        }
    }
}
