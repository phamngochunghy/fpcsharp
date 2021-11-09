using System;
namespace ViDu_5_4_Sua
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ví dụ 5.4
            //Sửa lại vòng lặp
            int counter = 0;
            while (counter <= 9)
            {
                Console.WriteLine("Number: " + counter);
                //tăng biến đếm lên 1 đơn vị
                counter++;
            }
        }
    }
}
