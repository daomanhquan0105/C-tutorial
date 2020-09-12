using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai15._1
{
    class Program
    {
        static DateTime nhapDateTime(string msg, string errNhap, string errKhoang, 
            DateTime max, DateTime min)
        {
            DateTime NgaySinh;

            Boolean ok = true;
            do
            {
                Console.WriteLine(msg);
                ok = DateTime.TryParse(Console.ReadLine(), out NgaySinh);
                if (!ok) Console.WriteLine(errNhap);
                else
                {
                    ok = (NgaySinh <= max && NgaySinh >= min);
                    if (!ok) Console.WriteLine(errKhoang);
                    else Console.WriteLine("chuc mung ban nhap dung");
                }
            }
            while (!ok);
            return NgaySinh;
        }
        static void Main(string[] args)
        {
            DateTime ngaysinh = nhapDateTime("nhap: ", "can phai nhap dang datetime!!",
                "can phai nhap trong khoang tu 2002/1/1 den 2013/12/31",new DateTime(2013,12,31),
                new DateTime(2002,1,1));
            Console.ReadKey();
        }
    }
}
