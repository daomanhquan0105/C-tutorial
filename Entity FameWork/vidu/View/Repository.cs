using System;
using System.Collections.Generic;
using System.Text;
using Bai2.Controller;
using Bai2.Helper;
using Bai2.Model;
namespace Bai2.View
{
    
    class Repository
    {
        ActionController Ac = new ActionController();
        public void Menu()
        {
            Console.Clear();
            Console.WriteLine("1. Them 1 nhan vien vao du an da ton tai");
            Console.WriteLine("2. Sua thong tin 1 du an");
            Console.WriteLine("3. Xoa 1 nhan vien");
            Console.WriteLine("4. Tinh luong cho nhan vien");
            Console.WriteLine("5. Chon: ");
            char c = Console.ReadKey().KeyChar;
            Console.WriteLine();
            ThucThi(c);
        }
        private void ThucThi(char c)
        {
            switch(c)
            {
                case '1':
                    ErrHelper.Log(Ac.ThemNVVaoDuAn(new PhanCong(InputType.insert)));
                    break;
                case '2':
                    ErrHelper.Log(Ac.SuaTTDuAN(new DuAn(InputType.update)));
                    break;
                case '3':
                    ErrHelper.Log(Ac.XoaNV(new NhanVien(InputType.delete)));
                    break;
                case '4':
                    ErrHelper.Log(Ac.TinhLuong(new NhanVien(InputType.TinhToan)));
                    break;
            }
            Console.ReadKey();
            Menu();
        }
    }
}
