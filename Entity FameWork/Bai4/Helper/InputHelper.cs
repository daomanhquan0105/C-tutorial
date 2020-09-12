using System;
using System.Collections.Generic;
using System.Text;

namespace Bai4.Helper
{
    enum InputType
    {
        insert,
        delete,
        update
    }
    class InputHelper
    {
        public static int NhapInt(string msg, string err, int min = int.MinValue, int max = int.MaxValue)
        {
            Boolean ok = true;
            int ret;
            do
            {
                Console.WriteLine(msg);
                ok = int.TryParse(Console.ReadLine(), out ret);
                ok = ok && (ret >= min && ret <= max);
                if (!ok) Console.WriteLine(err);
            }
            while (!ok);
            return ret;
        }
        public static string NhapStr(string msg, string err, int min = int.MinValue, int max = int.MaxValue)
        {
            Boolean ok = true;
            string ret;
            do
            {
                Console.WriteLine(msg);
                ret = Console.ReadLine();
                ok = ret.Length >= min && ret.Length <= max;
                if (!ok) Console.WriteLine(err);
            }
            while (!ok);
            return ret;
        }
        public static DateTime NhapDate(string msg, string err, DateTime min, DateTime max)
        {
            Boolean ok = true;
            DateTime ret;
            do
            {
                Console.WriteLine(msg);
                ok = DateTime.TryParse(Console.ReadLine(), out ret);
                ok = ok && (ret >= min && ret <= max);
                if (!ok) Console.WriteLine(err);
            }
            while (!ok);
            return ret;
        }
    }
}
