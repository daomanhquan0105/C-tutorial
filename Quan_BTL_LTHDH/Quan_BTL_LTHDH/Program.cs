using System;
using System.IO.Pipes;
using Quan_BTL_LTHDH.Model;
using Quan_BTL_LTHDH_InOut.Controller;

namespace Quan_BTL_LTHDH_InOut
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[Process Dau Vao] Thuc hien nhap bieu thuc can tinh");
            string strBieuThuc = Console.ReadLine();
            XuLyVaoRa vr = new XuLyVaoRa() { ChuoiPhepTinh = strBieuThuc };
            if (vr.Loi == LoiChuoi.ChuoiHopLe)
            {
                strBieuThuc = vr.HienDSKH();

                PipeManage.CreateServer(
                    "PipeServerDauVao",
                    strBieuThuc,
                    "Tao ra <PipeServerDauVao>\nDoi Client De Gui Data:" + strBieuThuc,
                    "Tat Server: <PipeServerDauVao>");
                Console.ReadKey();

                PipeManage.ConnectToServer(
                    "PipeServerTinhToan",
                    "Tao ra Pipe Client de ket noi den <PipeServerTinhToan>\nDa nhan duoc du lieu:",
                    "Ket thuc Pipe Client");
            }
            else Console.WriteLine("Chuoi Nhap Khong Dung!");
            Console.ReadKey();
        }
    }
}

