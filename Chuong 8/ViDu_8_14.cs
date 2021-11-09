using System;
namespace Chuong8
{
    class Vidu_8_14
    {
        static void Main(string[] args)
        {
            //Ví dụ 8.14: cắt bỏ các ký tự theo yêu cầu
            //cắt bỏ các ký tự 'H' và 'y' ở đầu và cuối xâu
            string greeting = "Hello FitUtehy";
            string st = greeting.Trim(new[] { 'H', 'y' });
        }
    }
}
