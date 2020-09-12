using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Bai3.Helper;
namespace Bai3.Model
{
    [Table("KhoaHoc")]
    class KhoaHoc
    {
        [Key]
        public int KhoaHocID { get; set; }
        [StringLength(10)]
        public string TenKhoaHoc { get; set; }
        [StringLength(50)]
        public string MoTa { get; set; }
        public int HocPhi { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        [InverseProperty("KhoaHoc")]
        List<NgayHoc> NgayHocs { get; set; }
        List<HocVien> HocViens { get; set; }
        public KhoaHoc() { }
        public KhoaHoc(InputType inp)
        {
            if(inp==InputType.delete)
            {
                KhoaHocID = InputHelper.NhapInt("nhap ma khoa hoc can xoa: ", "err");
            }
            else
            {
                if(inp==InputType.searh)
                { KhoaHocID = InputHelper.NhapInt("nhap ma khoa hoc can tinh doanh thu: ", "err"); }
            }
        }
    }
}
