using System;

namespace Chuong11
{
    class ViDu_11_4
    {
        //Ví dụ 11.4
        static int getMulti(int[] a)
        {
            int n = a.Length;
            int t = 1;
            for (int i = 0; i < n; i++)
                if (a[i] > 0) t = t * a[i];
            return t;
        }


        static void Main(string[] args)
        {
            int[] MangSo = { 3, 6, 8, 4, 9, 10, 15, 25 };
            Console.WriteLine("Tich: " + getMulti(MangSo));
        }
    }
}
