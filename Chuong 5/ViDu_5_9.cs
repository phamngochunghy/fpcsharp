using System;
namespace ViDu_5_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ví dụ 5.9
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                    Console.WriteLine("{0} x {1} = {2}", i, j, i * j);
                Console.WriteLine("----------------");
            }
        }
    }
}
