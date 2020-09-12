using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bai1.Helper;
using Bai1.Model;

namespace Bai1.Controller
{
    class LopController
    {
        public ErrType ThemLop(Lop a)
        {
            using (var db=new BusinessContext())
            {
                Lop l = db.Lops.SingleOrDefault(x => x.TenLop == a.TenLop);
                if (l != null)
                {
                    return ErrType.existed;
                }
                else
                {
                    db.Lops.Add(a);
                    db.SaveChanges();
                    return ErrType.succes;
                }
            }
        }
        public ErrType SuaLop(Lop a)
        {
            using (var db = new BusinessContext())
            {
                Lop l = db.Lops.Find(a.LopID);
                if (l == null)
                {
                    return ErrType.notexist;
                }
                else
                {
                    Boolean ok = true;
                    do
                    {
                        l.TenLop = InputHelper.NhapStr("nhap ten lop moi: ", "err", 0, 10);
                        Lop lCon = db.Lops.SingleOrDefault(x => x.TenLop == l.TenLop);
                        if (lCon != null)
                        {
                            ok = false;
                        }
                        else ok = true;
                    }
                    while (!ok);
                    db.SaveChanges();
                    return ErrType.succes;
                }
            }
        }
        public ErrType XoaLop(Lop a)
        {
            using (var db = new BusinessContext())
            {
                var hs = db.HocSinhs.Where(x => x.LopID == a.LopID);
                if(hs.Count()==0)
                {
                    Lop l = db.Lops.Find(a.LopID);
                    if (l != null)
                    {
                        db.Lops.Remove(l);
                        db.SaveChanges();
                        return ErrType.succes;
                    }
                    else return ErrType.emptylist;
                }
                else
                {
                    foreach(HocSinh h in hs)
                    { db.HocSinhs.Remove(h); }
                    db.Lops.Remove(a);
                    db.SaveChanges();
                    return ErrType.succes;
                }
            }
        }
    }
}
