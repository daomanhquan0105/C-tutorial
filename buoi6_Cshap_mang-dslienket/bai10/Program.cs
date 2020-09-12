using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai10
{
    class Program
    {
        static string chuanHoaTen(string hoTen)
        {
            string[] s;
            hoTen.Trim();
            while(hoTen.IndexOf("  ")!=-1)
            {
                hoTen = hoTen.Replace("  ", " ");
            }
            s = hoTen.Split(' ');
            string result = "";
            if (s.Length >= 3)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    result = result + s[i].Substring(0, 1).ToUpper() + s[i].Substring(1).ToLower() + " ";
                }
            }
            return result;
        }
        static List<string> chuanHoaListTen(List<string> lst)
        {
            List<string> lstCon = new List<string>();
            for(int i=0;i<lst.Count;i++)
            {
                lstCon.Add(chuanHoaTen(lst[i]));
            }
            return lstCon;
        }
        static void Main(string[] args)
        {
            List<string> lst = new List<string>
            {
                "dao manh quan","tran duc dung","tran duyet"
            };
            List<string> lst1 = new List<string>();
            lst1=chuanHoaListTen(lst);
            for(int i=0;i<lst1.Count;i++)
            {
                if(lst1[i]!="")
                Console.WriteLine(lst1[i]);
            }
            Console.ReadKey();
        }
    }
}
