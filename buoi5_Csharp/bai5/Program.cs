using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai5
{
    class Program
    {
        //Cho trước 2 biến Acc và Pss dạng chuỗi. Viết chương trình C# kiểm tra Account và Password 
        //nhập vào có đúng không?(Trùng với Acc và Pss cho trước)

        static void Main(string[] args)
        {
            string Acc = Console.ReadLine();
            string Pss = Console.ReadLine();
            if (Acc == Pss) Console.WriteLine(Acc+" giong chuoi "+ Pss);
            else Console.WriteLine(Acc + " khac chuoi " + Pss);
            Console.ReadKey();
        }
        
    }
}
