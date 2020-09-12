using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp
{
    class HamChinh
    {
        static void Main(string[] args)
        {
            List<HocVien> lst = new List<HocVien>()
            {
                new HocVien(),new HocVien(),new HocVien(),new HocVien()
            };
            
            
            Console.WriteLine("nhap ho ten hv can tim: ");
            string s = Console.ReadLine();
            List<HocVien> lst1 = HocVien.timKiemHV(lst, s);
            
            if (lst1.Count == 0) Console.WriteLine("0");
            else
            {
                lst1.ForEach(x => x.Hien());
            }
           
            Console.ReadKey();
        }
    }
}
