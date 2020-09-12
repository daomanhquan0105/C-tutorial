using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Bai5.Model
{
    [Table("CongThuc")]
    class CongThuc
    {
        [Key]
        public int CongThucID { get; set; }
        public int NguyenLieuID { get; set; }
        public int MonAnID { get; set; }
        public int SoLuong { get; set; }
        [StringLength(10)]
        public string DonViTinh { get; set; }
        [ForeignKey("NguyenLieuID")]
        NguyenLieu NguyenLieu { get; set; }
        [ForeignKey("MonAnID")]
        MonAn MonAn { get; set; }
        public CongThuc() { }
    }
}
