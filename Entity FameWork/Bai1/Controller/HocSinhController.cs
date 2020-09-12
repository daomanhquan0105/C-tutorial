using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bai1.Helper;
using Bai1.Model;
namespace Bai1.Controller
{
    class HocSinhController
    {
        public ErrType ThemHS(HocSinh hs)
        {
            using (BusinessContext db = new BusinessContext())
            {
                if (db.Lops.Count() == 0)
                {
                    return ErrType.emptylist;
                }
                else
                {
                    var hocsinh = db.HocSinhs.Where(x => x.LopID == hs.LopID);
                    if (hocsinh != null)
                    {
                        if (hocsinh.Count() >= 20)
                        {
                            return ErrType.full;
                        }
                        else
                        {
                            db.HocSinhs.Add(hs);
                            Boolean ok = true;
                            do
                            {
                                hs.LopID = InputHelper.NhapInt("Nhap ma lop: ", "err");
                                Lop l = db.Lops.Find(hs.LopID);
                                if (l == null)
                                {
                                    Console.WriteLine("lop khong ton tai!");
                                    ok = false;
                                }
                                else ok = true;
                            }
                            while (!ok);
                            db.SaveChanges();
                            return ErrType.succes;
                        }
                    }
                    else return ErrType.failed;
                }
            }
        }
        public ErrType XoaHS(HocSinh hocSinh)
        {
            using (var db=new BusinessContext())
            {
                HocSinh hs = db.HocSinhs.Find(hocSinh.HocSinhID);
                if (hs != null)
                {
                    db.HocSinhs.Remove(hs);
                    db.SaveChanges();
                    return ErrType.succes;
                }
                else
                {
                    return ErrType.failed;
                }
            }
        }
        public ErrType SuaTTHS(HocSinh hs)
        {
            using(var db=new BusinessContext())
            {
                HocSinh hocsinh = db.HocSinhs.Find(hs.HocSinhID);
                if (hocsinh != null)
                {
                    hocsinh.HoTen = InputHelper.NhapStr("nhap ho ten: ", "err", 0, 20);
                    hocsinh.QueQuan = InputHelper.NhapStr("nhap que quan: ", "err");
                    hocsinh.NgaySinh = InputHelper.NhapDate("nhap ngay sinh: ", "err", new DateTime(2001 / 1 / 1), new DateTime(2013 / 12 / 31));
                    Boolean ok = true;
                    do
                    {
                        hocsinh.LopID = InputHelper.NhapInt("Nhap ma lop: ", "err");
                        Lop l = db.Lops.Find(hocsinh.LopID);
                        if (l == null)
                        {
                            Console.WriteLine("lop khong ton tai");
                            ok = false;
                        }
                        else ok = true;
                    }
                    while (!ok);
                    db.SaveChanges();
                    return ErrType.succes;
                }
                else return ErrType.emptylist;
            }
        }
        public ErrType ChuyenLopChoHS(HocSinh hs)
        {
            using(var db=new BusinessContext())
            {
                HocSinh hocsinh = db.HocSinhs.Find(hs.HocSinhID);
                if (hocsinh != null)
                {
                    Boolean ok = true;
                    do
                    {
                        hocsinh.LopID = InputHelper.NhapInt("Nhap ma lop: ", "err");
                        Lop l = db.Lops.Find(hocsinh.LopID);
                        if (l == null)
                        {
                            Console.WriteLine("lop khong ton tai");
                            ok = false;
                        }
                        else ok = true;
                    }
                    while (!ok);
                    db.SaveChanges();
                    return ErrType.succes;
                }
                else return ErrType.emptylist;
            }
        }
    }
}
