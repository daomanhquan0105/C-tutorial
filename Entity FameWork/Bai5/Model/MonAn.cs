using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Bai5.Model
{
    [Table("MonAn")]
    class MonAn
    {
        [Key]
        public int MonAnID { get; set; }
        public int LoaiMonAnID { get; set; }
        [StringLength(20)]
        public string TenMon { get; set; }
        public int GiaBan { get; set; }
        [StringLength(50)]
        public string GioiThieu { get; set; }
        public string CachLam { get; set; }
        [ForeignKey("LoaiMonAnID")]
        LoaiMonAn LoaiMonAn { get; set; }
        public MonAn() { }
    }
}
