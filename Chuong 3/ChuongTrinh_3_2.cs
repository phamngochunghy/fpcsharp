//Chương trình 3.2
using System;
namespace ChuongTrinh_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;//Khai báo 2 biến a, b chứa giá trị số người dùng nhập
            Console.Write("Nhap vao so nguyen a: ");//Hiện ra màn hình dòng nhắc nhập dữ liệu
            a = int.Parse(Console.ReadLine());//Dùng phương thức Parse của kiểu int để chuyển xâu ký tự thành số nguyên
            Console.Write("Nhap vao so nguyen b: ");
            b = int.Parse(Console.ReadLine());//Tương tự nhập số nguyên b
            int Tong = a + b;//Tính tổng hai số a và b lưu vào biến Tong
            Console.Write("Tong hai so a va b la: " + Tong);//Hiện ra màn hình nội dung biến Tong (tổng của a và b)
            Console.ReadKey();//Đợi người dùng nhấn phím bất kỳ để kết thúc
        }
    }
}
