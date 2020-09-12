using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QuanLyNhanVien.model
{
    [Table("PhongBan")]
    class PhongBan
    {
        [Key]
        public int MaPB { get; set; }
        [StringLength(20)]
        public string TenPB { get; set; }
        [InverseProperty("PhongBan")]
        List<NhanVien> NhanViens { get; set; }
    }
}
