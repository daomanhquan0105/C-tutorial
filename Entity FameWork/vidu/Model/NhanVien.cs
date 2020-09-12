using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Bai2.Helper;
namespace Bai2.Model
{
    [Table("NhanVien")]
    class NhanVien
    {
        [Key]
        public int NhanVienID { get; set; }
        [StringLength(20)]
        public string HoTen { get; set; }
        [StringLength(10)]
        public string SoDienThoai { get; set; }
        [StringLength(20)]
        public string DiaChi { get; set; }
        [StringLength(20)]
        public string Email { get; set; }
        public int HeSoLuong { get; set; }

        [InverseProperty("NhanVien")]
        List<PhanCong> PhanCongs { get; set; }
        public NhanVien() { }
        public NhanVien(InputType inp)
        {
            if(inp==InputType.delete)
            { NhanVienID = InputHelper.NhapInt("nhap ma nv: ", "err"); }
            else if(inp==InputType.TinhToan)
            { NhanVienID = InputHelper.NhapInt("nhap ma nv: ", "err"); }
        }
    }
}
