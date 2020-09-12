using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vidu
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullName = Console.ReadLine();
            fullName = fullName.Trim();
            string[] SubName = fullName.Split(' ');
            string Result = "";
            for (int i = 0; i < SubName.Length-1; i++)
            {
                string FirstChar = SubName[i].Substring(0, 1);
                
                SubName[i] = FirstChar.ToUpper();
                Result += SubName[i];
            }
            string ten = "";
            for (int i = SubName.Length-1; i>=0 ; i++)
            {
                string FirstChar = SubName[i].Substring(0, 1);
                string OtherChar = SubName[i].Substring(1);
                SubName[i] = FirstChar.ToUpper() + OtherChar.ToLower();
                ten= SubName[i];
                break;
            }
            Console.WriteLine(ten + Result + "@hvitclass.com");
            //Console.WriteLine(" Ho ten cua ban la: " + Result);
            //Console.WriteLine(SubName);
            Console.ReadKey();
        }
    }
}
