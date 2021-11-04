using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViDu_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ví dụ 3.3
            double a, b, c, max;
            a = 4.5643; b = 3.234; c = 2.724;
            max = (a > b ? a : b) > c ? (a > b ? a : b) : c;
            Console.Write("\n\n\t\tCHUONG TRINH TIM MAX CUA BA SO\n");
            Console.WriteLine("\tMax({0,-6:N2},{1,-6:N2},{2,-6:N2})={3,6:N2}", a, b, c, max);
            Console.ReadKey();
        }
    }
}
