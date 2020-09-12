using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class LopHoc
    {
        public int MaLop { get; set; }
        public string TenLop { get; set; }
        public int SiSo { get; set; }
        public string DiaChi { get; set; }
        public string GiaoVienCN { get; set; }
        //thông qua nhập liệu từ bàn phím
        public LopHoc()
        {
            Console.Write("ma lop hoc: ");
            MaLop = int.Parse(Console.ReadLine());
            Console.Write("ten lop hoc: ");
            TenLop = Console.ReadLine();
            Console.Write("si so cua lop hoc: ");
            SiSo = int.Parse(Console.ReadLine());
            Console.Write("dia chi cua lop hoc: ");
            DiaChi = Console.ReadLine();
            Console.Write("ten GVCN cua lop hoc: ");
            GiaoVienCN = Console.ReadLine();
        }
        //thông qua truyền dữ liệu
        public LopHoc(int maLop,string tenLop,int siSo,string diaChi,string giaoVienCN)
        {
           MaLop = maLop;
           TenLop = tenLop;
           SiSo = siSo;
           DiaChi = diaChi;
           GiaoVienCN = giaoVienCN;
        }
   
        public void hien()
        {
            Console.WriteLine("{0} co ma lop la {1} o {2}" +
                "\nlop co {3} hoc sinh va co GVCN la {4}"
                , TenLop, MaLop, DiaChi, SiSo, GiaoVienCN);
        }
    }
}
