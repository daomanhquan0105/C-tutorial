using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai17
{
    class Program
    {
        //17	Nhập một ma trận mxn ký tự và 1 số n. 
        //Hãy trả lại ma trận biến đổi từ ma trận ban đầu bằng cách dịch mỗi ký tự trong ma trận ban đầu đi n bước.
        //Ví dụ ký tự ‘a’ dịch 3 bước sẽ là ký tự ‘d’	
        static void nhapMatran(char[,] C,int sohang,int socot)
        {
            for(int i=0;i<sohang;i++)
            {
                for (int j = 0; j < socot; j++)
                {
                    Console.Write("ky tu thu [{0},{1}]: ", (i + 1), (j + 1));
                    C[i, j] =Convert.ToChar(Console.ReadKey().KeyChar);
                    //int c = Console.Read();
                    Console.WriteLine();
                }
            }
        }
        static void hien(char[,] C, int sohang, int socot)
        {
            for (int i = 0; i < sohang; i++)
            {
                for (int j = 0; j < socot; j++)
                {
                    Console.Write("ky tu thu [{0},{1}]={2}\t", (i + 1), (j + 1),C[i,j]);
                }
                Console.WriteLine();
            }
        }
        static char[,] dichKyTu(char[,] C, int sohang, int socot)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] X = new char[sohang, socot];
            for (int i = 0; i < sohang; i++)
            {
                for (int j = 0; j < socot; j++)
                {
                    X[i, j] =Convert.ToChar(C[i,j]+n);   
                }
            }
            return X;
        }
        static void Main(string[] args)
        {
            char[,] C = new char[2, 2];
            nhapMatran(C, 2, 2);
            Console.Clear();
            hien(C, 2, 2);
            char[ , ] X = dichKyTu(C, 2, 2);
            hien(X, 2, 2);
            Console.ReadKey();
        }
    }
}
