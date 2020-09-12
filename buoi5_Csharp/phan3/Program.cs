using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phan3
{
    class Program
    {
        //1. Viết hàm để hiển thị một chuỗi nhập vào từ bàn phím.
        static void xuatChuoi(string s)
        {
            //s = Console.ReadLine();
            Console.WriteLine(s);
        }



        //2.Viết hàm để nhập và trả về một số thực, nằm trong khoảng min max (optional)
        /// <summary>
        /// trả về một số thực nằm trong khoảng min max
        /// </summary>
        /// <param name="msg">thông điệp nhập </param>
        /// <param name="err">thông điệp lôi</param>
        /// <param name="max">giá trị tối đa</param>
        /// <param name="min">giá trị tối thiểu</param>
        /// <returns></returns>
        static double Nhapdouble(string msg, string err,int max=int.MaxValue,int min=int.MinValue)
        {
            Boolean ok = true;
            int so;
            do
            {
                Console.WriteLine(msg);
                string str = Console.ReadLine();
                ok = int.TryParse(str, out so);
                ok = ok && (so >= min && so <= max);
                if (!ok) Console.WriteLine(err);
            }
            while (!ok);
            return so;
        }



        //3. Viết hàm để nhập và trả về chuỗi, độ dài chuỗi trong khoảng min max (optional)
        /// <summary>
        /// nhập và trả về chuỗi trong độ dài khoảng min max
        /// </summary>
        /// <param name="msg">thông điệp nhập</param>
        /// <param name="err">thông điệp lỗi</param>
        /// <param name="max">độ dài chuỗi tối đa</param>
        /// <param name="min">độ dài chuỗi tối thiểu</param>
        /// <returns></returns>
        static string inpustring(string msg, string err,int max=int.MaxValue,int min=int.MinValue)
        {
            int len;
            string s;
            do
            {
                Console.WriteLine(msg);
                s = Console.ReadLine();
                len = s.Length;
                if (len >= min && len <= max)
                {
                    return s;
                }
                else Console.WriteLine(err);
            }
            while (len != 0);
            return s;
        }
        


        //4.Viết hàm đếm số khoảng trống trong một chuỗi
        /// <summary>
        /// đếm số ký tự trắng trong chuỗi
        /// </summary>
        /// <param name="str">chuỗi nhập vào từ bàn phím</param>
        static void Dem(string str)
        {
            int dem = 0;
            for(int i=0;i<str.Length;i++)
            {
                if (str[i] == ' ')
                    dem++;
                else
                {
                    if (str[i] == '\t')
                        dem += 2;
                }
            }
            Console.WriteLine(dem);
        }



        //5. Viết hàm tính tổng tất cả những số đối xứng trong một mảng số nguyên
        /// <summary>
        /// nhập số nguyên từ bàn phím 
        /// </summary>
        /// <param name="arr">mảng các số nguyên</param>
        static void nhapmang(int[] arr)
        {
            for(int i=0;i < arr.Length ; i++)
            {
                Console.Write("phan tu thu {0} : ", (i+1));
                arr[i] = int.Parse(Console.ReadLine());
            }
        }
        /// <summary>
        /// xuất mảng số nguyên ra màn hình
        /// </summary>
        /// <param name="arr">mảng các số nguyên</param>
        static void xuatmang(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "\t");

            }
            Console.WriteLine();
        }
        /// <summary>
        /// kiểm tra xem số đó có là số đối xứng hay k
        /// </summary>
        /// <param name="a">số nguyên</param>
        /// <returns></returns>
        static Boolean ktraSoDX(int a)
        {
            
            int somoi = 0;
            for(int i=a;i!=0;i=i/10)
            {
                somoi = somoi * 10 + i % 10;
            }
            return (somoi == a); 
        }
        /// <summary>
        /// tính tổng tất cả những số đối xứng trong mảng số nguyên
        /// </summary>
        /// <param name="arr">mảng nhập vào từ bàn phím</param>
        static void tinhTong(int[] arr)
        {
            int tong = 0;
            for(int i=0;i<arr.Length;i++)
            {
                if(ktraSoDX(arr[i]))
                {
                    Console.WriteLine(arr[i]);
                    tong += arr[i];
                }
            }
            Console.WriteLine("tong cua cac so doi xung trong mang la: "+tong);
        }



        //6.Viết hàm trả về chuỗi có độ dài bằng N cuối cùng có thể tìm thấy trong một mảng chuỗi.

        static void nhapMangString(string[] str,int n)
        {
            for(int i=0;i<n;i++)
            {
                Console.Write("Nhap chuoi {0}: ", (i + 1));
                str[i] = Console.ReadLine();
            }
        }
        //tao ra email tu ten mảng tên nguoi: tên+Chữ cái đầu của họ và tên đệm ghép lại
        // nếu đã tồn tại tên đó rồi thì thêm chữ số đằng sau
        static string taoEmail(string s)
        {
            string[] s1 = s.Split(' ');
            string email = "";
            email = s1[s1.Length - 1].Substring(0, 1).ToUpper() + s1[s1.Length - 1].Substring(1).ToLower();
            
            for (int i = 0;i<s1.Length-1 ; i++)
            {
                email += s1[i].Substring(0, 1).ToUpper();
            }
            
            return email;
        }
        static void taoMangEmail(string[] str,int DoDai)
        {
            for(int i=0;i<DoDai;i++)
            {
               str[i]=taoEmail(str[i]);
            }
            for(int i=0;i<DoDai-1;i++)
            {
                for(int j=i+1;j<DoDai;j++)
                {
                    if(str[i]==str[j])
                    {
                        str[i] += (i+1).ToString();
                    }
                }
            }
            for(int i=0;i<DoDai;i++)
            {
                str[i] += "@gmail.com";
                Console.WriteLine(str[i]);
            }
            
        }
        static void Main(string[] args)
        {
            string[] Hoten = new string[4];
            nhapMangString(Hoten, 4);
            taoMangEmail(Hoten, 4);

            Console.ReadKey(); 
            
        }
    }
}
