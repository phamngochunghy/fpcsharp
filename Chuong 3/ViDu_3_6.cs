//Ví dụ 3.6
using System;
namespace ViDu_3_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, max;
            Console.Write("\n\n\t\tCHUONG TRINH TIM MAX CUA BA SO\n");
            Console.Write("Nhap a="); a = double.Parse(Console.ReadLine());
            Console.Write("Nhap b="); b = double.Parse(Console.ReadLine());
            Console.Write("Nhap c="); c = double.Parse(Console.ReadLine());
            max = (a > b ? a : b) > c ? (a > b ? a : b) : c;
            Console.WriteLine("\n\tMax({0,-6:N2},{1,-6:N2},{2,-6:N2})={3,6:N2}", a, b, c, max);
            Console.ReadKey();
        }
    }
}
