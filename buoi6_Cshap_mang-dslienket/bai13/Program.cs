using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai13
{
    class Program
    {
        static int NhapInt(string msg, string err,string errKhoang,int max=int.MaxValue,int min=int.MinValue)
        {
            Boolean ok = true;
            int so;
            do
            {
                Console.WriteLine(msg);
                ok = int.TryParse(Console.ReadLine(), out so);
                if (!ok) Console.WriteLine(err);
                ok = ok && (min <= so && so <= max);
                if (!ok) Console.WriteLine(errKhoang);
               
            }
            while (!ok);
            return so;
        }

        static void Main(string[] args)
        {
            int x = NhapInt("nhap so:", "can phai nhap Ky tu so: ", 
                "so phai trong khong tu [20,100]", 100, 20);
            Console.ReadKey();
        }
    }
}
