using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Bai3.Helper;

namespace Bai3.Model
{
    [Table("NgayHoc")]
    class NgayHoc
    {
        [Key]
        public int NgayHocID { get; set; }
        public int KhoaHocID { get; set; }
        [StringLength(50)]
        public string NoiDung { get; set; }
        [StringLength(50)]
        public string GhiChu { get; set; }
        [ForeignKey("NgayHocID")]
        KhoaHoc KhoaHoc { get; set; }
        public NgayHoc() { }
        public NgayHoc(InputType inp)
        {
            if(inp==InputType.insert)
            {
                KhoaHocID = InputHelper.NhapInt("nhap ma khoa hoc: ", "err");
                NoiDung = InputHelper.NhapStr("nhap noi dung cua khoa hoc: ", "err", 0, 50);
                GhiChu = InputHelper.NhapStr("ghi chu: ", "err", 0, 50);
            }
        }
    }
}
