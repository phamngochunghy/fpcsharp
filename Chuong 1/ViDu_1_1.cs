using System;

namespace ExceptionTutorrial
{
    class HelloException
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Three");
                int value = 10 / 2;
                Console.WriteLine("Two");
                value = 10 / 1;
                Console.WriteLine("One");
                int d = 0;
                //Lệnh sau phát sinh ngoại lệ
                value = 10 / d;
                //Hai lệnh sau không được thực hiện do phát sinh ngoại lệ
                Console.WriteLine("Let's go!");
                Console.Read();
            }
            catch (Exception ex)
            {
                //Xử lý ngoại lệ, hiển thị thông báo cho người dùng biết
                //Không gây lỗi runtime khiến chương trình bị dừng
                Console.WriteLine("Error! " + ex.Message);
            }
        }
    }
}
