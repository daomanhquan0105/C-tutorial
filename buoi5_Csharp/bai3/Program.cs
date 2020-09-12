using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3
{
    class Program
    {
        //Nhập vào một số n từ bàn phím. In ra bảng nhân từ 1 đến n của số đó.

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i=1;i<=n;i++)
            {
                for(int j=1;j<=n;j++)
                {
                    Console.Write("{0}*{1}={2}\t", i, j, (i * j));
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
