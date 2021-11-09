//Chương trình 7.6
using System;
class ChuongTrinh_7_6
{
    static int n;
    static void NhapMaTran(char Ten, out int[,] x)
    {
        int i, j;
        x = new int[n, n];

        Console.WriteLine("Nhap gia tri cho cac phan tu cua ma tran {0}", Ten);
        for (i = 0; i < n; ++i)
            for (j = 0; j < n; ++j)
            {
                Console.Write("{0}[{1},{2}]=", Ten, i, j);
                x[i, j] = int.Parse(Console.ReadLine());
            }
    }
    static void HienMaTran(int[,] x)
    {
        int i, j;
        for (i = 0; i < n; ++i)
        {
            for (j = 0; j < n; ++j)
                Console.Write("{0}\t", x[i, j]);
            Console.WriteLine();
        }
    }
    static void Hien(int[] x)
    {
        int i;
        for (i = 0; i < n; ++i)
            Console.Write("{0}\t", x[i]);
        Console.WriteLine();
    }
    static void Tong(int[,] x, int[,] y, out int[,] kq)
    {
        int i, j;
        kq = new int[n, n];
        for (i = 0; i < n; ++i)
            for (j = 0; j < n; ++j)
                kq[i, j] = x[i, j] + y[i, j];
    }
    static int[,] Tich(int[,] A, int[,] B)
    {
        if (A.GetLength(1) == B.GetLength(0))
        {
            int[,] C = new int[A.GetLength(0), B.GetLength(1)];
            for (int i = 0; i < A.GetLength(0); i++)
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    C[i, j] = 0;
                    for (int k = 0; k < A.GetLength(1); k++)
                        C[i, j] = C[i, j] + A[i, k] * B[k, j];
                }
            return C;
        }
        else return null;
    }
    static void TronOc(ref int[,] x)
    {
        int i, j, d = 0, k = 0;
        int[] tmp = new int[n * n];
        for (i = 0; i < n; ++i)
            for (j = 0; j < n; ++j)
                tmp[d++] = x[i, j];
        Array.Sort(tmp);
        d = 0;
        do
        {
            i = k;
            for (j = k; j < n - 1 - k; ++j)
                x[i, j] = tmp[d++];
            j = n - 1 - k;
            for (i = k; i < n - 1 - k; ++i)
                x[i, j] = tmp[d++];
            i = n - 1 - k;
            for (j = n - 1 - k; j > k; --j)
                x[i, j] = tmp[d++];
            j = k;
            for (i = n - 1 - k; i > k; --i)
                x[i, j] = tmp[d++];
            k++;
            if (d == n * n - 1) x[n / 2, n / 2] = tmp[d++];
        } while (d < n * n);
    }
    static void Main()
    {
        int[,] a = null;
        int[,] b = null;
        int[,] c = null;
        int[] x = null;
        Console.Write("Nhap cap cau ma tran n=");
        n = int.Parse(Console.ReadLine());
        NhapMaTran('A', out a);
        NhapMaTran('B', out b);
        Tong(a, b, out c);
        Console.WriteLine("Tong hai ma tran");
        HienMaTran(c);
        Console.WriteLine("Tich hai ma tran");
        c = Tich(a, b);
        if (c != null) HienMaTran(c);
        TronOc(ref c);
        Console.WriteLine("Mang c sau khi sap xep");
        HienMaTran(c);
        Console.ReadKey();
    }
}
