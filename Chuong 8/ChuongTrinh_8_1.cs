//Chương trình 8.1: Sử dụng kiểu string
using System;
namespace Chuong8
{
    class ChuongTrinh_8_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            string st = "Numbers: ";
            for (int index = 1; index <= 200000; index++)
            {
                st += index;
            }
            Console.WriteLine(st.Substring(0, 1024));
            Console.WriteLine();
            Console.WriteLine(DateTime.Now);
        }
    }
}