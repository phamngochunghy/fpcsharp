using System;
namespace ViDu_5_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ví dụ 5.8
            int n, sum;
            //Nhập n và kiểm tra điều kiện n>=1
            do
            {
                Console.Write("Nhap n: ");
                n = int.Parse(Console.ReadLine());
                if (n < 1) Console.WriteLine("Ban nhap sai, moi nhap lai: ");
            } while (n < 1);
            //Tính tổng các số từ 1->n, kết quả lưu vào biến sum
            sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine("Tong tu 1 den {0} la: {1}", n, sum);
        }
    }
}
