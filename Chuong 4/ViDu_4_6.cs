//Ví dụ 4.6
using System;
namespace ViDu_4_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao thu la con so [1..7]:");
            int t = int.Parse(Console.ReadLine());
            switch (t)
            {
                case 1:
                    Console.WriteLine("Chu Nhat");
                    break;
                case 2:
                    Console.WriteLine("Thu hai");
                    break;
                case 3:
                    Console.WriteLine("Thu ba");
                    break;
                case 4:
                    Console.WriteLine("Thu tu");
                    break;
                case 5:
                    Console.WriteLine("Thu nam");
                    break;
                case 6:
                    Console.WriteLine("Thu sau");
                    break;
                case 7:
                    Console.WriteLine("Thu bay");
                    break;
                default:
                    Console.WriteLine("Thu khong hop le");
                    break;
            }
            Console.ReadKey();
        }
    }
}
