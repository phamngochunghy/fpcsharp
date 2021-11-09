//Chương trình 6.1
using System;
using System.Collections.Generic;
using System.Text;
namespace Chuong6
{
    class ChuongTrinh_6_1
    {
        static int DEC_10 = 10;
        //Tinh tong cac chu so cua mot so nguyen duong
        static int TongChuSo(int n)
        {
            int total = 0;
            do
            {
                total = total + n % DEC_10;
                n = n / DEC_10;
            } while (n > 0);
            return total;
        }
        static void Main(string[] args)
        {
            int n;
            Console.Write("Tinh tong cac chu so\nMoi nhap so nguyen duong n = ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Tong cac chu so cua {0} la: {1}", n, TongChuSo(n));
            Console.ReadKey();
        }
    }
}
