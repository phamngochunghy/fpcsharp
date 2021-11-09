//Chương trình 5.2
using System;
namespace Chuong5
{
    class ChuongTrinh_5_2
    {
        static void Main(string[] args)
        {
            int x, y;
            for (x = 0; x <= 36; x++)
            {
                if (2 * x + (36 - x) * 4 == 100)
                {
                    Console.WriteLine("So ga: {0}", x);
                    y = 36 - x;
                    Console.WriteLine("So cho: {0}", y);
                }
            }
            Console.ReadKey();
        }
    }
}
