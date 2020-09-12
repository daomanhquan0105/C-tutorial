using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Bai2.Helper;
namespace Bai2.Model
{
    [Table("PhanCong")]
    class PhanCong
    {
        [Key]
        public int PhanCongID { get; set; }
        public int NhanVienID { get; set; }
        public int DuAnID { get; set; }
        public int SoGioLam { get; set; }
        [ForeignKey("NhanVienID")]
        NhanVien nv { get; set; }
        [ForeignKey("DuAnID")]
        DuAn duan { get; set; }
        public PhanCong() { }
        public PhanCong(InputType inp)
        {
            if(inp==InputType.insert)
            {
                NhanVienID = InputHelper.NhapInt("nhap ma nv: ", "err");
                DuAnID = InputHelper.NhapInt("nhap ma du an: ", "err");
                SoGioLam = InputHelper.NhapInt("so gio lam cua du an: ", "err");
            }
        }
    }
}
