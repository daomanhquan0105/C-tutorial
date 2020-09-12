using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4
{
    class Program
    {
        //Viết chương trình C# để tìm tổng dãy số: S = 1/1 + 1/2 + 1/3 + 1/4 + ... với số phần tử nhập từ bàn phím.

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double s = 0;
            for(double i=1;i<=n;i+=1)
            {
                s += 1 / i;
            }
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
