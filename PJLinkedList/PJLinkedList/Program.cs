using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            string mssv, ten, diem;
            QuanLiSV qlsv = new QuanLiSV();
            Console.WriteLine("Nhap so luong SV ( toi da 5 thang):");
            // TAO DANH SACH
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"\nNhap MSSV thang thu {i + 1}:");
                mssv = Console.ReadLine();
                Console.WriteLine($"\nNhap Ten thang thu {i + 1}:");
                ten = Console.ReadLine();
                Console.WriteLine($"\nNhap Diem thang thu {i + 1}:");
                diem = Console.ReadLine();
                SinhVien sv = new SinhVien(mssv, ten, diem);
                qlsv.AddLast(sv);
                Console.WriteLine("-----------------------------------");
            }
            qlsv.PrintList();

        //TAO MENU
        menu:
            Console.WriteLine("\nMuon lam gi tiep theo ?");
            Console.WriteLine("\n1.Them SV vao dau danh sach.");
            Console.WriteLine("\n2.Them SV vao cuoi danh sach.");
            Console.WriteLine("\n3.Them SV X vao sau sinh vien co MSSV .");
            Console.WriteLine("\n4.Them SV X vao truoc sinh vien co MSSV.");
            Console.WriteLine("\n5.Them SV Q vao giua X va Y.");
            Console.WriteLine("\n6.Tim SV X.");
            Console.WriteLine("\n7.Tim min Diem.");
            Console.WriteLine("\n8.Tim max Diem.");

            //ABCDEFGHIJ
            string input = Console.ReadLine();
            int choose;
            if (int.TryParse(input, out (choose)))
            {
                Console.WriteLine($"choose:{choose}");

                switch (choose)
                {
                    case 1:
                        {
                            Console.WriteLine($"\nNhap MSSV :");
                            mssv = Console.ReadLine();
                            Console.WriteLine($"\nNhap Ten :");
                            ten = Console.ReadLine();
                            Console.WriteLine($"\nNhap Diem :");
                            diem = Console.ReadLine();
                            SinhVien sv = new SinhVien(mssv, ten, diem);
                            qlsv.AddFirst(sv);
                            qlsv.PrintList();
                            Console.WriteLine("-----------------------------------");
                            goto menu;
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine($"\nNhap MSSV :");
                            mssv = Console.ReadLine();
                            Console.WriteLine($"\nNhap Ten :");
                            ten = Console.ReadLine();
                            Console.WriteLine($"\nNhap Diem :");
                            diem = Console.ReadLine();
                            SinhVien sv = new SinhVien(mssv, ten, diem);
                            qlsv.AddLast(sv);
                            qlsv.PrintList();
                            Console.WriteLine("\n-----------------------------------");
                            goto menu;
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("\nNhap MSSV truoc sv can them:");
                            string findMSSV = Console.ReadLine();


                            Console.WriteLine($"\nNhap sinh vien can them sau MSSV {findMSSV} ");
                            Console.WriteLine($"\nNhap MSSV :");
                            mssv = Console.ReadLine();
                            Console.WriteLine($"\nNhap Ten :");
                            ten = Console.ReadLine();
                            Console.WriteLine($"\nNhap Diem :");
                            diem = Console.ReadLine();
                            SinhVien sv = new SinhVien(mssv, ten, diem);
                            qlsv.AddAfter(sv, findMSSV);
                            qlsv.PrintList();
                            Console.WriteLine("\n-----------------------------------");
                            goto menu;
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("\nNhap MSSV sau sv can them:");
                            string findMSSV = Console.ReadLine();


                            Console.WriteLine($"\nNhap sinh vien can them sau MSSV {findMSSV} ");
                            Console.WriteLine($"\nNhap MSSV :");
                            mssv = Console.ReadLine();
                            Console.WriteLine($"\nNhap Ten :");
                            ten = Console.ReadLine();
                            Console.WriteLine($"\nNhap Diem :");
                            diem = Console.ReadLine();
                            SinhVien sv = new SinhVien(mssv, ten, diem);
                            qlsv.AddBefore(sv, findMSSV);
                            qlsv.PrintList();
                            Console.WriteLine("\n-----------------------------------");
                            goto menu;
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("\nNhap 2 MSSV  them giua:");
                            string findMSSV = Console.ReadLine();

                            string findMSSV2 = Console.ReadLine();

                            Console.WriteLine($"\nNhap sinh vien can them sau MSSV {findMSSV} va {findMSSV2} ");
                            Console.WriteLine($"\nNhap MSSV :");
                            mssv = Console.ReadLine();
                            Console.WriteLine($"\nNhap Ten :");
                            ten = Console.ReadLine();
                            Console.WriteLine($"\nNhap Diem :");
                            diem = Console.ReadLine();
                            SinhVien sv = new SinhVien(mssv, ten, diem);
                            qlsv.InsertBetween(sv, findMSSV, findMSSV2);
                            qlsv.PrintList();
                            Console.WriteLine("\n-----------------------------------");
                            goto menu;
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("\nNhap  MSSV  can tim:");
                            string findMSSV = Console.ReadLine();
                            qlsv.Find(findMSSV);
                            Console.WriteLine("\n-----------------------------------");
                            goto menu;
                            break;
                        }
                    case 7:
                        {
                            
                            qlsv.FindMinDiem();
                            Console.WriteLine("\n-----------------------------------");
                            goto menu;
                            break;
                        }
                    case 8:
                        {

                            qlsv.FindMaxDiem();
                            Console.WriteLine("\n-----------------------------------");
                            goto menu;
                            break;
                        }

                }
            }




            Console.Read();
        }
    }
}
