using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai16
{
    class Program
    {
        static List<DateTime> timThu4(DateTime x, DateTime y)
        {
            List<DateTime> lst = new List<DateTime>();
            for(DateTime i=x;i<y;i=i.AddDays(1))
            {
                if (i.DayOfWeek.ToString() == "Wednesday")
                    lst.Add(i);
            }
            return lst;
        }
        static void hien(DateTime x)
        {
            
            Console.WriteLine(x.DayOfWeek+" "+x.ToShortDateString());
        }
        static void Main(string[] args)
        {
            DateTime mydate = DateTime.Now;
            //Console.WriteLine(mydate.ToLongDateString());
            //Console.WriteLine(mydate.AddDays(3).ToLongDateString());
            //Console.WriteLine(mydate.GetDateTimeFormats());
            DateTime date = new DateTime(2019,2,1);
            List<DateTime> lst = timThu4(date, mydate);
            lst.ForEach(x => hien(x));
            Console.Read();
        }
    }
}
