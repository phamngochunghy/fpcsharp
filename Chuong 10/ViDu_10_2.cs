using System;
using System.IO;//Khai báo dùng thư viện IO để thao tác trên tệp tin
namespace Chuong10
{
    class ViDu_10_2
    {
        //Ví dụ 10.2
        static void Main(string[] args)
        {
            //Tạo luồng và mở tệp VanBan.txt ở chế độ đọc
            FileStream fs = new FileStream("VanBan.txt", FileMode.Open, FileAccess.Read);
            //Tạo luồng đọc dữ liệu văn bản StreamReader 
            StreamReader Reader = new StreamReader(fs);
            string line;
            //Thực hiện vòng lặp, gọi hàm Readline của Reader để đọc từng dòng văn bản
            //Lặp cho đến khi hết tệp (kết quả đọc được là null)
            while ((line = Reader.ReadLine()) != null)
            {
                //In ra màn hình dòng văn bản đọc được
                Console.WriteLine(line);
            }
            //Đóng tệp sau khi hoàn tất việc đọc dữ liệu và không tiếp tục 
            //thao tác trên tệp tin này
            Reader.Close();
        }
    }
}
