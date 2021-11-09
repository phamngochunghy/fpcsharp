//Chương trình 10.2
using System;
using System.IO;
class ChuongTrinh_10_2
{
    public static void Main()
    {
        try
        {
            using (StreamReader sr = new StreamReader("D:/TapTho.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Khong the doc duoc noi dung tep");
            Console.WriteLine(e.Message);
        }
        Console.ReadKey();
    }
}
