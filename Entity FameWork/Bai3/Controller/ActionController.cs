using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bai3.Helper;
using Bai3.Model;

namespace Bai3.Controller
{
    class ActionController
    {
        public ErrType SuaTTHV(HocVien hv)
        {
            using(Connection db=new Connection())
            {
                HocVien a = db.HocViens.Find(hv.HocVienID);
                if (a != null)
                {
                    a.HoTen = InputHelper.NhapStr("nhap ho ten: ", "err", 0, 20);
                    a.NgaySinh=InputHelper.NhapDate("nhap ngay sinh: ","err",new DateTime(2013/1/1),new DateTime(1997/12/31));
                    a.QueQuan = InputHelper.NhapStr("nhap qua quan: ", "err", 0, 50);
                    a.SoDienThoai = InputHelper.NhapStr("nhap so dien thoai: ", "err", 0, 10);
                    db.SaveChanges();
                    return ErrType.Succes;
                }
                else return ErrType.NotExist;
            }
        }
        public ErrType XoaKhoaHoc(KhoaHoc kh)
        {
            using(Connection db=new Connection())
            {
                KhoaHoc a = db.KhoaHocs.Find(kh.KhoaHocID);
                if (a != null)
                {
                    var dsHV = db.HocViens.Where(x => x.KhoaHocID == kh.KhoaHocID);
                    var DSNgayHoc = db.NgayHocs.Where(x => x.KhoaHocID == kh.KhoaHocID);
                    if (dsHV == null && DSNgayHoc == null)
                    {
                        db.KhoaHocs.Remove(a);
                        db.SaveChanges();
                        return ErrType.Succes;
                    }
                    else
                    {
                        foreach (HocVien i in dsHV) { db.HocViens.Remove(i); }
                        foreach (NgayHoc i in DSNgayHoc) { db.NgayHocs.Remove(i); }
                        db.KhoaHocs.Remove(a);
                        db.SaveChanges();
                        return ErrType.Succes;
                    }
                }
                else return ErrType.NotExist;
            }
        }
        public ErrType TimKiemHV(HocVien hv)
        {
            using(Connection db=new Connection())
            {
                var DSHocVien = db.HocViens.Where(x => x.HoTen == hv.HoTen && x.KhoaHocID == hv.KhoaHocID);
                if (DSHocVien.Count() != 0)
                {
                    foreach (HocVien i in DSHocVien) { i.Hien(); }
                    return ErrType.Succes;
                }
                else return ErrType.EmptyStudent;
            }
        }
        public ErrType TinhDoanhThu(KhoaHoc kh)
        {
            using(Connection db=new Connection())
            {
                KhoaHoc khoa = db.KhoaHocs.Find(kh.KhoaHocID);
                if (khoa != null)
                {
                    var dsHV = db.HocViens.Where(x => x.KhoaHocID == kh.KhoaHocID);
                    if (dsHV.Count() != 0)
                    {
                        int doanhThu = dsHV.Count() * kh.HocPhi;
                        Console.WriteLine($"{kh.KhoaHocID} co ten {kh.TenKhoaHoc} co doanh thu la : {doanhThu}");
                        return ErrType.Succes;
                    }
                    else return ErrType.EmptyStudent;
                }
                else return ErrType.NotExist;
            }
        }
        public ErrType ThemNgayHoc(NgayHoc ngay)
        {
            using(Connection db=new Connection())
            {
                KhoaHoc kh = db.KhoaHocs.Find(ngay.KhoaHocID);
                int soNgayHoc = db.NgayHocs.Where(x => x.KhoaHocID == ngay.KhoaHocID).Count();
                if (kh != null && soNgayHoc<=15)
                {
                    db.NgayHocs.Add(ngay);
                    db.SaveChanges();
                    return ErrType.Succes;
                }
                else
                {
                    if (kh == null) return ErrType.NotExist;
                    else return ErrType.overlimit;
                }
            }
        }
    }
}
