using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Bai1.Helper;

namespace Bai1.Model
{
    [Table("Lop")]
    class Lop
    {
        [Key]
        public int LopID { get; set; }
        [StringLength(10)]
        public string TenLop { get; set; }
        public int SiSo { get; set; } = 20;
        [InverseProperty("Lop")]
        List<HocSinh> HocSinhs { get; set; }
        public Lop() { }
        public Lop(InputType input)
        {
            if(input==InputType.Insert)
            {
                Console.WriteLine("nhap lop: ");
                TenLop = InputHelper.NhapStr("nhap ten lop: ", "err", 0, 10);
            }
            if(input==InputType.Update)
            {
                LopID = InputHelper.NhapInt("nhap ma lop: ", "err");
            }
            if(input==InputType.Delete)
            {
                LopID= InputHelper.NhapInt("nhap ma lop: ", "err");
            }
        }
    }
}
