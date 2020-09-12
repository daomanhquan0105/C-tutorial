using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phan2_1
{
    class Program
    {
        //1.Viết chương trình C# khai báo một mảng số nguyên và hiển thị các phần tử ra màn hình 
        static void nhapXuatMang(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("nhap phan thu thu {0}: ", (i + 1));
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + "\t");
            }
        }
        //2.Viết chương trình C# tính tổng các phần tử của mảng số thực
        static void tinhTong(double[] arr,int n)
        {
            int tong = 0;
            for(int i=0;i<n;i++)
            {
                tong += i;
            }
            Console.WriteLine(tong);
        }
        //3.Viết chương trình C# tính tích các số nguyên tố của mảng số nguyên
        static void tichSNT(int[] arr,int n)
        {
            int tich = 1;
            for(int i=0;i<n;i++)
            {
                if (arr[i] > 1)
                {
                    if (arr[i] == 2 || arr[i] == 3 || arr[i] == 5 || arr[i] == 7)
                        tich *= arr[i];
                    else
                    {
                        for (int j = 3; j < Math.Sqrt(arr[i]); i += 2)
                        {
                            if (arr[i] % j == 0) break;
                            else
                                tich *= arr[i];
                        }
                    }
                }   
            }
            Console.WriteLine(tich);
        }
        //4.: Viết chương trình C# nhập vào một chuỗi và một ký tự c, 
        //đếm số lần xuất hiện của ký tự c trong chuỗi đó
        static void demKT(string str)
        {
            Console.WriteLine("nhap vao ky tu can tim: " );
            char c = Convert.ToChar(Console.Read());
            int dem = 0;
            for(int i=0;i<str.Length;i++)
            {
                if (str[i] == c)
                    dem++;
            }
            Console.WriteLine("so ky tu {0} trong chuoi {1} la: {2} ", c, str, dem);
        }

        //5.Chia một mảng số nguyên thành 2 mảng số nguyên chẵn và lẻ, hiển thị ra màn hình kết quả
        static void xuatMang(int[] arr, int n)
        {
            for(int i=0;i<n;i++)
            {
                Console.Write(arr[i] + "\t");
            }
            Console.WriteLine();
        }
        static void chiaMangChanLe(int[] arr,int n)
        {
            int[] chan = new int[arr.Length];
            int[] le = new int[arr.Length];
           
            int i = 0;
            int j = 0;
            int k=0;
            while( i<n)
            {
                if(arr[i]%2==0)
                {
                    chan[j] = arr[i];
                    j++;
                }
                else
                {
                    le[k] = arr[i];
                    k++;
                }
                i++;
            }
            Console.WriteLine();
            Console.Write("phan tu mang chan: ");
            xuatMang(chan, j);
            Console.WriteLine();
            Console.Write("phan tu mang le: ");
            for (int a = 0; a < k; a++)
            {
                Console.Write(le[a] + "\t");
            }
        }

        //6.Viết chương trình C# để trộn (ghép) 2 mảng, điều kiện ghép là phần tử mảng đó phải là số nguyên tố.
        // Hiển thị mảng cuối cùng ra màn hình.
        static Boolean ktrSNT( int a)
        {
            if(a>1)
            {
                if (a == 2 || a == 3 || a == 5 || a == 7)
                    return true;
                else
                {
                    if (a % 2 == 0) return false;
                    else
                    {
                        for (int i = 3; i < Math.Sqrt(a); i+=2)
                        {
                            if (a % i == 0)
                                return false;
                            else
                                return true;
                        }
                    }
                }
            }
            return false;
        }
        static void ghepMangSNT(int[] arr1,int n, int[] arr2,int m)
        {
            int[] arr3 = new int[n + m] ;
            int i = 0;
            int j = 0;
            while(i<n)
            {
                if(ktrSNT(arr1[i])==true)
                {
                    arr3[j] = arr1[i];
                    j++;
                }
                i++;
            }
            int k = 0;
            while (k < m)
            {
                if (ktrSNT(arr2[k]) == true)
                {
                    arr3[j] = arr2[k];
                    j++;
                }
                k++;
            }
            Console.WriteLine("mang moi la cac so nguyen to cua 2 mang tren la: ");
            for(int a=0;a<j;a++)
            {
                Console.Write(arr3[a] + "\t");
            }
        }

        //7.Viết chương trình C# sắp xếp mảng số nguyên theo thứ tự tăng dầnc
        static void sapXepMang(int[] arr,int n)
        {
            for(int i=0;i<n-1;i++)
            {
                for(int j=i+1;j<n;j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int c = arr[i];
                        arr[i] = arr[j];
                        arr[j] = c;
                    }
                }
            }
            Console.WriteLine("\nmang sau khi sap xep la: ");
            for(int i=0;i<n;i++)
            {
                Console.Write(arr[i] + "\t");
            }
        }

        //8.Cho một chuỗi nhập vào từ bàn phím, sắp xếp chuỗi theo thứ tự từ điển
        static void SapXepKTChuoi(string str)
        {
            int[] gio = new int[256];
            
            for (int i = 0; i < str.Length ; i++)
            {
                gio[str[i]]++;
            }
            for(int i=0;i<256;i++)
            {
                if(gio[i]>0)
                {
                    for(int j=0;j<gio[i];j++)
                    {
                        Console.Write(Convert.ToChar(i)+" ");
                    }
                }
            }
        }

        //10.Chèn một phần tử vào vị trí thứ k vào mảng n phần tử.
        static void chenThemPT(int[] arr,int n)
        {
            //nhapXuatMang(arr, n);
            n = n + 1;
            Console.Write("nhap vi tri phan tu muon chen: ");
            int vtChen = int.Parse(Console.ReadLine());
            Console.Write("nhap phan tu muon chen: ");
            int x =Convert.ToInt32(Console.ReadLine());
            for (int i = n-1; i > 0; i--)
            {
                if ((i-1) != vtChen)
                {
                    arr[i] = arr[i-1];
                }
                else
                {
                    arr[i] = arr[i-1];
                    arr[i - 1] = x;
                    break; 
                }
            }
            for(int i=0;i<n;i++)
            {
                Console.Write(arr[i] + "\t");
            }
        }
        static void Main(string[] args)
        {
            int n = 5;
            int[] a =new int[n+10];
            nhapXuatMang(a, n);
            Console.WriteLine();
            chenThemPT(a,n);
            
            Console.ReadKey();
        }
    }
}
