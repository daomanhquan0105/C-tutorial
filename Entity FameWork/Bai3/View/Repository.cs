using System;
using System.Collections.Generic;
using System.Text;
using Bai3.Controller;
using Bai3.Helper;
using Bai3.Model;
namespace Bai3.View
{
    class Repository
    {
        ActionController Ac = new ActionController();
        public void Menu()
        {
            Console.Clear();
            Console.WriteLine("1. Them 1 ngay hoc vao khoa hoc da ton tai");
            Console.WriteLine("2. Sua thong tin 1 hoc vien da ton tai");
            Console.WriteLine("3. Xoa 1 khoa hoc");
            Console.WriteLine("4. Tim Kiem cac hoc vien theo ho ten va khoa hoc ma ho dang theo");
            Console.WriteLine("5. Tinh doanh thu cua trung tam cua 1 khoa hoc bat ky");
            Console.WriteLine("Chon: ");
            char c = Console.ReadKey().KeyChar;
            Console.WriteLine();
            ThucThi(c);
        }
        private void ThucThi(char c)
        {
            switch(c)
            {
                case '1':
                    ErrHelper.Log(Ac.ThemNgayHoc(new NgayHoc(InputType.insert)));
                    break;
                case '2':
                    ErrHelper.Log(Ac.SuaTTHV(new HocVien(InputType.update)));
                    break;
                case '3':
                    ErrHelper.Log(Ac.XoaKhoaHoc(new KhoaHoc(InputType.delete)));
                    break;
                case '4':
                    ErrHelper.Log(Ac.TimKiemHV(new HocVien(InputType.searh)));
                    break;
                case '5':
                    ErrHelper.Log(Ac.TinhDoanhThu(new KhoaHoc(InputType.searh)));
                    break;
            }
            Console.ReadKey();
            Menu();
        }
    }
}
