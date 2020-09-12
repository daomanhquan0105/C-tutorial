using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Bai1.Helper;
namespace Bai1.Model
{
    [Table("HocSinh")]
    class HocSinh
    {
        [Key]
        public int HocSinhID { get; set; }
        public int? LopID { get; set; }
        [StringLength(20)]
        public string HoTen { get; set; }
        [StringLength(50)]
        public string QueQuan { get; set; }
        public DateTime? NgaySinh { get; set; }
        [ForeignKey("LopID")]
        Lop lop { get; set; } 
        public HocSinh() { }
        public HocSinh(InputType input)
        {
            if(input ==InputType.Insert)
            {
                HoTen = InputHelper.NhapStr("nhap ho ten: ", "err", 0, 20);
                QueQuan = InputHelper.NhapStr("nhap que quan: ", "err");
                NgaySinh = InputHelper.NhapDate("nhap ngay sinh: ", "err", new DateTime(2001, 1 , 1), new DateTime(2013 , 12 , 31));
            }
            else
            {
                if (input == InputType.Delete)
                {
                    HocSinhID = InputHelper.NhapInt("nhap ma hoc sinh can xoa", "err");
                }
                else if(input==InputType.Update)
                {
                    HocSinhID = InputHelper.NhapInt("nhap ma hoc sinh can xoa", "err");
                }
            }
        }
    }
}
