//Chương trình 5.3
using System;
using System.Collections;
namespace Chuong5
{
    class ChuongTrinh_5_3
    {
        static void Main(string[] args)
        {
            int n, i;
            long giai_thua = 1;
            Console.Write("Tinh giai thua.\nMoi nhap so nguyen duong n = ");
            n = int.Parse(Console.ReadLine());
            if (n == 0 || n == 1)
            {
                giai_thua = n;
            }
            else
            {
                for (i = 2; i <= n; i++)
                {
                    giai_thua *= i;
                }
            }
            Console.Write("Giai thua cua {0} la: {1} \n", n, giai_thua);
            Console.ReadKey();
        }
    }
}
