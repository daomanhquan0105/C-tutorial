using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai11
{
    class Program
    {
        static string chuanHoaTen(string hoTen)
        {
            string[] s;
            hoTen.Trim();
            while (hoTen.IndexOf("  ") != -1)
            {
                hoTen = hoTen.Replace("  ", " ");
            }
            s = hoTen.Split(' ');
            string result = "";
            result += s[s.Length - 1].Substring(0, 1).ToLower() + s[s.Length - 1].Substring(1).ToLower();
            for (int i = 0; i < s.Length-1; i++)
            {
                result = result + s[i].Substring(0, 1).ToLower();
            }
            return result;
        }
        static void hien(string s)
        {
            s += "@hvitClass.com";
            Console.WriteLine(s);
        }
        static List<string> chuanHoaListTen(List<string> lst)
        {
            List<string> lstCon = new List<string>();
            for (int i = 0; i < lst.Count; i++)
            {
                lstCon.Add(chuanHoaTen(lst[i]));
            }
            int x = 1;
            //lstCon=lstCon.FindAll(x,y =>x==y)
            for (int i = 0; i < lstCon.Count - 1; i++)
            {
                
                for (int j = i + 1; j < lstCon.Count; j++)
                {
                    if (lstCon[i] == lstCon[j])
                    {
                        lstCon[i] += x.ToString();
                        x++;
                    }
                }
            }
            return lstCon;
        }
        static void Main(string[] args)
        {
            List<string> lst = new List<string>
            {
                "dao manh quan","tran duc dung","tran minh duyet","dao manh quan","dao manh quan",
                "dao manh quan"
            };
            List<string> lst1 = new List<string>();

            lst1 = chuanHoaListTen(lst);

            lst1.ForEach(x => hien(x));
            
            Console.ReadKey();
        }
    }
}
