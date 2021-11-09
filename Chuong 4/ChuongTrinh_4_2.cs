//Chương trình 4.2
using System;
class ChuongTrinh_4_2
{
    static void Main()
    {
        int month, year, sumday;
        Console.Write("Nhap thang=");
        month = int.Parse(Console.ReadLine());
        Console.Write("Nhap year=");
        year = int.Parse(Console.ReadLine());
        switch (month)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12: sumday = 31; break;
            case 4:
            case 6:
            case 9:
            case 11: sumday = 30; break;
            case 2:
                if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                    sumday = 29;
                else
                    sumday = 28;
                break;
            default: sumday = 0; break;
        }
        if (sumday > 0)
            Console.Write("So ngay cua thang {0}/{1} la {2} ngay", month, year, sumday);
        Console.ReadKey();
    }
}
