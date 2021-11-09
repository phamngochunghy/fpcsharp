//Chương trình 6.5
using System;
namespace Chuong6
{
    class ChuongTrinh_6_5
    {
        static void Main(string[] args)
        {
            int i, n;
            Console.Write("Day so Fibonacci: \nMoi nhap n = ");
            n = int.Parse(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                Console.Write("{0} ", fibonacci(i));
            }
            Console.WriteLine();
            Console.ReadKey();
        }
        //Chương trình con tính số Fibonacci thứ n
        static int fibonacci(int n)
        {
            int f0 = 0;
            int f1 = 1;
            int fn = 1;
            int i;
            if (n < 0)
            {
                return -1;
            }
            else if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                for (i = 2; i < n; i++)
                {
                    f0 = f1;
                    f1 = fn;
                    fn = f0 + f1;
                }
            }
            return fn;
        }
    }
}
