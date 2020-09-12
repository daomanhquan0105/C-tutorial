using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Bai4.Model
{
    [Table("ChiTietPhieuThu")]
    class ChiTietPhieuThu
    {
        [Key]
        public int ChiTietPhieuThuID { get; set; }
        public int NguyeLieuID { get; set; }
        public int PhieuThuID { get; set; }
        public int SoLuongBan { get; set; }
        [ForeignKey("NguyenLieuID")]
        NguyenLieu NguyenLieu { get; set; }
        [ForeignKey("PhieuThuID")]
        PhieuThu PhieuThu { get; set; }
        public PhieuThu()
        {

        }
    }
}
