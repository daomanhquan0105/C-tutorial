using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bai4.Helper;
using Bai4.Model;

namespace Bai4.Controller
{
    class ActionController
    {
        public ErrType ThemNguyenLieu(NguyenLieu NL)
        {
            using(Connection db=new Connection())
            {
                LoaiNguyenLieu a = db.LoaiNguyenLieus.Find(NL.LoaiNguyenLieuID);
                if (a != null)
                {
                    db.NguyenLieus.Add(NL);
                    db.SaveChanges();
                    return ErrType.Succes;
                }
                else return ErrType.NotExist;
            }
        }
        public ErrType ThemDSChiTietPhieuThu(PhieuThu phieu)
        {
            using(Connection db=new Connection())
            {
                PhieuThu a = db.PhieuThus.Find(phieu.PhieuThuID);
                if (a != null)
                {
                    Console.WriteLine("nhap so luong chi tiet phieu thu can them: ");
                    int n = int.Parse(Console.ReadLine());
                    for(int i=0;i<n;i++)
                    {
                        ChiTietPhieuThu x = new ChiTietPhieuThu();
                        x.PhieuThuID = phieu.PhieuThuID;
                        x.NguyeLieuID = InputHelper.NhapInt("nhap id cua nguyen lieu ban: ", "err");
                        x.SoLuongBan = InputHelper.NhapInt("nhap so luong ban cua nguyen lieu: ", "err");
                        db.ChiTietPhieuThus.Add(x);
                        db.SaveChanges();
                    }
                    return ErrType.Succes;
                }
                else return ErrType.NotExist;
            }
        }
        public ErrType Them1PhieuThu(PhieuThu phieu)
        {
            using(Connection db=new Connection())
            {
                using(var transaction=db.Database.BeginTransaction())
                {
                    int thanhTien = 0;
                    Console.WriteLine("so luong nguyen lieu ban: ");
                    int n = int.Parse(Console.ReadLine());
                    for (int i = 0; i < n; i++)
                    {
                        ChiTietPhieuThu ct = new ChiTietPhieuThu();
                        ct.PhieuThuID = phieu.PhieuThuID;
                        ct.NguyeLieuID = InputHelper.NhapInt("nhap ma nguyen lieu: ", "err");
                        ct.SoLuongBan = InputHelper.NhapInt("nhap so luong cua nguyen lieu duoc ban: ", "err");
                        db.ChiTietPhieuThus.Add(ct);
                        NguyenLieu a = db.NguyenLieus.Find(ct.NguyeLieuID);
                        thanhTien += ct.SoLuongBan * a.GiaBan;
                        a.SoLuongKho -= ct.SoLuongBan;
                        db.SaveChanges();
                    }
                    phieu.ThanhTien = thanhTien;
                    db.PhieuThus.Add(phieu);
                    db.SaveChanges();
                    transaction.Commit();
                    return ErrType.Succes;
                }
            }
        }
        public ErrType Xoa1PhieuThu(PhieuThu phieu)
        {
            using(Connection db=new Connection())
            {
                PhieuThu a = db.PhieuThus.Find(phieu.PhieuThuID);
                if (a != null)
                {
                    var dsChiTietPhieuThu = db.ChiTietPhieuThus.Where(x => x.PhieuThuID == phieu.PhieuThuID);
                    if (dsChiTietPhieuThu.Count() != 0)
                    {
                        foreach (ChiTietPhieuThu i in dsChiTietPhieuThu)
                        { db.ChiTietPhieuThus.Remove(i); }
                        db.PhieuThus.Remove(a);
                        db.SaveChanges();
                        return ErrType.Succes;
                    }
                    else
                    {
                        db.SaveChanges();
                        return ErrType.Succes;
                    }
                }
                else return ErrType.Empty;
            }
        }
        public ErrType LayDSPhieuThu()
        {
            using(Connection db=new Connection())
            {
                var dsphieu = db.PhieuThus.OrderBy(x => x.NgayLap).ToList();
                if (dsphieu.Count() != 0)
                {
                    dsphieu.ForEach( x => {
                        x.Hien();
                        List<NguyenLieu> LST = new List<NguyenLieu>();
                        var chitiet = db.ChiTietPhieuThus.Where(y => y.PhieuThuID == x.PhieuThuID).ToList();
                        chitiet.ForEach(y => {
                            NguyenLieu a = db.NguyenLieus.Find(y.NguyeLieuID);
                            LST.Add(a);
                        } );
                        LST.ForEach(y => y.Hien());
                    } );
                    return ErrType.Succes;
                }
                else return ErrType.Empty;
            }
        }
    }
}
