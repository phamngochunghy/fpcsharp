using System;
namespace Chuong9
{   //Ví dụ 9.2
    class ViDu_9_2
    {
        public struct SinhVien
        {
            public string HoVaTen;
            public double Toan, Ly, Hoa, TBC;
        }
        static void Main(string[] args)
        {
            SinhVien sv = new SinhVien();
            Console.WriteLine("Nhap ho va ten sinh vien:");
            sv.HoVaTen = Console.ReadLine();
            Console.WriteLine("Ho va ten sinh vien da nhap la: {0}", sv.HoVaTen);
            Console.ReadKey();
        }
    }
}
