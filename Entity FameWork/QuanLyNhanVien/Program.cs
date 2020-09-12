using System;
using System.Collections.Generic;
using System.Linq;
using QuanLyNhanVien.model;

namespace QuanLyNhanVien
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var db=new Connection())
            {
                int x = int.Parse(Console.ReadLine());
                NhanVien nv = db.NhanViens.SingleOrDefault(y=>y.MaNV==x);
                if (nv != null)
                {
                    Console.WriteLine($"{nv.MaNV} -- {nv.TenNV} -- {nv.NgaySinh.ToShortDateString()}");
                }
                else Console.WriteLine("khong co nv");
            }
        }
    }
}
