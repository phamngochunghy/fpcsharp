using System;

namespace Chuong11
{
    class ViDu_11_5
    {
        //Ví dụ 11.5
        static bool check(int[] a)
        {
            bool flag = true;
            int n = a.Length;
            for (int i = 0; i < n - 1; i++)
                if (a[i] > a[i + 1]) //vi phạm điều kiện tăng dần
                {
                    flag = false;
                    break;
                }
            return flag;
        }


        static void Main(string[] args)
        {
            int[] MangSo = { 3, 6, 8, 4, 9, 10, 15, 25 };
            Console.WriteLine("Check: " + check(MangSo));
        }
    }
}
