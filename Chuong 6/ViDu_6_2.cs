using System;
namespace ViDu_6_2
{
    //Ví dụ 6.2
    class Program
    {
        static private int Tong(int a, int b)
        {
            int T = a + b;
            return T;
        }
        static void Main(string[] args)
        {
            int x = 10, y = 20, t;
            t = Tong(x, y);
            Tong(x, y);
            Tong(x, 10.3);
            Tong(x);
            Tong(10, 15);
            Console.WriteLine(Tong(5, 7));
        }
    }

}
