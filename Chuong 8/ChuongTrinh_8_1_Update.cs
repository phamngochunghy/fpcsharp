//Chương trình 8.1: sử dụng StringBuilder
using System;
using System.Collections.Generic;
using System.Text;
namespace Chuong8
{
    class ChuongTrinh_8_1_Update
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            StringBuilder sb = new StringBuilder();
            sb.Append("Numbers: ");
            for (int index = 1; index <= 200000; index++)
            {
                sb.Append(index);
            }
            Console.WriteLine(sb.ToString().Substring(0, 1024));
            Console.WriteLine();
            Console.WriteLine(DateTime.Now);
        }
    }
}
