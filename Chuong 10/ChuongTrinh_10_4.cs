//Chương trình 10.4
using System;
using System.IO;
namespace Chuong10
{
    class ChuongTrinh_10_4
    {
        static void NhapDuLieu(out string HoVaTen, out int ChiSoTruoc, out int ChiSoSau)
        {
            Console.Write("Nhap ten sinh vien:");
            HoVaTen = Console.ReadLine();
            do
            {
                Console.Write("Nhap Chi so thang truoc:");
                ChiSoTruoc = int.Parse(Console.ReadLine());
                Console.Write("Nhap Chi so thang nay:");
                ChiSoSau = int.Parse(Console.ReadLine());

            } while (!(0 <= ChiSoTruoc && ChiSoTruoc <= ChiSoSau));
        }
        static void GhiTep(string HoVaTen, int ChiSoTruoc, int ChiSoSau)
        {
            StreamWriter sw = new StreamWriter(@"D:\TienDien.in");
            sw.WriteLine(HoVaTen);
            sw.WriteLine("{0} {1}", ChiSoTruoc, ChiSoSau);
            sw.Close();
        }
        static long TinhTienDien(int ChiSoTruoc, int ChiSoSau)
        {
            return (ChiSoSau - ChiSoTruoc) * 3000;
        }

        static void Main()
        {
            int ThangTruoc, ThangNay;
            string HoVaTen;
            NhapDuLieu(out HoVaTen, out ThangTruoc, out ThangNay);
            GhiTep(HoVaTen, ThangTruoc, ThangNay);
            Console.WriteLine("Tien dien phai tra: {0}", TinhTienDien(ThangTruoc, ThangNay));
            Console.ReadKey();
        }
    }
}
