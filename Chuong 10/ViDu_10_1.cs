using System;
using System.IO;//Khai báo dùng thư viện IO để thao tác trên tệp tin
namespace Chuong10
{
    class ViDu_10_1
    {
        //Ví dụ 10.1
        static void Main(string[] args)
        {
            //Tạo mới tệp văn bản có tên VanBan.txt
            StreamWriter Writer = new StreamWriter("VanBan.txt");
            //Thực hiện vòng lặp ghi 10 dòng văn bản ra tệp văn bản
            for (int i = 1; i <= 10; i++)
            {
                //Gọi phương thức WriteLine để ghi từng dòng văn bản
                Writer.WriteLine("Dong van ban thu " + i);
            }
            //Đóng tệp sau khi hoàn tất việc ghi dữ liệu và không tiếp tục 
            //thao tác trên tệp tin này
            Writer.Close();
        }
    }
}
