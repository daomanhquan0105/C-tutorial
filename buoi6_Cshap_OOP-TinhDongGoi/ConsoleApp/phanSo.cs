using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class PhanSo
    {
        public int Tu { get; set; }
        public int Mau { get; set; }
        public PhanSo(int tu,int mau)
        {
            Tu = tu;
            Mau = mau;
        }
        public PhanSo()
        {
            Console.WriteLine("nhap tu so: ");
            Tu = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap mau so: ");
            Mau = int.Parse(Console.ReadLine());
            
        }
        public void hien()
        {
            Console.WriteLine($"phan so la : {Tu}/{Mau}");
        }
        //PhanSo gan(int t,int m)
        //{
        //    PhanSo a = new PhanSo(t, m);
        //    return a;
        //}
        private static PhanSo toigian(int t,int m)
        {
            PhanSo a = new PhanSo(t, m);
            while(t!=m)
            {
                if (t > m) t -= m;
                else m -= t;
            }
            a.Tu = a.Tu / t;
            a.Mau = a.Mau / t;
            return a;
        }
        public static PhanSo cong(PhanSo a,PhanSo b)
        {
            a= a = toigian(a.Tu, a.Mau);
            b = toigian(b.Tu, b.Mau);
            return toigian(a.Tu * b.Mau + b.Tu * a.Mau, a.Mau * b.Mau);
        }  
        public static PhanSo tru(PhanSo a, PhanSo b)
        {
            a = toigian(a.Tu, a.Mau);
            b = toigian(b.Tu, b.Mau);
            return toigian(a.Tu * b.Mau - b.Tu * a.Mau, a.Mau * b.Mau);
            
        }
    }
}
