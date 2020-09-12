using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai19
{
    class Program
    {
        //19	Bài toán 3x+1 là một bài toán thú vị và chưa có lời giải trong toán học.
        //Hãy xem video này https://www.youtube.com/watch?v=5mFpVDpKX70 để viết hàm mô phỏng việc in ra dãy của 3x+1 với n<100.	

        static int moPhong(int so)
        {
            int a = so;
            if (a % 2 == 0)
            {
                a = a / 2;
                Console.WriteLine(a);
                while (a % 2 == 0)
                {
                    a = a / 2;
                    Console.WriteLine(a);
                }
                while(a!=1)
                {
                    if (a % 2 == 0)
                    {
                        Console.Write(a + " la chan\t");
                       
                        Console.Write("{0}/2=",a);
                        a = a / 2;
                        Console.Write(a);
                    }
                    else
                    {
                        Console.Write("3*{0}+1=",a);
                        a = 3 * a + 1;
                        Console.WriteLine(a);
                    }
                }
            }
            else
            {
                Console.Write(a);
                while (a != 1)
                {
                    if (a % 2 == 0)
                    {
                        
                        a = a / 2;
                        Console.WriteLine(a);
                    }
                    else
                    {
                        
                        a = 3 * a + 1;
                        Console.WriteLine(" -> "+a);
                    }
                }
            }
            return a;
        }

        static void Main(string[] args)
        {
            int a = 7;
            int x = moPhong(a);
            Console.Read();
        }
    }
}
