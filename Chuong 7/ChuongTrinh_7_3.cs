//Chương trình 7.3
using System;
class ChuongTrinh_7_3
{
    static void NhapMang(char ten, out int[] x)
    {
        int i, n;
        Console.WriteLine("Nhap thông tin cho cac phan tu cua mang {0}", ten);
        Console.Write("Nhap so phan tu cua mang:");
        n = int.Parse(Console.ReadLine());
        x = new int[n];
        Console.WriteLine("Hay nhap cac phan tu cho mang");
        for (i = 0; i < n; ++i)
        {
            Console.Write("{0}[{1}]=", ten, i);
            x[i] = int.Parse(Console.ReadLine());
        }
    }
    static void HienMang(int[] x)
    {
        int i;
        for (i = 0; i < x.Length; ++i)
            Console.Write("{0}\t", x[i]);
        Console.WriteLine();
    }
    static void GhepMang(int[] x, int[] y, out int[] kq)
    {
        kq = new int[x.Length + y.Length];
        Array.Copy(x, kq, x.Length);
        Array.Copy(y, 0, kq, x.Length, y.Length);
    }
    static bool CapSoCong(int[] x)
    {
        bool ok = true;
        int i;
        for (i = 1; i < x.Length - 1; ++i)
            if (x[i] != (x[i - 1] + x[i + 1]) / 2)
            { ok = false; break; }
        return ok;
    }
    static void MotLan(int[] x, out int[] kq)
    {
        int i, j, d = 0;
        int[] tmp = new int[x.Length];
        bool ok;
        for (i = 0; i < x.Length; ++i)
        {
            ok = true;
            for (j = 0; j < x.Length; ++j)
                if (x[i] == x[j] && i != j)
                { ok = false; break; };
            if (ok) tmp[d++] = x[i];
        }
        kq = new int[d];
        Array.Copy(tmp, kq, d);
    }
    static void TachMang(int[] x, out int[] chan, out int[] le)
    {
        int i, d1 = 0, d2 = 0;
        int[] tmp1 = new int[x.Length];
        int[] tmp2 = new int[x.Length];
        for (i = 0; i < x.Length; ++i)
            if (x[i] % 2 == 0)
                tmp1[d1++] = x[i];
            else
                tmp2[d2++] = x[i];
        chan = new int[d1]; Array.Copy(tmp1, chan, d1);
        le = new int[d2]; Array.Copy(tmp2, le, d2);
    }
    static void Chen(int[] x, int[] y, out int[] kq)
    {
        int i, n, k, j;
        Array.Sort(x);
        Array.Sort(y);
        kq = new int[x.Length + y.Length];
        Array.Copy(x, kq, x.Length);
        n = x.Length - 1;
        for (i = 0; i < y.Length; ++i)
        {
            if (kq[n] < y[i]) kq[++n] = y[i];
            else
            {
                j = 0;
                while (y[i] >= kq[j]) j++;
                for (k = ++n; k > j; --k)
                    kq[k] = kq[k - 1];
                kq[j] = y[i];
            }
        }
    }
    static void Main()
    {
        int[] a = null;
        int[] b = null;
        int[] c = null;
        int[] d = null;
        int[] kq = null;
        int[] chan = null;
        int[] le = null;
        ConsoleKeyInfo kt;
        do
        {
            Console.Clear();
            Console.WriteLine("\t\t\tMain Menu");
            Console.WriteLine("\t1. Nhap thông tin cho hai mang");
            Console.WriteLine("\t2. Mang ghep la");
            Console.WriteLine("\t3. Kiem tra day co la cap so cong ko?");
            Console.WriteLine("\t4. Cac phan tu cua mang xuat hien dung mot lan");
            Console.WriteLine("\t5. Tach mang(chan, le)");
            Console.WriteLine("\t6. Chen mang");
            Console.WriteLine("\t7. Thoat khoi chuong trinh");
            Console.Write("  Ban hay chon mot cong viec tu 1->7:");
            kt = Console.ReadKey();
            Console.WriteLine();
            switch (kt.KeyChar)
            {
                case '1':
                    NhapMang('A', out a);
                    NhapMang('B', out b);
                    Console.WriteLine("Ban hay nhan phim bat ky de tiep tuc...");
                    Console.ReadKey();
                    break;
                case '2':
                    Console.WriteLine("Mang ghep la");
                    GhepMang(a, b, out c);
                    HienMang(c);
                    Console.WriteLine("Ban hay nhan phim bat ky de tiep tuc...");
                    Console.ReadKey();
                    break;
                case '3':
                    if (CapSoCong(c) == true)
                        Console.WriteLine(" Day da cho la cap so cong");
                    else
                        Console.WriteLine(" Day da cho khong phai la cap so cong");
                    Console.WriteLine("Ban hay nhan phim bat ky de tiep tuc...");
                    Console.ReadKey();
                    break;
                case '4':
                    Console.WriteLine("Cac phan tu cua mang xuat hien dung mot lan");
                    MotLan(c, out kq);
                    HienMang(kq);
                    Console.WriteLine("Ban hay nhan phim bat ky de tiep tuc...");
                    Console.ReadKey();
                    break;
                case '5':
                    TachMang(c, out chan, out le);
                    Console.WriteLine("Cac phan tu chan");
                    HienMang(chan);
                    Console.WriteLine("Cac phan tu le");
                    HienMang(le);

                    Console.WriteLine("Ban hay nhan phim bat ky de tiep tuc...");
                    Console.ReadKey();
                    break;
                case '6':
                    Console.WriteLine("Mang chen la:");
                    Chen(a, b, out d);
                    HienMang(d);
                    Console.WriteLine("Ban hay nhan phim bat ky de tiep tuc...");
                    Console.ReadKey();
                    break;
                case '7':
                    Environment.Exit(0); break;
            }
        } while (true);
    }
}
