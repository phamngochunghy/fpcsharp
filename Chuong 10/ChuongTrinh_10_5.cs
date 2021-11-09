//Chương trình 10.4
using System;
using System.IO;
namespace Chuong10
{
    class ChuongTrinh_10_5
    {
        //Chương trình 10.5
        //Gọi hàm sau và nhập các mục theo menu để thử nghiệm
        //Lưu ý khai báo using System.IO;
        static void ChuongTrinh10_5()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Hien thi noi dung tep tin");
                Console.WriteLine("2. Doi ten tep tin");
                Console.WriteLine("3. Sao chep tep tin");
                Console.WriteLine("4. Xoa tep tin");
                Console.WriteLine("5. Ket thuc");
                Console.WriteLine("Nhap chuc nang (1..5): ");
                string s = Console.ReadLine();
                switch (s)
                {
                    case "1":
                        Console.WriteLine("HIEN THI TEP VAN BAN");
                        Console.Write("Nhap duong dan tep tin can hien thi: ");
                        string TenTep = Console.ReadLine();
                        if (File.Exists(TenTep))
                        {
                            Console.WriteLine("Noi dung tep tin " + TenTep + " la:");
                            //Gọi hàm ReadAllText của lớp File để đọc toàn bộ nội dung tệp tin đường dẫn chứa trong TenTep
                            Console.WriteLine(File.ReadAllText(TenTep));
                        }
                        break;
                    case "2":
                        Console.WriteLine("DOI TEN TEP TIN");
                        Console.Write("Nhap duong dan tep nguon: ");
                        string TenTepNguon = Console.ReadLine();
                        Console.Write("Nhap duong dan tep dich de doi ten: ");
                        string TenTepDich = Console.ReadLine();
                        if (File.Exists(TenTepNguon)) //Gọi hàm Exists của lớp File để kiểm tra tệp tin TenTepNguon có tồn tại hay không
                        { //Tệp tin tồn tại
                            Console.WriteLine("Doi ten tep " + TenTepNguon + " thanh " + TenTepDich);
                            //Gọi hàm Move của lớp File để đổi tên tệp tin có đường dẫn tệp nguồn chứa
                            //trong TenTepNguon thành tệp tin có tên mới theo đường dẫn chứa trong TenTepDich                            
                            File.Move(TenTepNguon, TenTepDich);
                        }
                        break;
                    case "3":
                        Console.WriteLine("SAO CHEP TEP TIN");
                        Console.Write("Nhap duong dan tep nguon: ");
                        string TepNguon = Console.ReadLine();
                        Console.Write("Nhap duong dan tep dich de sao chep: ");
                        string TepDich = Console.ReadLine();
                        if (File.Exists(TepNguon))
                        {
                            Console.WriteLine("Sao chep tep " + TepNguon + " sang " + TepDich);
                            //Goi hàm Copy của lớp File để sao chép tệp tin từ TepNguon sang TepDich
                            File.Copy(TepNguon, TepDich);
                        }
                        break;
                    case "4":
                        Console.WriteLine("XOA TEP TIN");
                        Console.Write("Nhap duong dan tep tin can xoa: ");
                        string TepCanXoa = Console.ReadLine();
                        if (File.Exists(TepCanXoa))
                        {
                            Console.WriteLine("Xoa tep tin " + TepCanXoa);
                            //Gọi hàm Delete của lớp File để xóa tệp tin có đường dẫn chứa trong TepCanXoa
                            File.Delete(TepCanXoa);
                        }
                        break;
                    case "5":
                        return;
                }
                Console.Write("\nNhan phim bat ky de tiep tuc...");
                Console.ReadKey();
            }
        }

        static void Main()
        {
            ChuongTrinh10_5();
        }
    }
}
