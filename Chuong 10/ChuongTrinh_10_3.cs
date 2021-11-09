//Chương trình 10.3
using System;
using System.IO;
class ChuongTrinh_10_3
{
    static void Main()
    {
        try
        {
            StreamReader sr = File.OpenText(@"D:\DuLieu.txt");
            string[] con = sr.ReadToEnd().Split(' ');
            double m = double.MinValue, tg;
            foreach (string x in con)
                if (x.Length > 0)
                {
                    Console.Write(x + "   ");
                    tg = double.Parse(x);
                    if (m < tg)
                        m = tg;
                }
            sr.Close();
            StreamWriter sw = File.AppendText(@"D:\DuLieu2.txt");
            sw.WriteLine(); sw.Write(m);
            sw.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine("Khong dung duong dan");
        }
        Console.ReadKey();
    }
}
