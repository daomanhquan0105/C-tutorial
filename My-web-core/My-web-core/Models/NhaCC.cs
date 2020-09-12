using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace My_web_core.Models
{
    [Table("NhaCC")]
    public class NhaCC
    {
        [Key]
        public int MaNCC { get; set; }
        public string TenNCC { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public IEnumerable<SanPham> SanPhams { get; set; }
    }
}
