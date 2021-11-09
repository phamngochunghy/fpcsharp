using System;
namespace ViDu_6_5
{
    //Ví dụ 6.5
    class Program
    {
        static private void Tong(int a, int b, out int T)
        {
            T = a + b;
        }

        static void Main(string[] args)
        {
            int x = 10, y = 20, t;
            Tong(x, y, out t);
        }
    }

}
