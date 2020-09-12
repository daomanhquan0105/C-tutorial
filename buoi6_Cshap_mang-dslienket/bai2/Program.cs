using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    class Program
    {
        //2	Viết hàm trả lại mảng các vị trí số đối xứng từ một mảng truyền vào.
        static void nhapMang(int[] a,int soPT)
        {
            for(int i=0;i<soPT;i++)
            {
                Console.Write("nhap phan tu thu {0}: ", (i+1));
                a[i] = int.Parse(Console.ReadLine());
            }
        }

        static Boolean ktraDoiXung(int so)
        {
            int a = 0;
            for (int j = so; j != 0; j /= 10)
            {
                a = a * 10 + j % 10;
            }
            return (so == a);
        }
        static int[] timSoDoiXung(int[] so, int sophantu)
        {
            int[] VTDoiXung = new int[sophantu];
            int j = 0;
            for(int i=0;i<sophantu;i++)
            {
                if (ktraDoiXung(so[i]))
                {
                    VTDoiXung[j] = i+1;
                    j++;
                }
            }
            return VTDoiXung;
        }
        static void Main(string[] args)
        {
            int[] so = new int[5];
            int sophantu = 5;
            nhapMang(so, sophantu);
            int[] doixung = new int[5];
           doixung= timSoDoiXung(so, sophantu);
            Console.WriteLine("cac so doi xung co vi tri: ");
            for(int i=0;i<5;i++)
            {
                if(doixung[i]!=0)
                Console.Write(doixung[i]+"\t");
            }
            Console.ReadKey();
        }
    }
}
