using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai8
{
    class Program
    {
        static int timBCNN(int a,int b)
        {
            if (a==0||b==0) return (a*b);
            else
            {
                if (a == b) return a;
                else
                {
                    int c = a;
                    int d = b;
                    while(c!=d)
                    {
                        if (c > d) c = c - d;
                        else d = d - c;
                    }
                    return (a * b) / c;
                }
            }
        }
        static void Main(string[] args)
        {
            int a = 20;
            int b = 70;
            int c = timBCNN(a, b);
            Console.WriteLine("BCNN({0},{1})={2}",a,b,c);
            Console.ReadKey();
        }
    }
}
