//Chương trình 3.1
using System;
namespace ChuongTrinh_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;//Biến chứa xâu ký tự người dùng nhập
            Console.Write("Nhap xau ky tu bat ky tu ban phim: ");
            str = Console.ReadLine();
            Console.Write("Xau ky tu vua nhap la: " + str);
            Console.ReadKey();//Đợi người dùng nhấn phím bất kỳ rồi kết thúc
        }
    }
}