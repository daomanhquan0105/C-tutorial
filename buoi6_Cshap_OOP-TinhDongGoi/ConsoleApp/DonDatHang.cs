using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class DonDatHang
    {
        
        public int MaSoDon { get; set; }
        public DateTime NgayDat { get; set; }
        public string TenSP { get; set; }
        public double DonGia { get; set; }
        public int SoLuong { get; set; }
        
        public double ThanhTien
        {
            get
            {
                return SoLuong*DonGia;
            }
            private set { }
        }
        public string GhiChu { get; set; }
        public DonDatHang()
        {
            Console.Write("ma so don hang: ");
            MaSoDon = int.Parse(Console.ReadLine());
            Console.Write("ngay dat don hang: ");
            NgayDat = DateTime.Parse(Console.ReadLine());
            Console.Write("so luong san pham: ");
            SoLuong = int.Parse(Console.ReadLine());
            Console.Write("gia tien 1 sp: ");
            DonGia = double.Parse(Console.ReadLine());
            Console.Write("ten san pham: ");
            TenSP = Console.ReadLine();
            Console.Write("ghi chu ve don hang: ");
            GhiChu = Console.ReadLine();
        }
        public DonDatHang(int maSoDon, DateTime ngayDat, int soLuong, int donGia, string tenSanPham, string ghiChu)
        {
            MaSoDon = maSoDon;
            NgayDat = ngayDat;
            SoLuong = soLuong;
            DonGia = donGia;
            TenSP = tenSanPham;
            GhiChu = ghiChu;
        }
        public void hien()
        {
            Console.WriteLine($"don hang co ma: {MaSoDon}\n dat ngay :{NgayDat.ToShortDateString()}\n co tong tien la: {ThanhTien} ");
        }
    }
}
