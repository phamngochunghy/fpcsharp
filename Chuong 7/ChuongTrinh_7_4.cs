//Chương trình 7.4
using System;
class ChuongTrinh_7_4
{
    static int[] a;
    static void NhapMang()
    {
        int i = 0, x;
        ConsoleKeyInfo kt;
        Console.WriteLine("Ban hay nhap vao mot day so nguyen");
        do
        {
            Console.Write("So nguyen thu {0}:", i);
            x = int.Parse(Console.ReadLine());
            Array.Resize(ref a, ++i);
            a[i - 1] = x;
            Console.Write("Ban co nhap tiep C/K");
            kt = Console.ReadKey();
            Console.WriteLine();
        } while (kt.KeyChar == 'c' || kt.KeyChar == 'C');
    }
    static void HienMang()
    {
        Console.WriteLine("Cac phan tu chan la:");
        foreach (int i in a)
            if (i % 2 == 0)
                Console.Write("{0}\t", i);
        Console.WriteLine("\nCac phan tu le la:");
        foreach (int i in a)
            if (i % 2 != 0)
                Console.Write("{0}\t", i);
    }
    static void Main()
    {
        NhapMang();
        HienMang();
        Console.ReadKey();
    }
}
