using System;
namespace ViDu_4_3
{
    class Program
    {
        //Ví dụ 4.3
        static void Vidu43()
        {
            int a, b;
            {
                int a;//Dòng khai báo này không được phép
                int c;
                a = 5;
                b = 6;
                c = 7;
                {
                    int d;
                    int c; //Dòng khai báo này không được phép
                    c = a + b;
                    d = a - b;
                }
                Console.Write("\na = {0}\nb = {1}", a, b);
                Console.Write("\na = {0}\nb = {1}\na + b = {2}", a, b, c);
                //Lệnh sau có lỗi khi truy cập biến d bên ngoài khối - chưa khai báo biến d
                Console.Write("\na = {0}\nb = {1}\na - b = {2}", a, b, d);
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            

        }
    }
}