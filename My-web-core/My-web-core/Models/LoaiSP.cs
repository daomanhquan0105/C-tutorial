using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace My_web_core.Models
{
    [Table("LoaiSP")]
    public class LoaiSP
    {
        [Key]
        public int MaLoaiSP { get; set; }
        public string TenLoai { get; set; }
        public string MoTa { get; set; }
        public IEnumerable<SanPham> SanPhams { get; set; }
    }
}
