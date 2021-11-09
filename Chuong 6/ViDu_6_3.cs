using System;
namespace ViDu_6_3
{
    //Ví dụ 6.3
    class Program
    {
        static private int Tong(in int a, int b)
        {
            int T = a + b;
            return T;
        }
        static void Main(string[] args)
        {
            int x = 10, y = 20, t;
            t = Tong(x, y); //Lời gọi không có in
            t = Tong(in x, y);//Lời gọi có in            
        }
    }
}
