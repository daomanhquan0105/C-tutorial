using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class ThoiGian
    {
        DateTime x;
        public int Ngay { get; set; }
        public int Thang { get; set; }
        public int Nam { get; set; }
        public Boolean LaNamNhuan
        {
            get
            {
                return (DateTime.IsLeapYear(Nam));
            }
            private set { }
        }
        public int Thu
        {
            get
            {
                x = new DateTime(Nam, Thang, Ngay);
                string s = x.DayOfWeek.ToString();
                switch(s)
                {
                    case "Monday":
                        return 2;
                    case "Thursday":
                        return 5;
                    case "Wednesday":
                        return 4;
                    case "Tuesday":
                        return 3;
                    case "Friday":
                        return 6;
                    case "Saturday":
                        return 7;
                    case "Sunday":
                        return 8;
                    default:
                        Console.WriteLine("khong phai thu!!");
                        break;
                }
                return 0;
            }
            private set { }
        }
        public void hien()
        {
            if(Thu==8)
            {
                Console.WriteLine($"chu nhat ngay {Ngay} thang {Thang} nam {Nam}");
            }
            else
            {
                Console.WriteLine($"thu {Thu} ngay {Ngay} thang {Thang} nam {Nam}");
            }
            if (LaNamNhuan) Console.WriteLine("la nam nhuan");
            else Console.WriteLine("khong phai la nam nhuan");
        }
        public static DongHo Tinh(ThoiGian tgTruoc, ThoiGian tgSau)
        {
            DateTime timeTruoc = new DateTime(tgTruoc.Nam, tgTruoc.Thang, tgTruoc.Ngay);
            DateTime timeSau = new DateTime(tgSau.Nam, tgSau.Thang, tgSau.Ngay);
            TimeSpan a = timeSau.Subtract(timeTruoc);
            int soGio = a.Days * 24+a.Hours;
            int soPhut = a.Minutes;
            int soGiay = a.Seconds;
            DongHo x = new DongHo(soGio,soPhut,soGiay);
            return x;
        }
        public ThoiGian()
        {
            Nam = nhapNam("nhap nam: ", "can phai nhap la so nguyen trong [1,2200]");
            Thang = nhapThang("nhap thang: ", "can phai nhap la so nguyen trong [1,12]");
            Ngay = nhapNgay("nhap ngay: ", 
                "can phai nhap trong nhung ngay trong thang 2 của nam nhuan khoang [1,29]",
               "can phai nhap trong nhung ngay trong thang 2 của nam khong nhuan khoang [1,28]"
               , "thang này co 30 ngay nên chi nhap đuoc trong khoang [1,30]",
               "thang nay co 31 ngay nen chi nhap đuoc trong khoang [1,31]");
        }
        public ThoiGian(int nam,int thang,int ngay)
        {
            Nam = nam;
            Thang = thang;
            Ngay = ngay;
        }
        /// <summary>
        /// nhap ngay cho ngay cho thang
        /// </summary>
        /// <param name="msg">thông báo nhập</param>
        /// <param name="err0">cần phải nhập trong những ngày trong tháng 2 của năm nhuận khỏang [1,29]</param>
        /// <param name="err1">cần phải nhập trong những ngày trong tháng 2 của năm không nhuận khỏang [1,28]</param>
        /// <param name="err2">tháng này có 30 ngay nên chỉ nhập được trong khoảng [1,30]</param>
        /// <param name="err3">tháng này có 31 ngay nên chỉ nhập được trong khoảng [1,31]</param>
        /// <returns></returns>
        private int nhapNgay(string msg,string err0,string err1,string err2,string err3)
        {
            int so;
            Boolean ok = true;
            do
            {
                Console.WriteLine(msg);
                ok = int.TryParse(Console.ReadLine(), out so);
                if(LaNamNhuan && Thang==2)
                {
                    ok = ok && (so >= 1 && so <= 29);
                    if (!ok) Console.WriteLine(err0);
                }
                if(!LaNamNhuan)
                {
                    if(Thang==2)
                    {
                        ok = ok && (so >= 1 && so <= 28);
                        if (!ok) Console.WriteLine(err1);
                    }
                    else
                    {
                        if(Thang==4 || Thang ==6 || Thang==9 || Thang ==11)
                        {
                            ok = ok && (so >= 1 && so <= 30);
                            if (!ok) Console.WriteLine(err2);
                        }
                        else
                        {
                            ok = ok && (so >= 1 && so <= 31);
                            if (!ok) Console.WriteLine(err3);
                        }
                    }
                }
            }
            while (!ok);
            return so;
        }
        private int nhapThang(string msg, string err)
        {
            int so; Boolean ok = true;
            do
            {
                Console.WriteLine(msg);
                ok = int.TryParse(Console.ReadLine(), out so);
                ok = ok && (so >= 1 && so <= 12);
                if (!ok) Console.WriteLine(err);
            }
            while (!ok);
            return so;
        }
        private int nhapNam(string msg,string err)
        {
            int so; Boolean ok = true;
            do
            {
                Console.WriteLine(msg);
                ok = int.TryParse(Console.ReadLine(), out so);
                ok = ok && (so >= 1 && so <= 2200);
                if (!ok) Console.WriteLine(err);
            }
            while (!ok);
            return so;
        }
    }
}
