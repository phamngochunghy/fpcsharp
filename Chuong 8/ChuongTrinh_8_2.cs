//Chương trình 8.2 
using System;
using System.Collections.Generic;
using System.Text;
namespace Chuong8
{
    class ChuongTrinh_8_2
    {
        //Xóa các dấu cách thừa ở đầu, giữa và cuối xâu
        static void allTrim(ref string s)
        {
            s = s.Trim();
            int i = s.IndexOf("  ", 0);
            while (i >= 0)
            {
                s = s.Remove(i, 1); // Nếu tìm thấy 2 ký tự cách liên tiếp thì xóa bớt đi 1
                i = s.IndexOf("  ", i);  // Xau " " có hai ký tự cách.     
            }
        }
        //Chuẩn hóa xâu ký tự
        static string Standard(string tmp)
        {
            tmp = tmp.ToLower();
            tmp = tmp.Trim();
            StringBuilder t = new StringBuilder(tmp);
            t[0] = char.ToUpper(t[0]);
            for (int i = 1; i < t.Length; ++i)
                if (t[i] == ' ') t[i + 1] = char.ToUpper(t[i + 1]);
            tmp = t.ToString();
            return tmp;
        }
        static void Main(string[] args)
        {
            string st;
            Console.Write("input string: ");
            st = Console.ReadLine();
            st = Standard(st);
            Console.WriteLine("After Standard: " + st);
            Console.ReadKey();
        }
    }
}
