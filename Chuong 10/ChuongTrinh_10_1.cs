//Chương trình 10.1
using System;
using System.IO;
class ChuongTrinh_10_1
{
    static void Main()
    {
        string FileName;
        string CauTho;
        string TenBaiTho;
        bool ok;
        ConsoleKeyInfo kt;
        do
        {
            Console.Write("Nhap vao ten tep chua bai tho:");
            FileName = Console.ReadLine();
            ok = false;
            if (File.Exists(FileName))
            {
                Console.WriteLine("Tep nay da ton tai ban co muon ghi de C/K?");
                kt = Console.ReadKey();
                if (kt.KeyChar == 'c' || kt.KeyChar == 'C')
                    ok = false;
                else
                    ok = true;
            }
        } while (ok);
        StreamWriter myfile = File.CreateText(FileName);
        Console.WriteLine("\t\tBAN HAY NHAP VAO MOT BAI THO BAN YEU THICH\n");
        Console.Write("Nhap vao ten bai tho:"); TenBaiTho = Console.ReadLine();
        myfile.WriteLine("\t\t{0}", TenBaiTho);
        myfile.WriteLine();
        int i = 0;
        do
        {
            Console.Write("Cau {0}:", ++i);
            CauTho = Console.ReadLine();
            myfile.WriteLine("{0}:{1}", i, CauTho);
            Console.WriteLine("Ban co muon nhap tiep C/K");
            kt = Console.ReadKey();
        } while (kt.KeyChar == 'c' || kt.KeyChar == 'C');
        myfile.Close();
    }
}
