using System;
namespace ViDu_5_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ví dụ 5.6
            //Nhập n và kiểm tra điều kiện n dương
            int n;
            do
            {
                Console.Write("Nhap n: ");
                n = int.Parse(Console.ReadLine());
                if (n < 0) Console.WriteLine("Ban nhap sai, moi nhap lai: ");
            } while (n < 0);
        }
    }
}
