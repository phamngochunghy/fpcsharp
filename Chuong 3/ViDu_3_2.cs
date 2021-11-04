using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViDu_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ví dụ 3.2
            string s = "ban";
            Console.Write("Xin "); //in chữ "xin " ra màn hình, con trỏ vẫn trên cùng dòng
            Console.WriteLine("chao"); //in tiếp chữ "chao", sau đó con trỏ xuống dòng
            Console.WriteLine("cac " + s); //ghép nội dung chữ "cac " với "ban" chứa trong biến s và hiện ra màn hình
        }
    }
}
