using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Bai5.Model
{
    [Table("LoaiMonAn")]
    class LoaiMonAn
    {
        [Key]
        public int LoaiMonAnID { get; set; }
        [StringLength(20)]
        public string TenLoai { get; set; }
        [StringLength(50)]
        public string MoTa { get; set; }
        public LoaiMonAn() { }
    }
}
