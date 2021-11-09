using System;
namespace ViDu_6_4
{
    //Ví dụ 6.4
    class Program
    {
        static private void CongThemHai(ref int a)
        {
            a = a + 2;
        }
        static void Main(string[] args)
        {
            int x = 10;
            CongThemHai(ref x);
        }
    }
}
