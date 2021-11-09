using System;
namespace SoLonNhat
{
    //Để thực hiện chương trình, tại dấu nhắc lệnh nhập:
    //SoLonNhat.exe <danh sách các số cách nhau bởi dấu cách>
    //VD: SoLonNhat.exe 4 10 5 9 7
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0; //Ghi nhận (đếm) số tham số đã xử lý
            int Max = 0; //Giá trị lớn nhất
            //Duyệt danh sách tham số dòng lệnh
            for (int i = 0; i < args.Length; i++)
            {
                int so;
                //Thử chuyển đổi tham số thư i thành giá trị số nguyên
                if (int.TryParse(args[i], out so))
                {
                    //Chuyển đổi thành công, so sánh để tìm số lớn nhất
                    n++;
                    if (i == 0) Max = so;
                    else if (so > Max) Max = so;
                }
            }
            if (n > 0) //n>0 cho biết đã chuyển đổi thành công một số tham số
                Console.WriteLine("Gia tri lon nhat la: " + Max); //In ra kết quả
            else //Không có tham số hoặc tham số không đúng định dạng là số nguyên
                Console.WriteLine("Tham so dong lenh chua dung");
        }
    }
}
