using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai8
{
    class Program
    {
       //"Nhập vào một chuỗi và hiển thị dạng đảo ngược của chuỗi vừa nhập.
       // Sau đó in ra dạng viết hoa của chuỗi đó.
       //Cuối cùng thực hiện đếm số chữ cái, số chữ số, số ký tự đặc biệt trong một chuỗi."
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            char[] arr = s.ToCharArray();
            string s1 = "";//chuyen doi chuoi hoa sang thuong
            for(int i=0;i<s.Length;i++)
            {
                if (char.IsLower(arr[i]))
                {
                    s1 += char.ToUpper(arr[i]);
                }
                else s1 += char.ToLower(arr[i]);
            }
            Console.WriteLine(s1);
            string s2= "";
            for(int i=s.Length-1;i>=0;i--)
            {
                s2 += s[i];
            }
            Console.WriteLine(s2);
            int demchu = 0;
            int demso = 0;
            int demKTDB = 0;
            for(int i=0;i<s.Length;i++)
            {
                if (s[i] >= 'a' && s[i] <= 'z' || s[i] >= 'A' && s[i] <= 'Z')
                    demchu++;
                else
                {
                    if (s[i] >= '0' && s[i] <= '9')
                    {
                        demso++;
                    }
                   else
                        demKTDB++;
                }
            }
            Console.WriteLine("so cac chu so la: " + demso);
            Console.WriteLine("so cac ky tu dac biet la: " + demKTDB);
            Console.WriteLine("so cac chu la: " + demchu);
            Console.ReadKey();
        }
    }
}
