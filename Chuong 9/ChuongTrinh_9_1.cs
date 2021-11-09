//Chương trình 9.1
using System;
class ChuongTrinh_9_1
{
    struct KieuSV
    {
        public string HoTen;
        public int Viet, Doc;
    }
    static KieuSV[] DSSV;
    static int SoLuong;
    static void NhapDSSV()
    {
        Console.Write("So thi sinh can nhap:");
        do
        {
            SoLuong = int.Parse(Console.ReadLine());
        } while (SoLuong < 0);
        DSSV = new KieuSV[SoLuong];
        for (int i = 0; i < SoLuong; i++)
        {
            Console.Write("Ho va ten thi sinh: ");
            DSSV[i].HoTen = Console.ReadLine();
            do
            {
                Console.Write("Diem Viet: ");
                DSSV[i].Viet = int.Parse(Console.ReadLine());
            } while (DSSV[i].Viet < 0 || DSSV[i].Viet > 10);
            do
            {
                Console.Write("Diem Doc: ");
                DSSV[i].Doc = int.Parse(Console.ReadLine());
            } while (DSSV[i].Doc < 0 || DSSV[i].Doc > 10);
        }
    }
    static void DSDiem()
    {
        int i;
        Console.Write("STT\tHo va Ten\tDiem Viet\tDiem Noi\tTong diem\n");
        for (i = 0; i < SoLuong; ++i)
            Console.WriteLine("{0}\t{1}\t{2}\t\t{3}\t\t{4}", i + 1, DSSV[i].HoTen, DSSV[i].Viet, DSSV[i].Doc, DSSV[i].Viet + DSSV[i].Doc);
    }
    //In danh sách những sinh viên có điểm đạt (điểm >= 5)
    static void DSSVDat()
    {
        int i;
        Console.Write("STT\tHo va Ten\tDiem Viet\tDiem Noi\tTong diem\n");
        for (i = 0; i < SoLuong; ++i)
        {
            if (DSSV[i].Viet >= 5 && DSSV[i].Doc >= 5)
                Console.WriteLine("{0}\t{1}\t{2}\t\t{3}\t\t{4}", i + 1, DSSV[i].HoTen, DSSV[i].Viet, DSSV[i].Doc, DSSV[i].Viet + DSSV[i].Doc);
        }
    }
    //Tính tổng điểm cao nhất
    static void TongDiemCaoNhat()
    {
        int MAX, i;
        MAX = DSSV[0].Viet + DSSV[0].Doc;
        for (i = 0; i < SoLuong; i++)
        {
            if (DSSV[i].Viet + DSSV[i].Doc > MAX)
                MAX = DSSV[i].Viet + DSSV[i].Doc;
        }
        //In ra danh sách các sinh viên có điểm 2 môn cao nhất (= MAX)
        Console.Write("STT\tHo va Ten\tTong diem\n");
        int j = 0;
        for (i = 0; i < SoLuong; i++)
        {
            if (DSSV[i].Viet + DSSV[i].Doc == MAX)
            {
                Console.WriteLine("{0}\t{1}\t{2}", ++j, DSSV[i].HoTen, DSSV[i].Viet + DSSV[i].Doc);
            }
        }
    }
    //Sắp xếp danh sách
    static void SapXep()
    {
        int i, j;
        KieuSV TG = new KieuSV();
        for (i = 0; i < SoLuong - 1; i++)
            for (j = i + 1; j < SoLuong; j++)
                if (DSSV[j].Viet > DSSV[i].Viet)
                {
                    TG = DSSV[i];
                    DSSV[i] = DSSV[j];
                    DSSV[j] = TG;
                }
    }
    static int Menu()
    {
        Console.Write("\n\n\n\t\t\t1. Nhap danh sach thi sinh");
        Console.Write("\n\t\t\t2. Hien thi danh sach thi sinh");
        Console.Write("\n\t\t\t3. Danh sach thi sinh dat ");
        Console.Write("\n\t\t\t4. Cac thi sinh co tong diem cao nhat");
        Console.Write("\n\t\t\t5. Sap xep danh sach thi sinh");
        Console.Write("\n\t\t\t6. Thoat khoi chuong trinh");
        Console.Write("\n\t\t\tBan hay chon mot muc (1->6): ");
        int Tam;
        Tam = int.Parse(Console.ReadLine());
        return Tam;
    }
    static void Main()
    {
        Console.Clear();
        do
        {
            switch (Menu())
            {
                case 1: NhapDSSV(); break;
                case 2: DSDiem(); Console.ReadKey(); break;
                case 3: DSSVDat(); Console.ReadKey(); break;
                case 4: TongDiemCaoNhat(); Console.ReadKey(); break;
                case 5:
                    SapXep(); Console.Write("Danh sach sau khi sau xep:\n");
                    DSDiem(); Console.ReadKey(); break;
                case 6: Environment.Exit(0); break; // Thoat khoi chuong trinh 
            }
            Console.Clear();
        } while (true);
    }
}
