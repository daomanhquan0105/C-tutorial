using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Bai4.Model
{
    [Table("LoaiNguyenLieu")]
    class LoaiNguyenLieu
    {
        [Key]
        public int LoaiNguyenLieuID { get; set; }
        [StringLength(20)]
        public string TenLoai { get; set; }
        [StringLength(50)]
        public string MoTa { get; set; }

    }
}
