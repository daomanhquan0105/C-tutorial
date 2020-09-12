using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Bai5.Model
{
    [Table("NguyenLieu")]
    class NguyenLieu
    {
        [Key]
        public int NguyenLieuID { get; set; }
        [StringLength(20)]
        public string TenNguyenLieu { get; set; }
        [StringLength(50)]
        public string GhiChu { get; set; }
        public NguyenLieu() { }
    }
}
