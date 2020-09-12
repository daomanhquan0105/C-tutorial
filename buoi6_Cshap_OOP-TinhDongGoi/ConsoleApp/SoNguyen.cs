using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class SoNguyen
    {
        int giaTri;
        public int GiaTri
        {
            get {  return giaTri; }
            set
            {
                giaTri = value;
                LaSoChan = (giaTri % 2 == 0);
            }
        }
        public bool LaSoChan { get; private set; }
        public bool LaNguyenTo
        {
            get
            {
                Boolean ktr = true;
                int x = giaTri;
                if(x>1)
                {
                    if (x == 2 || x == 3 || x == 5)
                        ktr = true;
                    else
                    {
                        if (x % 2 == 0)
                        {
                            ktr = false;
                        }
                        else
                        {
                            for (int i = 3; i < Math.Sqrt(x); i += 2)
                            {
                                if (x % i == 0)
                                {
                                    ktr = false;
                                    break;
                                }
                                
                            }
                        }
                    }
                }
                return ktr;
            }
            private set { }
        }
        public bool LaSoDoiXung
        {
            get
            {
                int x = giaTri;
                int a=0;
                for(int i=x;i!=0;i=i/10)
                {
                    a = a * 10 + i % 10;
                }
                return (x==a);
            }
            private set { }
        }
        SoNguyen gan(int gt)
        {
            SoNguyen a=new SoNguyen(gt);
            return a;
        }
        public static int Cong(SoNguyen a,SoNguyen b)
        {
            return (a.GiaTri + b.GiaTri);
        }
        public SoNguyen(int gT)
        {
            GiaTri = gT;
        }
        public SoNguyen()
        {
            GiaTri = int.Parse(Console.ReadLine());
        }
        private int nhapInt(string msg,string err)
        {
            Boolean ok = true;
            do
            {
                Console.WriteLine(msg);
                ok = int.TryParse(Console.ReadLine(), out giaTri);
                if (!ok) Console.WriteLine(err);
            }
            while (!ok);
            return giaTri;
        }
        public void hien()
        {
            Console.WriteLine($"{GiaTri} {LaSoChan} la so chan va {LaNguyenTo} la nguyen to");
        }
    }
    
}
