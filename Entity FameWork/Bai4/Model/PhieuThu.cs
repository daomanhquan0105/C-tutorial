using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Bai4.Helper;
namespace Bai4.Model
{
    [Table("PhieuThu")]
    class PhieuThu
    {
        [Key]
        public int PhieuThuID { get; set; }
        public DateTime NgayLap { get; set; }
        [StringLength(20)]
        public string NhanVienLap { get; set; }
        [StringLength(50)]
        public string GhiChu { get; set; }
        public int ThanhTien { get; set; }
        public PhieuThu() { }
        public PhieuThu(InputType inp)
        {
            if(inp==InputType.insert)
            {
                NgayLap = InputHelper.NhapDate("ngay lap phieu: ", "err", DateTime.Now, DateTime.Now.AddDays(10));
                NhanVienLap = InputHelper.NhapStr("nhap ho ten nhan vien nhap phieu: ", "err");
                GhiChu = InputHelper.NhapStr("ghi chu: ", "err", 0, 50);
            }
        }
        public void Hien()
        {
            Console.WriteLine($"{PhieuThuID} lap ngay {NgayLap} tong tien {ThanhTien}");
        }
    }
}
