//Ví dụ 7.9
using System;
namespace Chuong7
{
    class Vidu_7_9
    {
        static void Mang2Chieu()
        {
            //Khai báo và cấp phát bộ nhớ mảng 2 chiều
            int[,] a = new int[2, 3];
            //Gán giá trị cho các phần tử của mảng
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 3; j++)
                    a[i, j] = i * j;
            //In nội dung mảng ra màn hình
            //Mỗi hàng trên một dòng
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                    Console.Write("{0} ", a[i, j]);
                Console.WriteLine();
            }
        }
    }
}
