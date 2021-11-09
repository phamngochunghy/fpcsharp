using System;
namespace ViDu_6_7
{
    //Ví dụ 6.7
    //Lớp thư viện toán (ThuVienToan) có hàm/phương thức BinhPhuong được định nghĩa như sau
    class ThuVienToan
    {
        public float BinhPhuong(float x)
        {
            return x * x;
        }
    }

    //Tại lớp Program có thể gọi hàm BinhPhuong thông qua tên lớp ThuVien
    class Program
    {
        static void Main(string[] args)
        {
            //Khai báo biên đối tượng tvt thuộc lớp ThuVienToan
            ThuVienToan tvt = new ThuVienToan();
            float f = 1.4f;
            Console.WriteLine(tvt.BinhPhuong(f));
        }
    }
}
