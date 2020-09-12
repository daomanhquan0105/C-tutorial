using System;
using System.Collections.Generic;
using System.Text;

namespace Bai1.Helper
{
    enum InputType
    {
        Insert,
        Update,
        Delete
    }
    class InputHelper
    {
        public static int NhapInt(string msg,string err,int min=int.MinValue,int max=int.MaxValue)
        {
            int so;
            Boolean ok=true;
            do
            {
                Console.WriteLine(msg);
                ok = int.TryParse(Console.ReadLine(), out so);
                ok = ok && (so >= min && so <= max);
                if (!ok) Console.WriteLine(err);
            }
            while (!ok);
            return so;
        }
        public static string NhapStr(string msg, string err, int min = int.MinValue, int max = int.MaxValue)
        {
            String str;
            Boolean ok = true;
            do
            {
                Console.WriteLine(msg);
                str = Console.ReadLine();
                ok = ok && (str.Length >= min && str.Length <= max);
                if (!ok) Console.WriteLine(err);
            }
            while (!ok);
            return str;
        }
        public static DateTime NhapDate(string msg, string err, DateTime min,DateTime max)
        {
            DateTime ngaySinh;
            Boolean ok = true;
            do
            {
                
                Console.WriteLine(msg);
                ok = DateTime.TryParse(Console.ReadLine(), out ngaySinh);
                ok = ok && (ngaySinh >= min && ngaySinh <= max);
                if (!ok) Console.WriteLine(err);
            }
            while (!ok);
            return ngaySinh;
        }
    }
}
