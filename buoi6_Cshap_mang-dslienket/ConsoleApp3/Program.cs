using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void hien (string s)
        {
            Console.WriteLine(s);
        }
        static void Main(string[] args)
        {
            List<string> lst = new List<string>()
            {
                {"aaaaaaaaaaaaaaaaaaaaaaa"},
                {"nguyen van A" },
                {"nguyen van B dahfka" }
            };
            List<string> lst1 = lst.FindAll(x => x.Length >= 15);

            lst1.ForEach(x => hien(x));
            Console.WriteLine("ket thuc");
            Console.ReadKey();
        }
    }
}
