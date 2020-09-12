using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai6
{
    class Program
    {
        //"Tìm độ dài n một chuỗi được nhập vào từ bàn phím. 
        //Sau đó in tất cả các ký tự từ vị trí n/4 đến n/2 của chuỗi, mỗi ký tự in trên một dòng"
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int n = s.Length;
            for(int i=n/4;i<=n/2;i++)
            {
                Console.WriteLine(s[i]);
            }
            Console.ReadKey();
        }
    }
}
