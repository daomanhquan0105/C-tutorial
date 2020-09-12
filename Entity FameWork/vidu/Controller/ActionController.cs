using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bai2.Helper;
using Bai2.Model;
namespace Bai2.Controller
{
    class ActionController
    {
        public errType ThemNVVaoDuAn(PhanCong pc)
        {
            using(var db=new Connection())
            {
                NhanVien a = db.NhanViens.SingleOrDefault(x=>x.NhanVienID==pc.NhanVienID);
                DuAn b = db.DuAns.SingleOrDefault(x=>x.DuAnID==pc.DuAnID);
                
                if(a!=null && b!=null)
                {
                    db.PhanCongs.Add(pc);
                    return errType.ThanhCong;
                }
                else
                {
                    if (a == null) return errType.KhongCoNhanVien;
                    else return errType.KhongCoDuAn;
                }
            }
        }
        public errType SuaTTDuAN(DuAn da)
        {
            using(var db=new Connection())
            {
                DuAn x = db.DuAns.Find(da.DuAnID);
                if (x != null)
                {
                    x = new DuAn();
                    db.SaveChanges();
                    return errType.ThanhCong;
                }
                else return errType.KhongCoDuAn;
            }
        }
        public errType XoaNV(NhanVien nv)
        {
            using(var db=new Connection())
            {
                var pc = db.PhanCongs.Where(x => x.NhanVienID == nv.NhanVienID);
                NhanVien nhanvien = db.NhanViens.Find(nv.NhanVienID);
                if (pc == null)
                {
                    if (nhanvien != null)
                    {
                        db.NhanViens.Remove(nhanvien);
                        db.SaveChanges();
                        return errType.ThanhCong;
                    }
                    else return errType.KhongCoNhanVien;
                }
                else
                {
                    foreach(PhanCong x in pc)
                    { db.PhanCongs.Remove(x); }
                    db.NhanViens.Remove(nhanvien);
                    db.SaveChanges();
                    return errType.ThanhCong;
                }
            }
        }
        public errType TinhLuong(NhanVien nv)
        {
            using (var db = new Connection())
            {
                if (db.NhanViens.Find(nv.NhanVienID) != null)
                {
                    int Luong = nv.HeSoLuong * 15 * db.PhanCongs.Where(x => x.NhanVienID == nv.NhanVienID).Sum(x => x.SoGioLam);
                    
                    Console.WriteLine($"{nv.NhanVienID} co ten {nv.HoTen} co luong la: " + Luong);
                    return errType.ThanhCong;
                }
                else return errType.KhongCoNhanVien;
            }
        }
    }
}
