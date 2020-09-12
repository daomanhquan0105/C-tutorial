using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thuAAAAAAAA
{
    class HocVien
    {
        string[] subName;
        string hoten;
        double hocphi;
        public int MaHocVien { get; set; }
        public string HoTen { get; set; }
        
        public DateTime NgaySinh { get; set; }
        public string Ho
        {
            get
            {
                subName = HoTen.Split(' ');
                return Ho;
            }
            private set { }
        }
        public double HocPhi
        {
            get
            {
                if (hocphi > 3 * (10 ^ 6))
                {
                    hocphi -= hocphi * 0.05;
                }
                return hocphi;
            }
            set { hocphi = value; }
        }
        //public string Email
        //{
        //    get
        //    {
        //        subName = HoTen.Split(' ');
        //        Email = Ho + subName[subName.Length - 1].Substring(0)+ "“@edusolution.com";
        //        return Email;
        //    }
        //    private set { }
        //}
        public HocVien()
        {
            Console.Write("nhap ma hoc vien: ");
            MaHocVien = int.Parse(Console.ReadLine());
            Console.Write("nhap ho ten hoc vien: ");
            HoTen = Console.ReadLine();
            //Console.Write("nhap ngay sinh hoc vien: ");
            //NgaySinh = DateTime.Parse(Console.ReadLine());
            //Console.Write("nhap hoc hoc phi: ");
            //HocPhi = double.Parse(Console.ReadLine());
        }
        public HocVien(int maHocVien, string hoTen, DateTime ngaySinh, double hocPhi)
        {
            MaHocVien = maHocVien;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            HocPhi = hocPhi;
        }
        public void Hien()
        {
            Console.WriteLine($"{MaHocVien} co ho ten: {HoTen} co email la: ");
        }
        public static List<HocVien> timKiemHV(List<HocVien> lst, string s)
        {
            return lst.FindAll(x => x.HoTen.Contains(s));

        }
    }
}
