//Ví dụ 7.6
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Chuong7
{
    class Vidu_7_6
    {
        static void InMang(int[] a, int n, string ThongBao)
        {
            Console.WriteLine(ThongBao);
            for (int i = 0; i < n; i++)
            {
                Console.Write("a[{0}]={1} ", i, a[i]);
            }
            Console.WriteLine();
        }
        static void ThaoTacTrenMang()
        {
            //Khai báo và tạo mảng 10 phần tử cho mảng a
            int[] a = new int[10];
            //Nhập giá trị các phần tử của mảng a
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Nhap phan tu thu {0} cho mang: ", i);
                a[i] = int.Parse(Console.ReadLine());
            }
            InMang(a, 10, "Mang duoc nhap la:");
            //Tìm và in ra vị trí phần tử chứa giá trị cần tìm trên mảng
            Console.WriteLine("Gia tri 10 xuat hien tai vi tri: {0}", Array.IndexOf(a, 10));
            //Sắp xếp mảng
            Array.Sort(a);
            InMang(a, 10, "Mang sau khi sap xep:");
            //Đảo ngược trật tử mảng
            Array.Reverse(a);
            InMang(a, 10, "Mang sau dao nguoc trat tu cac phan tu la:");
        }
        static void Main(string[] args)
        {
            ThaoTacTrenMang();
            Console.ReadKey();
        }
    }
}
