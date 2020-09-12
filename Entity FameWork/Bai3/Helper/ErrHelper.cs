using System;
using System.Collections.Generic;
using System.Text;

namespace Bai3.Helper
{
    enum ErrType
    {
        Succes,
        Failed,
        NotExist,
        EmptyStudent,
        overlimit
    }
    class ErrHelper
    {
        public static void Log(ErrType et)
        {
            switch(et)
            {
                case ErrType.EmptyStudent:
                    Console.WriteLine("Khong co hoc sinh");
                    break;
                case ErrType.Succes:
                    Console.WriteLine("thanh cong");
                    break;
                case ErrType.Failed:
                    Console.WriteLine("that bai");
                    break;
                case ErrType.NotExist:
                    Console.WriteLine("Khong ton tai");
                    break;
                case ErrType.overlimit:
                    Console.WriteLine("qua gioi han");
                    break;
            }
        }
    }
}
