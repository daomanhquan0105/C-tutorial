using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Bai2.Helper;
namespace Bai2.Model
{
    [Table("DuAn")]
    class DuAn
    {
        [Key]
        public int DuAnID { get; set; }
        [StringLength(20)]
        public string TenDA { get; set; }
        [StringLength(50)]
        public string MoTa { get; set; }
        public string GhiChu { get; set; }
        [InverseProperty("DuAn")]
        List<PhanCong> PhanCongs { get; set; }
        public DuAn()
        {
            TenDA = InputHelper.NhapStr("nhap ten du an: ", "err", 0, 20);
            MoTa = InputHelper.NhapStr("mo ta du an: ", "err",0,50);
            GhiChu = InputHelper.NhapStr("ghi chu ve du an: ", "err", 0, 50);
        }
        public DuAn(InputType inp)
        {
            if(inp==InputType.update)
            {
                TenDA = InputHelper.NhapStr("nhap ten du an: ", "err", 0, 20);
                MoTa = InputHelper.NhapStr("mo ta du an: ", "err", 0, 50);
                GhiChu = InputHelper.NhapStr("ghi chu ve du an: ", "err", 0, 50);
            }
        }
    }
}
