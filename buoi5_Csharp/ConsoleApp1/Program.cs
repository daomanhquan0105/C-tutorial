using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhap ten: ");
            string HoTen = Console.ReadLine();
            HoTen = HoTen.Trim();
            while(HoTen.IndexOf("  ")!=-1)
            {
                HoTen = HoTen.Replace("  "," ");
            }
            string[] subName = HoTen.Split(' ');
            string ret = subName[subName.Length - 1].Substring(0, 1).ToUpper() +
                subName[subName.Length - 1].Substring(1).ToLower();
            for (int i = 0; i < subName.Length - 1; i++)
            {
                ret += subName[i].Substring(0, 1).ToUpper();
            }
            Console.WriteLine(ret + "@hvitclan.com");
            //Console.WriteLine(HoTen);
            Console.ReadKey();
        }
    }
}
