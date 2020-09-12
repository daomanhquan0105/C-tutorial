using System;
using System.Collections.Generic;
using System.Text;

namespace Bai4.Helper
{
    enum ErrType
    {
        Succes,
        Failed,
        NotExist,
        Empty
    }
    class ErrHelper
    {
        public static void Log(ErrType et)
        {
            switch(et)
            {
                case ErrType.Succes:
                    Console.WriteLine("thanh cong");
                    break;
                case ErrType.Failed:
                    Console.WriteLine("that bai");
                    break;
                case ErrType.NotExist:
                    Console.WriteLine("khong ton tai");
                    break;
                case ErrType.Empty:
                    Console.WriteLine("danh sach trong");
                    break;
            }
        }
    }
}
