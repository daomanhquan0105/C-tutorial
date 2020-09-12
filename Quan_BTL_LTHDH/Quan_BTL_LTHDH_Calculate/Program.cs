using System;
using System.IO.Pipes;
using Quan_BTL_LTHDH_Calculate.Controller;
namespace Quan_BTL_LTHDH_Calculate
{
    class Program {
        static void Main()
        {
            string msg = PipeManage.ConnectToServer(
                "PipeServerDauVao", 
                "Ket noi den server <PipeServerDauVao>\nThuc hien lay du lieu:", 
                "Dong ket noi den server <PipeServerDauVao>");
            XuLyTinhToan tt = new XuLyTinhToan();
            tt.BieuThucChuan = msg;
            Console.ReadKey();

            PipeManage.CreateServer(
                "PipeServerTinhToan", 
                tt.KetQua.NoiDung, 
                "Tao ra server <PipeServerTinhToan>\nGui lai ket qua tinh duoc la:"+ tt.KetQua.NoiDung, 
                "Dong Server <PipeServerTinhToan>");
            Console.ReadKey();
        }
    }
}