using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class DongHo
    {
        public int Gio { get; set; }
        public int Phut { get; set; }
        public int Giay { get; set; }
        public bool LaBuoiSang
        {
            get
            {
                return (Gio <= 12);
            }
            private set { }
        }
        private int nhapInt(string msg,string err,int max=int.MaxValue,int min=int.MinValue)
        {
            int so;
            Boolean ok = true;
            do
            {
                Console.WriteLine(msg);
                ok = int.TryParse(Console.ReadLine(), out so);
                ok = ok && (so >= min && so <= max);
                if (!ok) Console.WriteLine(err);
            }
            while (!ok);
            return so;
        }

        public void hien()
        {
            Console.WriteLine($"{Gio}:{Phut}:{Giay}");
            if (LaBuoiSang) Console.WriteLine("la buoi sang");
            else
            {
                if (Gio > 24) Console.WriteLine();
                else
                {
                    if(!LaBuoiSang) Console.WriteLine("la buoi chieu");
                }
            }
        }
        public DongHo()
        {
            Gio = nhapInt("nhap gio: ", "can phai nhap so nguyen va trong khoang [0,24]", 24, 0);
            Phut = nhapInt("nhap phut: ", "can phai nhap so nguyen va trong khoang [0,60]", 60, 0);
            Giay = nhapInt("nhap giay: ", "can phai nhap so nguyen va trong khoang [0,60]", 60, 0);
        }
        /// <summary>
        /// nhap gio phut giay
        /// </summary>
        /// <param name="gio">giờ có giá trị trong khoảng [0,24]</param>
        /// <param name="phut">giây có giá trị trong khoảng [0,60]</param>
        /// <param name="giay">giay có giá trị trong khoảng [0,60]</param>
        public DongHo(int gio,int phut,int giay)
        {
            Gio = gio;
            Phut = phut;
            Giay = giay;
        }
    }
}
