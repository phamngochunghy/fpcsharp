using System;
namespace ViDu_5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ví dụ 5.2
            //Nhập vào 2 số nguyên dương a,b
            int a, b;
            Console.Write("Nhap so a:");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so b:");
            b = int.Parse(Console.ReadLine());
            //sử dụng hàm trị tuyệt đối để đảm bảo a,b là số nguyên dương
            a = Math.Abs(a); b = Math.Abs(b);
            //sử dụng vòng lặp while tính ước số chung lớn nhất của a, b
            while (a != b)
            {
                if (a > b) a -= b;
                if (a < b) b -= a;
            }
            //Hiển thị kết quả ra màn hình
            Console.WriteLine("Uoc so chung lon nhat la: {0}", a);
        }
    }
}
