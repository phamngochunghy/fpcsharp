//Chương trình 7.1
using System;
using System.Collections;
namespace Chuong7
{
    class ChuongTrinh_7_1
    {
        //Phân tích số nguyên n thành tích các thừa số nguyên tố
        static void phanTichSoNguyen(int n)
        {
            int i = 2;
            int dem = 0;
            //Sử dụng mảng để lưu trữ các thừa số phân tích được
            int[] a = new int[100];
            while (n > 1)
            {
                if (n % i == 0)
                {
                    n = n / i;
                    a[dem++] = i;
                }
                else
                {
                    i++;
                }
            }
            if (dem == 0)
            {
                a[dem++] = n;
            }
            for (i = 0; i < dem - 1; i++)
            {
                Console.Write("{0} x ", a[i]);
            }
            Console.Write("{0}", a[dem - 1]);
        }
        static void Main(string[] args)
        {
            int n;
            Console.Write("Phan tich so nguyen n thanh tich cac thua so nguyen to.\nMoi nhap so nguyen duong n = ");
            n = Convert.ToInt32(Console.ReadLine());
            // phan tich so nguyen duong n
            phanTichSoNguyen(n);
            Console.ReadKey();
        }
    }
}
