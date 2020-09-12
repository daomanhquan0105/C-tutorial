using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai14
{
    class Program
    {
        static string NhapString(string msg,string err,int max=int.MaxValue,int min=int.MinValue)
        {
            string s;
            Boolean ok;
            do
            {
                Console.WriteLine(msg);
                s = Console.ReadLine();
                ok = (s.Length <= max && s.Length >= min);
                if (!ok) Console.WriteLine(err);
            }
            while (!ok);
            return s;
        }
        static void Main(string[] args)
        {
            string s = NhapString("nhap chuoi ky tu: ", "can phai nhap chuoi trong khoang [20,50] ky tu!!"
                , 50, 20);
            Console.ReadKey();
        }
    }
}
