//Chương trình 7.2
using System;
class ChuongTrinh_7_2
{
    static int[] a;
    static int n;
    static void NhapMang()
    {
        int i;
        Console.Write("Nhap so phan tu cua mang n=");
        n = int.Parse(Console.ReadLine());
        a = new int[n];
        Console.WriteLine("Hay nhap cac phan tu cho mang");
        for (i = 0; i < n; ++i)
        {
            Console.Write("a[{0}]=", i);
            a[i] = int.Parse(Console.ReadLine());
        }
    }
    static void HienMang(int[] x)
    {
        int i;
        for (i = 0; i < x.Length; ++i)
            Console.Write("{0}\t", x[i]);
        Console.WriteLine();
    }
    static int TongChiaHetCho3()
    {
        int i, t = 0;
        for (i = 0; i < n; ++i)
            if (a[i] % 3 == 0) t = t + a[i];
        return t;
    }
    static int Max()
    {
        int i, mx;
        mx = a[0];
        for (i = 1; i < n; ++i)
            if (mx < a[i]) mx = a[i];
        return mx;
    }
    static int Dem(int x)
    {
        int i, d = 0;
        for (i = 0; i < n; ++i)
            if (a[i] == x) d++;
        return d;
    }
    static void RutGon(out int[] KetQua)
    {
        int i, d = 0, j;
        int[] tmp = new int[n];
        bool ok;
        for (i = 0; i < n; ++i)
        {
            ok = true;
            for (j = 0; j < d; ++j)
                if (tmp[j] == a[i])
                { ok = false; break; }
            if (ok) tmp[d++] = a[i];
        }
        KetQua = new int[d];
        Array.Copy(tmp, KetQua, d);
    }
    static void Main()
    {
        ConsoleKeyInfo kt;//Khai báo biến nhập dữ liệu từ bàn phím
        int x;
        int[] b = null;
        do
        {
            Console.Clear();
            Console.WriteLine("\t\t\tMain Menu");
            Console.WriteLine("\t1. Nhap mang");
            Console.WriteLine("\t2. Hien Mang");
            Console.WriteLine("\t3. Cac phan tu cua mang chi het cho 3");
            Console.WriteLine("\t4. Gia tri lon nhat cua mang");
            Console.WriteLine("\t5. So lan xuat hien cua phan tu x trong mang");
            Console.WriteLine("\t6. Rut gon mang");
            Console.WriteLine("\t7. Thoat khoi chuong trinh");
            Console.Write("  Ban hay chon mot cong viec tu 1->7:");
            kt = Console.ReadKey();
            Console.WriteLine();
            switch (kt.KeyChar)
            {
                case '1':
                    NhapMang();
                    Console.WriteLine("Ban hay nhan phim bat ky de tiep tuc...");
                    Console.ReadKey();
                    break;
                case '2':
                    Console.WriteLine("Cac phan tu cua mang la:");
                    HienMang(a);
                    Console.WriteLine("Ban hay nhan phim bat ky de tiep tuc...");
                    Console.ReadKey();
                    break;
                case '3':
                    Console.WriteLine(" Ket qua la {0:8}", TongChiaHetCho3());
                    Console.WriteLine("Ban hay nhan phim bat ky de tiep tuc...");
                    Console.ReadKey();
                    break;
                case '4':
                    Console.WriteLine(" Ket qua la {0,8}", Max());
                    Console.WriteLine("Ban hay nhan phim bat ky de tiep tuc...");
                    Console.ReadKey();
                    break;
                case '5':
                    Console.Write("Nhap x="); x = int.Parse(Console.ReadLine());

                    Console.WriteLine(" Ket qua la {0:8}", Dem(x));
                    Console.WriteLine("Ban hay nhan phim bat ky de tiep tuc...");
                    Console.ReadKey();
                    break;
                case '6':
                    Console.WriteLine("Cac phan tu cua mang sau khi rut gon:");
                    RutGon(out b);
                    HienMang(b);
                    Console.WriteLine("Ban hay nhan phim bat ky de tiep tuc...");
                    Console.ReadKey();
                    break;
                case '7':
                    Environment.Exit(0); break;
            }
        } while (true);
    }
}
