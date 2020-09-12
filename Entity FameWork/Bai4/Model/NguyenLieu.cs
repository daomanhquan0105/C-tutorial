using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Bai4.Helper;

namespace Bai4.Model
{
    [Table("NguyenLieu")]
    class NguyenLieu
    {
        [Key]
        public int NguyenLieuID { get; set; }
        public int LoaiNguyenLieuID { get; set; }
        [StringLength(20)]
        public string TenNguyenLieu { get; set; }
        public int GiaBan { get; set; }
        [StringLength(10)]
        public string DonViTinh { get; set; }
        public int SoLuongKho { get; set; }
        [ForeignKey("LoaiNguyenLieuID")]
        LoaiNguyenLieu LoaiNguyenLieu { get; set; }
        public NguyenLieu() { }
        public NguyenLieu(InputType inp)
        {
            if(inp==InputType.insert)
            {
                LoaiNguyenLieuID = InputHelper.NhapInt("nhap ma loai nguyen lieu: ", "err");
                TenNguyenLieu = InputHelper.NhapStr("nhap ten nguyen lieu: ", "err", 0, 20);
                GiaBan = InputHelper.NhapInt("nhap gia ban cua nguyen lieu: ", "err");
                DonViTinh = InputHelper.NhapStr("nhap don vi tinh: ", "err", 0, 10);
                SoLuongKho = InputHelper.NhapInt("nhap so luong do co trong kho: ", "err");
            }
        }
        public void Hien()
        {
            Console.WriteLine($"{NguyenLieuID} co ten {TenNguyenLieu} gia ban la {GiaBan}");
        }
    }
}
