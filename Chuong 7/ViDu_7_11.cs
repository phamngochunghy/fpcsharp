using System;
namespace Chuong7
{
    //Ví dụ 7.11
    class ViDu_7_11
    {
        //Khai báo mảng a hai chiều không cùng kích thước
        static int[][] a;
        static void Nhap()
        {
            int i, j, n, m;
            Console.Write("Ban muon nhap vao bao nhieu day so nguyen n=");
            n = int.Parse(Console.ReadLine());
            a = new int[n][];
            Console.WriteLine("Ban hay nhap thông tin cho moi day so nguyen");
            for (i = 0; i < a.Length; ++i)
            {
                Console.Write("Ban hay nhap so phan tu cho day thu {0} m=", i);
                m = int.Parse(Console.ReadLine());
                a[i] = new int[m];
                Console.WriteLine("Nhap gia tri cho moi phan tu o day thu {0}", i);
                for (j = 0; j < a[i].Length; j++)
                {
                    Console.Write("a[{0}][{1}]=", i, j);
                    a[i][j] = int.Parse(Console.ReadLine());
                }
            }
        }
        static void Tim(out int[] kq)
        {
            int i, j, d = 0, max;
            kq = null;
            for (i = 0; i < a.Length; ++i)
            {
                max = a[i][0];
                for (j = 1; j < a[i].Length; ++j)
                    if (max < a[i][j]) max = a[i][j];
                Array.Resize(ref kq, ++d);
                kq[d - 1] = max;
            }
        }
        static void Hien(int[] x)
        {
            int i;
            for (i = 0; i < x.Length; ++i)
                Console.Write("{0}\t", x[i]);
            Console.WriteLine();
        }
        static void Main()
        {
            int[] kq;
            Nhap();
            Tim(out kq);
            Array.Sort(kq);
            Console.WriteLine("Cac phan tu lon nhat cua moi day da duoc sap xep la");
            Hien(kq);
            Console.ReadKey();
        }
    }
}

