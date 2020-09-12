using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class HocVien
    {
        string[] subName;
        string hoten;
        double hocphi;
        public int MaHocVien { get; set; }
        public string HoTen
        {
            get
            {
               
                hoten = hoten.Trim();
                while (hoten.IndexOf("  ") != -1)
                {
                    hoten = hoten.Replace("  ", " ");
                }
                
                return hoten;
            }
           set { hoten = value; }
        }
        public DateTime NgaySinh { get; set; }
        public double HocPhi
        {
            get
            {
                if(hocphi>3*(10^6))
                {
                    hocphi -= hocphi * 0.05;
                }
                return hocphi;
            }
            set { hocphi = value; }
        }
        public string Email
        {
            get
            {
                string email = "";
               
                subName = HoTen.Split(' ');
                email += subName[subName.Length - 1] + "@edusolution.com";
                return email;
            }
            private set { }
        }
        public HocVien()
        {
            Console.Write("nhap ma hoc vien: ");
            MaHocVien = int.Parse(Console.ReadLine());
            Console.Write("nhap ho ten hoc vien: ");
            HoTen = Console.ReadLine();
            Console.Write("nhap ngay sinh hoc vien: ");
            NgaySinh = DateTime.Parse(Console.ReadLine());
            Console.Write("nhap hoc hoc phi: ");
            HocPhi = double.Parse(Console.ReadLine());
        }
        public HocVien(int maHocVien,string hoTen,DateTime ngaySinh,double hocPhi)
        {
            MaHocVien = maHocVien;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            HocPhi = hocPhi;
        }
        public void Hien()
        {
            Console.WriteLine($"{MaHocVien} co ho ten: {HoTen} co email la:{Email} ");
        }
        public static List<HocVien> timKiemHV(List<HocVien> lst,string s)
        {
            return lst.FindAll(x => x.HoTen==s); 
        }
    }
}
