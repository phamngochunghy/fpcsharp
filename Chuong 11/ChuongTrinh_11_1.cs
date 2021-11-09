//Chương trình ứng dụng quản lý sinh viên
using System;
using System.IO;
namespace Chuong11
{
    class ChuongTrinh_11_1
    {
        //Khai báo dữ liệu sinh viên
        struct student
        {
            public string CodeS, nameS;
            public int year;
            public int mark1, mark2;
        }
        //Khai báo dữ liệu mảng lưu trữ thông tin các sinh viên
        static student[] listS;
        static string filename = "D:\\Student.txt";
        //Đọc tệp và lưu trữ thông tin vào mảng
        static void readFile()
        {
            StreamReader sr;
            listS = new student[1];
            if (!File.Exists(filename)) Console.WriteLine("tep khong ton tai");
            else
            {
                sr = File.OpenText(filename);
                string line;
                int i = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    Array.Resize(ref listS, i + 1);
                    string[] sub = line.Split('#');
                    listS[i].CodeS = sub[0];
                    listS[i].nameS = sub[1];
                    listS[i].year = int.Parse(sub[2]);
                    listS[i].mark1 = int.Parse(sub[3]);
                    listS[i].mark2 = int.Parse(sub[4]);
                    i++;
                }
                sr.Close();
            }
        }
        //Hiển thị thông tin các sinh viên ra màn hình
        static void printList()
        {
            Console.WriteLine("STT\tMaSV\t\tHo ten\t\t Nam sinh  Diem k1  Diem k2");
            for (int i = 0; i < listS.Length; i++)
                Console.WriteLine("{0}\t{1}\t{2}\t  {3}\t   {4}\t   {5} ", i + 1, listS[i].CodeS, listS[i].nameS, listS[i].year, listS[i].mark1, listS[i].mark2);
        }
        //Tìm kiếm gần đúng theo tên
        static int Search(student[] sv, string name)
        {
            for (int i = 0; i < sv.Length; i++)
            {
                if (sv[i].nameS.IndexOf(name) >= 0) return i;
            }
            return -1;
        }
        //Thống kê sinh viên
        static int studentGood(student[] sv)
        {
            int count = 0;
            for (int i = 0; i < sv.Length; i++)
                if ((sv[i].mark1 + sv[i].mark2) / 2 >= 80)
                    count++;
            return count;
        }
        static void Main(string[] args)
        {
            readFile();
            printList();
            int vt = Search(listS, "Huyen");
            if (vt > -1)
                Console.WriteLine("Tim thay SV Huyen tai vi tri: " + vt);
            else
                Console.WriteLine("Khong tim thay SV Huyen trong danh sach");
            Console.WriteLine("So SV tot " + studentGood(listS));
            Console.ReadKey();
        }
    }
}
