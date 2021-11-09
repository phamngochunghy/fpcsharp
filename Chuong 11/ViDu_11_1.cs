using System;

namespace Chuong11
{
    class ViDu_11_1
    {
        //Ví dụ 11.1
        static int searchX(int[] a, int x)
        {
            int n = a.Length;
            for (int i = 0; i < n; i++)
                if (a[i] == x) return i;
            return -1;
        }
        static void Main(string[] args)
        {
            int[] MangSo = { 3, 6, 8, 4, 9 };
            Console.WriteLine("Ket qua tim: " + searchX(MangSo, 8));
        }
    }
}
