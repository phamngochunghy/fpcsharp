using System;
namespace ViDu_5_11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ví dụ 5.11
            //Vòng lặp không có break
            int i = 1;
            Console.WriteLine("Vong lap khong co break:");
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
            }
            //Vòng lặp có break
            Console.WriteLine("Vong lap co break:");
            i = 1;
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
                if (i == 5)
                {
                    break;
                }
            }
        }
    }
}
