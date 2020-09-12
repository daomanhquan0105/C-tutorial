using Quan_BTL_LTHDH.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_BTL_LTHDH_InOut.Controller
{
    class XuLyVaoRa
    {
        string strChuoiPhepTinh = "";
        public LoiChuoi Loi { get;private set; }
        public string ChuoiPhepTinh
        {
            get { return strChuoiPhepTinh; }
            set
            {
                strChuoiPhepTinh = value.Replace(" ", "");
                TaoKyHieu();
            }
        }
        public List<KyHieu> DSKyHieu { get; private set; } = new List<KyHieu>();
        public string HienDSKH()
        {
            string str = "";
            DSKyHieu.ForEach(x => {
                str += x.NoiDung;
                //x.Hien();
            });
            return str;
        }
        private LoiChuoi TaoKyHieu()
        {
            string strTemp = ChuoiPhepTinh;
            Loi = KiemTraTruoc();
            if (Loi== LoiChuoi.ChuoiDungDinhDang)
            {
                while (!string.IsNullOrEmpty(strTemp))
                {
                    TaoKyHieuDon(new SoHoc(), ref strTemp);
                    TaoKyHieuDon(new ToanTu(), ref strTemp);
                }
            }
            Loi = TimLoi();
            return Loi;
        }
        private void TaoKyHieuDon(KyHieu kh, ref string strTemp)
        {
            strTemp = kh.TrichXuat(strTemp);
            if (kh.Loai != LoaiKyHieu.ChuaCoLoai)
                DSKyHieu.Add(kh);
        }
        private LoiChuoi KiemTraTruoc()
        {
            if (string.IsNullOrEmpty(ChuoiPhepTinh)) return LoiChuoi.ChuoiTrong;
            if (ChuoiPhepTinh.ToList().Exists(x => char.IsLetter(x))) return LoiChuoi.ChuoiKhongHopLe;
            return LoiChuoi.ChuoiDungDinhDang;

        }
        private LoiChuoi TimLoi()
        {
            string strTemp = ChuoiPhepTinh;

            int nMoNgoac = DSKyHieu.Count(x => x.Loai == LoaiKyHieu.MoNgoac);
            int nDongNgoac = DSKyHieu.Count(x => x.Loai == LoaiKyHieu.DongNgoac);
            if (nMoNgoac != nDongNgoac) return LoiChuoi.ChuoiThieuNgoac;
            return LoiChuoi.ChuoiHopLe;
        }
    }
}
