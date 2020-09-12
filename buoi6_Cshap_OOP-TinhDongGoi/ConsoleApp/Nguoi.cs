using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Nguoi
    {
        string[] SubName;
        string hoten;
        public int MaSo { get; set; }
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
        public string Ho
        {
            get
            {
                SubName = hoten.Split(' ');
                Ho = SubName[0].Substring(0);
                return Ho;
            }
            private set { }
        }
        public string Dem
        {
            get
            {
                SubName = hoten.Split(' ');
                for(int i=1;i<SubName.Length-1;i++)
                {
                    Dem += SubName[i].Substring(0);
                }
                return Dem;
            }
            private set { }
        }
        public string Ten
        {
            get
            {
                SubName = hoten.Split(' ');
                Ten = SubName[SubName.Length - 1].Substring(0);
                return Ten;
            }
            private set { }
        }
        public Nguoi()
        {
            Console.Write("nhap ma so: ");
            MaSo = int.Parse(Console.ReadLine());
            Console.Write("nhap ho ten: ");
            HoTen = Console.ReadLine();
            Console.Write("nhap nam thang ngay sinh : ");
            NgaySinh = DateTime.Parse(Console.ReadLine());
        }
        public Nguoi(int maSo, string hoTen,DateTime ngaySinh)
        {
            MaSo = maSo;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
        }
        public void hien()
        {
            Console.WriteLine("{0} co ten la {1} sinh ngay {2}", MaSo, HoTen, NgaySinh.ToLongDateString());
        }
    }
}
