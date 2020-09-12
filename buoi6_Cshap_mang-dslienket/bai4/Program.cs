using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4
{
    
    
    class Program
    {
        static bool ktraSoTang(int a)
        {
            Boolean ktr = true;
            if (a < 10) ktr = false;
            else
            {
                for (int i = a; i != 0; i = i / 10)
                {
                    int sosau = i % 10;
                    int sotruoc = (i % 100 - sosau) / 10;
                    if (sosau < sotruoc)
                    {
                        ktr = false;
                        break;
                    }
                    else
                    {
                        ktr = true;
                    }
                }
            }
            return ktr;
        }
        static int[] mangSoTang(List<int> so)
        {
            int[] soTang = new int[so.Count];
            int i = 0;
            int j = 0;
            while(i<so.Count)
            {
                if (ktraSoTang(so[i]) == true)
                {
                    soTang[j] = so[i];j++;
                }
                i++;
            }
            return soTang;
        }
        static void Main(string[] args)
        {
            //int a = 1234586789;
            //if (ktraSoTang(a) == true)
            //    Console.WriteLine(a+"la so tang");
            //else
            //    Console.WriteLine(a+"ko phai la so tang")
            List<int> so = new List<int> { 12, 47, 89, 98, 74, 48, 14, 32, 56,18,24,479,156,71 };
            int[] sotang = mangSoTang(so);
            for(int i=0;i<sotang.Length;i++)
            {
                if(sotang[i]!=0)
                Console.Write(sotang[i] + "\t");
            }
            Console.ReadKey();
        }
    }
}
