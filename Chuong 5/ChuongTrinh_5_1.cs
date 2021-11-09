//Chương trình 5.1
using System;
//Chương trình giải bài toán gửi tiền tiết kiệm
namespace Chuong5
{
    class ChuongTrinh_5_1
    {
        static void Main(string[] args)
        {
            double a, b;
            int t = 0;
            const double k = 0.05;//Lãi suất hàng tháng
            //Nhập số tiền ban đầu a>0
            do
            {
                Console.Write("Nhap so tien ban dau a: ");
                a = double.Parse(Console.ReadLine());
                if (a < 0) Console.WriteLine("Ban nhap sai, moi nhap lai: ");
            } while (a < 0);
            //Nhập số tiền mong muốn b (a<b)
            do
            {
                Console.Write("Nhap so tien mong muon b: ");
                b = double.Parse(Console.ReadLine());
                if (a > b) Console.WriteLine("Ban nhap sai, moi nhap lai: ");
            } while (a > b);
            //Tìm số tháng cần gửi
            do
            {
                a = a + a * k;
                t++;
            } while (a < b);
            //Hiển thị kết quả ra màn hình
            Console.WriteLine("Ban can gui {0} nam, {1} thang", t / 12, t % 12);
            Console.ReadKey();
        }
    }
}
