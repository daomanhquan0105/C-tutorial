using System;
using System.Collections.Generic;
using System.Text;
using Bai1.Controller;
using Bai1.Model;
using Bai1.Helper;

namespace Bai1.View
{
    class Repository
    {
        HocSinhController hs = new HocSinhController();
        public void Menu()
        {
            Console.Clear();
            Console.WriteLine("1. Them mot hoc sinh vao lop da ton tai moi lop co toi da 20 hs");
            Console.WriteLine("2. Sua thong tin cua mot hoc sinh da ton tai");
            Console.WriteLine("3. Xoa 1 hoc sinh");
            Console.WriteLine("4. Chuyen lop cho 1 hoc sinh");
            Console.WriteLine("Chon: ");
            char c = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Action(c);
        }
        private void Action(char c)
        {
            switch(c)
            {
                case '1':
                    ErrHelper.Log(hs.ThemHS(new HocSinh(InputType.Insert)));
                    break;
                case '2':
                    ErrHelper.Log(hs.SuaTTHS(new HocSinh(InputType.Update)));
                    break;
                case '3':
                    ErrHelper.Log(hs.XoaHS(new HocSinh(InputType.Delete)));
                    break;
                case '4':
                    ErrHelper.Log(hs.ChuyenLopChoHS(new HocSinh(InputType.Update)));
                    break;
            }
            Console.ReadKey();
            Menu();
        }
    }
}
