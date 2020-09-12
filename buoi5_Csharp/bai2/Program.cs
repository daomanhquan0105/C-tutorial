using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    class Program
    {
        /*
         * 2	"Viết chương trình C# nhập hai số thực a, b từ bàn phím. 
In ra màn hình giá trị S là tổng lập phương của hai số vừa nhập.
In ra số chia hết cho 10 lớn nhất mà vẫn nhỏ hơn S"	

         */
        static void Main(string[] args)
        {
            int a, b ;
            Console.WriteLine("nhap 2 so a va b: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            int s = a + b;
            Console.WriteLine("tong cua 2 so vua nhap la : "+s);
            //Console.WriteLine(s);
            Console.WriteLine("so nho hon tong va chia het cho 10 la : ");
            for(int i=s-1;i>=0;i--)
            {
                if (i % 10 == 0)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
