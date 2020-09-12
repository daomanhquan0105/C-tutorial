using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Class1
    {
        public int Tuoi { get; set; }
        string strName;
        public string Ten
        {
            get
            {
                string ret = strName.Trim();
                while(ret.IndexOf("  ")!=-1)
                {
                    ret = ret.Replace("  "," ");
                }
                return ret;
            }
            set { strName = value; }
        }
        public Class1()
        {
            Console.Write("nhap ten: ");
            Ten = Console.ReadLine();
            Console.Write("nhap tuoi: ");
            Tuoi = int.Parse(Console.ReadLine());
        }
        public void Hien()
        {
            Console.WriteLine("{0} co tuoi la {1}", Ten, Tuoi);
        }
    }
}
