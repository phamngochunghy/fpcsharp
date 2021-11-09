using System;

namespace Chuong11
{
    class ViDu_11_6
    {
        //Ví dụ 11.6
        static int getMax(int[] a)
        {
            int n = a.Length;
            int max = a[0];
            for (int i = 1; i < n; i++)
                if (max < a[i]) max = a[i];
            return max;
        }


        static void Main(string[] args)
        {
            int[] MangSo = { 3, 6, 8, 4, 9, 10, 15, 25 };
            Console.WriteLine("Max: " + getMax(MangSo));
        }
    }
}
