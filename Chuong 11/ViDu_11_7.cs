using System;

namespace Chuong11
{
    class ViDu_11_7
    {
        //Ví dụ 11.7
        static void Sort(int[] a)
        {
            int n = a.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = i + 1; j < n; j++)
                    if (a[i] > a[j])
                    {
                        int tg = a[i];
                        a[i] = a[j];
                        a[j] = tg;
                    }
        }



        static void Main(string[] args)
        {
            int[] MangSo = { 50, 3, 6, 8, 4, 9, 10, 15, 25 };
            Sort(MangSo);
        }
    }
}
