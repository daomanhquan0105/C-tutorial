using System;
using System.Collections.Generic;
using System.Text;

namespace Bai2.Helper
{
    enum errType
    {
        ThanhCong,
        ThatBai,
        DanhSachTrong,
        KhongTonTai,
        DaTonTai,
        KhongCoNhanVien,
        KhongCoDuAn
    }
    class ErrHelper
    {
        public static void Log(errType et)
        {
            switch(et)
            {
                case errType.ThanhCong:
                    Console.WriteLine("Thanh cong");
                    break;
                case errType.ThatBai:
                    Console.WriteLine("that bai");
                    break;
                case errType.DanhSachTrong:
                    Console.WriteLine("danh sach trong");
                    break;
                case errType.DaTonTai:
                    Console.WriteLine("da ton tai");
                    break;
                case errType.KhongTonTai:
                    Console.WriteLine("khong ton tai");
                    break;
                case errType.KhongCoNhanVien:
                    Console.WriteLine("nhan vien khong ton tai");
                    break;
                case errType.KhongCoDuAn:
                    Console.WriteLine("du an khong ton tai");
                    break;
            }
        }
    }
}
