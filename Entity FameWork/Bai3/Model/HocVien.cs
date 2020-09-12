using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Bai3.Helper;

namespace Bai3.Model
{
    [Table("HocVien")]
    class HocVien
    {
        [Key]
        public int HocVienID { get; set; }
        public int KhoaHocID { get; set; }
        [StringLength(20)]
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        [StringLength(50)]
        public string QueQuan { get; set; }
        [StringLength(50)]
        public string DiaChi { get; set; }
        [StringLength(10)]
        public string SoDienThoai { get; set; }
        [ForeignKey("KhoaHocID")]
        KhoaHoc KhoaHoc { get; set; }
        public void Hien()
        {
            Console.WriteLine($"{HocVienID} co ten {HoTen} theo hoc khoa {KhoaHocID} co so dien thoai {SoDienThoai}");
        }
        public HocVien() { }
        public HocVien(InputType inp)
        {
            if(inp==InputType.update)
            {
                HocVienID = InputHelper.NhapInt("nhap id cua hoc vien can sua: ", "err");
            }
            else
            {
                if(inp==InputType.searh)
                {
                    HoTen = InputHelper.NhapStr("nhap ho ten: ", "err", 0, 20);
                    KhoaHocID = InputHelper.NhapInt("nhap id khoa hoc can tim: ", "err");
                }
            }
        }
    }
}
