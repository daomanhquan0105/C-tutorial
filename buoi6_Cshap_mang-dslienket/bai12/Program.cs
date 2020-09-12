using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai12
{
    class Program
    {
        static int nhapInt(string msg,string err)
        {
            Boolean ok = true;
            int so;
            do
            {
                Console.WriteLine(msg);
                ok = int.TryParse(Console.ReadLine(), out so);
                if (!ok) Console.WriteLine(err);
                else Console.WriteLine("chuc mung ban da nhap dung(^_^)!!");
            }
            while (!ok);
            return so;
        }
        static void Main(string[] args)
        {
            int x = nhapInt("nhap so: ", "can phai nhap la Ky tu so!!!");
            Console.ReadKey();
        }
    }
}
