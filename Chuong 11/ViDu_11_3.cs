using System;

namespace Chuong11
{
    class ViDu_11_3
    {
        //Ví dụ 11.3
        static int getSum(int[] a)
        {
            int n = a.Length;
            int s = 0;
            int count = 0;
            for (int i = 0; i < n; i++)
                if (a[i] > 0)
                {
                    s = s + a[i];
                    count++;
                }
            return s / count;
        }

        static void Main(string[] args)
        {
            int[] MangSo = { 3, 6, 8, 4, 9, 10, 15, 25 };
            Console.WriteLine("Tong: " + getSum(MangSo));
        }
    }
}
