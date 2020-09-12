using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class MaTran
    {

        public int SoHang { get; set; }
        public int SoCot { get; set; }
        public int[,] Matrix { get; set; }
        public void HienMT()
        {

            for (int i = 0; i < SoHang; i++)
            {
                for (int j = 0; j < SoCot; j++)
                {
                    Console.Write(Matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        public int[,] NhapMT()
        {
            Matrix = new int[SoHang, SoCot];
            for (int i = 0; i < SoHang; i++)
            {
                for (int j = 0; j < SoCot; j++)
                {
                    Console.Write($"[{i+1},{j+1}]=");
                    Matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return Matrix;
        }
        public MaTran Cong2MT(MaTran mt1, MaTran mt2)
        {
            int[,] a = new int[SoHang, SoCot];
            int kt = 0;
            if (mt1.SoHang == mt2.SoHang && mt1.SoCot == mt2.SoCot)
            {
                for (int i = 0; i < mt1.SoHang; i++)
                {
                    for (int j = 0; j < mt2.SoCot; j++)
                    {
                        a[i, j] = mt1.Matrix[i, j] + mt2.Matrix[i, j];
                    }
                }
                kt = 1;
            }
            else
            {
                Console.WriteLine("Khong cong duoc vi khac so hang hoac so cot!");
                kt = 0;
            }
            if (kt == 1)
            {
                return new MaTran(SoHang, SoCot, a);
            }
            else
                return null;
           
        }
        public MaTran()
        {
            Console.Write("nhap so hang: ");
            SoHang = int.Parse(Console.ReadLine());
            Console.Write("nhap so cot: ");
            SoCot = int.Parse(Console.ReadLine());
            Matrix = NhapMT();
        }
        public MaTran(int soHang, int soCot, int[,] maTrix)
        {
            SoHang = soHang;
            SoCot = soCot;
            Matrix = maTrix;
        }
    }
}
