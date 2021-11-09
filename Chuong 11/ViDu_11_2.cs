using System;

namespace Chuong11
{
    class ViDu_11_2
    {
        //Ví dụ 11.2
        static int countIf(int[] a)
        {
            int n = a.Length;
            int count = 0;
            for (int i = 0; i < n; i++)
                if (a[i] % 5 == 0) count++;
            return count;
        }

        static void Main(string[] args)
        {
            int[] MangSo = { 3, 6, 8, 4, 9, 10, 15, 25 };
            Console.WriteLine("Ket dem: " + countIf(MangSo));
        }
    }
}
