using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai9
{
    class Program
    {
        //"Nhập vào họ và tên ở dạng chưa chuẩn hóa, hiển thị email có dạng yourname@hvitclan.com
//        Ví dụ: “   Nguyen thi    HuyEn TRANG    ” 
//=> nguyenthihuyentrang @hvitclan.com"

        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            str= str.Replace(" ", "");
            str = str.Replace("\t", "");
            string str1 = "";
            char[] arr = str.ToCharArray();
            for(int i=0;i<str.Length;i++)
            {
                if (char.IsUpper(arr[i]))
                {
                    str1 += char.ToLower(arr[i]);
                }
                else str1 += arr[i];
            }
            Console.WriteLine(str1+"@hvitclan.com");
            Console.ReadKey();
        }
    }
}
