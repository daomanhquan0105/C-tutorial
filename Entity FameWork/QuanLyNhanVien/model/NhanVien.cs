using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QuanLyNhanVien.model
{
    [Table("NhanVien")]
    class NhanVien
    {
        [Key]
        public int MaNV { get; set; }
        [StringLength(50)]
        public string TenNV { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public int Luong { get; set; }
        public int MaPB { get; set; }
        [ForeignKey("MaPB")]
        PhongBan phongBan { get; set; }
    }
}
