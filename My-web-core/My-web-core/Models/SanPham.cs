using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace My_web_core.Models
{
    [Table("SanPham")]
    public class SanPham
    {
        [Key]
        public int MaSP { get; set; }
        public string TenSP { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public string MoTa { get; set; }
        public int MaLoaiSP { get; set; }
        public int MaNCC { get; set; }
        //[ForeignKey("MaLoaiSP")]
        //public LoaiSP LoaiSP { get; set; }
        //[ForeignKey("MaNCC")]
        //public NhaCC NhaCC { get; set; }
    }
}
