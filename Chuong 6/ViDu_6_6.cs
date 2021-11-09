using System;
namespace ViDu_6_6
{
    //Ví dụ 6.6
    //Lớp thư viện (ThuVien) được định nghĩa như sau
    class ThuVien
    {
        public static float BinhPhuong(float x)
        {
            return x * x;
        }
    }
    //Tại lớp Program có thể gọi hàm BinhPhuong thong qua ten lớp ThuVien
    class Program
    {
        static void Main(string[] args)
        {
            float f = 1.4f;
            Console.WriteLine(ThuVien.BinhPhuong(f));
        }
    }
}
