//Chương trình 7.5
using System;
class ChuongTrinh_7_5
{
    static int[,] a;
    static int m, n;
    static void NhapMaTran()
    {
        int i, j;
        do
        {
            Console.Write("Nhap so hang m=");
            m = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot n=");
            n = int.Parse(Console.ReadLine());
        } while (!(m > 0 && n > 0));
        a = new int[m, n];
        Console.WriteLine("Nhap gia tri cho cac phan tu cua ma tran");
        for (i = 0; i < m; ++i)
            for (j = 0; j < n; ++j)
            {
                Console.Write("a[{0},{1}]=", i, j);
                a[i, j] = int.Parse(Console.ReadLine());
            }
    }
    static void HienMaTran()
    {
        int i, j;
        for (i = 0; i < m; ++i)
        {
            for (j = 0; j < n; ++j)
                Console.Write("{0}\t", a[i, j]);
            Console.WriteLine();
        }
    }
    static int Max()
    {
        int i, j, mx = a[0, 0];
        for (i = 0; i < m; ++i)
            for (j = 0; j < n; ++j)
                if (mx < a[i, j]) mx = a[i, j];
        return mx;
    }
    static bool SoNguyenTo(int x)
    {
        bool ok = true;
        int i;
        for (i = 2; i < x - 1; ++i)
            if (x % i == 0)
            { ok = false; break; }
        return ok && x != 1;
    }
    static void HienPhanTuNguyenTo()
    {
        int i, j;
        Console.WriteLine("cac phan tu la so nguyen to cua mang");
        for (i = 0; i < m; ++i)
            for (j = 0; j < n; ++j)
                if (SoNguyenTo(a[i, j]))
                    Console.Write("{0}\t", a[i, j]);
        Console.WriteLine();
    }
    static void TongCheoChinh()
    {
        int i, j, t = 1;
        if (m == n)
        {
            for (i = 0; i < m; ++i)
                t = t * a[i, i];
            Console.WriteLine("Tich cac phan tu tren duong cheo chinh la {0}", t);
        }
        else Console.WriteLine("Day khong phan la ma tran vuong");
    }
    static void Main()
    {
        ConsoleKeyInfo kt;
        do
        {
            Console.Clear();
            Console.WriteLine("\t\t\tMain Menu");
            Console.WriteLine("\t1. Nhap thông tin cho mang");
            Console.WriteLine("\t2. Hien mang");
            Console.WriteLine("\t3. Gia tri lon nhat cua mang");
            Console.WriteLine("\t4. Cac phan tu la so nguyen to cua mang");
            Console.WriteLine("\t5. Tich cac phan tu tren duong cheo chinh");

            Console.WriteLine("\t6. Thoat khoi chuong trinh");
            Console.Write("  Ban hay chon mot cong viec tu 1->6:");
            kt = Console.ReadKey();
            Console.WriteLine();
            switch (kt.KeyChar)
            {
                case '1':
                    NhapMaTran();
                    Console.WriteLine("Ban hay nhan phim bat ky de tiep tuc...");
                    Console.ReadKey();
                    break;
                case '2':
                    Console.WriteLine("Cac phan tu cua mang la");
                    HienMaTran();
                    Console.WriteLine("Ban hay nhan phim bat ky de tiep tuc...");
                    Console.ReadKey();
                    break;
                case '3':
                    Console.WriteLine(" Max cua mang {0}", Max());
                    Console.WriteLine("Ban hay nhan phim bat ky de tiep tuc...");
                    Console.ReadKey();
                    break;
                case '4':
                    HienPhanTuNguyenTo();
                    Console.WriteLine("Ban hay nhan phim bat ky de tiep tuc...");
                    Console.ReadKey();
                    break;
                case '5':
                    TongCheoChinh();
                    Console.WriteLine("Ban hay nhan phim bat ky de tiep tuc...");
                    Console.ReadKey();
                    break;
                case '6':
                    Environment.Exit(0); break;
            }
        } while (true);
    }
}
