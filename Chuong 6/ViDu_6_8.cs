using System;
namespace ViDu_6_8
{
    //Ví dụ 6.8
    class Program
    {
        static private int TangTuDong(int a, int b = 1)
        {
            int T = a + b;
            return T;
        }


        static void Main(string[] args)
        {
            Console.WriteLine(TangTuDong(5, 2));//Cho ket qua 7
            Console.WriteLine(TangTuDong(5));//Cho ket qua 6
        }
    }

}
