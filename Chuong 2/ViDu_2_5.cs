using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViDu_2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 15;
            Console.WriteLine("Gia tri a:" + a);
            Console.WriteLine("Gia tri b:" + b);
            b = ++a - 2;
            Console.WriteLine("Sau khi thuc hien phep toan b = ++a - 2:");
            Console.WriteLine("Gia tri a:" + a);
            Console.WriteLine("Gia tri b:" + b);
            a = 10;
            b = a++ - 2;
            Console.WriteLine("Sau khi gan a=10 va thuc hien phep toan b = a++ - 2:");
            Console.WriteLine("Gia tri a:" + a);
            Console.WriteLine("Gia tri b:" + b);
            Console.Read();
        }
    }
}
