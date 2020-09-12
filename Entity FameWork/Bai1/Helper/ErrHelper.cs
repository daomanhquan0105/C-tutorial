using System;
using System.Collections.Generic;
using System.Text;

namespace Bai1.Helper
{
    enum ErrType
    {
        emptylist,//danh sách trống
        notexist,//không tồn tại
        failed,//thất bại
        succes,//thành Công
        existed,//đã tồn tại
        full
    }
    class ErrHelper
    {
        public static void Log(ErrType et)
        {
            switch(et)
            {
                case ErrType.emptylist:
                    Console.WriteLine("danh sach trong");
                    break;
                case ErrType.notexist:
                    Console.WriteLine("khong ton tai");
                    break;
                case ErrType.failed:
                    Console.WriteLine("that bai");
                    break;
                case ErrType.succes:
                    Console.WriteLine("thanh cong");
                    break;
                case ErrType.existed:
                    Console.WriteLine("da ton tai");
                    break;
            }
        }
    }
}
