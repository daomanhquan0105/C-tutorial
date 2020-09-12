using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai6
{
    class Program
    {
        static void nhapMatran(int[,] matran,int hang,int cot)
        {
            for(int i=0;i<hang;i++)
            {
                for(int j=0 ; j<cot ;j++)
                {
                    Console.Write("nhap hang {0} cot {1}: = ", (i+1), (j+1));
                    matran[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        static void hienMaTran(int[,] matran,int hang,int cot)
        {
            for (int i = 0; i < hang; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < cot; j++)
                {
                    Console.Write("[{0},{1}] = {2}\t", (i + 1), (j + 1),matran[i,j]);
                }
            }
        }
        static void TinhTich2MaTran(int[,] matran1,int hang1,int cot1,int[,] matran2,int hang2,int cot2)
        {
            int[,] tich2Matran = new int[hang1,cot2];
            int sum = 0;
            if (cot1 != hang2)
                Console.WriteLine("2 ma tran ko hop len!!!!");
            else
            {
                for(int i=0;i<hang1;i++)
                {
                    for(int j=0;j<cot2;j++)
                    {
                        for(int k=0;k<cot1;k++)
                        {
                            sum += matran1[i, k] * matran2[k, j];
                        }
                        tich2Matran[i, j] = sum;
                        sum = 0;
                    }
                }
                hienMaTran(tich2Matran, hang1, cot2);
            }  
        }
        static void Main(string[] args)
        {
            Console.WriteLine("nhap ma tran 1: ");
            int[,] matran1 = new int[2,2];
            nhapMatran(matran1, 2 , 2);
            Console.WriteLine("nhap ma tran 2: ");
            int[,] matran2 = new int[3, 2];
            nhapMatran(matran2, 3, 2);
            Console.Clear();
            Console.WriteLine("ma tran 1 la:");
            hienMaTran(matran1, 2, 2);
            Console.WriteLine("\nma tran 2 la: ");
            hienMaTran(matran2, 3, 2);
            Console.WriteLine("\ntich 2 ma tran tren la: ");
            TinhTich2MaTran(matran1, 2, 2,matran2,3,2);
            

            Console.ReadKey();
        }
    }
}
