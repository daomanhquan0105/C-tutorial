using Quan_BTL_LTHDH.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_BTL_LTHDH_Calculate.Controller
{
    class XuLyTinhToan
    {
        private string strChuan;
        public string BieuThucChuan 
        {
            get { return strChuan; } 
            set 
            { 
                strChuan = value;
                TaoKyHieu();
                TaoHauTo();
                TinhToan();
            } 
        } 
        public List<KyHieu> DSKyHieu { get; set; } = new List<KyHieu>();
        private List<KyHieu> DSKetQua = new List<KyHieu>();
        public SoHoc KetQua { get; private set; }
        public string HienDSKH()
        {
            string str = "";
            DSKyHieu.ForEach(x => {
                str += x.NoiDung + " ";
                //x.Hien();
            });
            return str;
        }
        private void TaoKyHieu()
        {
            string strTemp = BieuThucChuan.Trim('\0');
            while (!string.IsNullOrEmpty(strTemp))
            {
                TaoKyHieuDon(new SoHoc(), ref strTemp);
                TaoKyHieuDon(new ToanTu(), ref strTemp);
            }
        }
        private void TaoKyHieuDon(KyHieu kh, ref string strTemp)
        {
            strTemp = kh.TrichXuat(strTemp);
            if (kh.Loai != LoaiKyHieu.ChuaCoLoai)
                DSKyHieu.Add(kh);
        }
        private void TaoHauTo()
        {
            Stack<ToanTu> stack = new Stack<ToanTu>();
            DSKyHieu.ForEach(x =>
            {
                if (x is SoHoc) DSKetQua.Add(x);
                else
                {
                    ToanTu objTT = (ToanTu)x;
                    switch(objTT.Loai)
                    {
                        case LoaiKyHieu.DongNgoac:
                            while (stack.Peek().Loai != LoaiKyHieu.MoNgoac) 
                                DSKetQua.Add(stack.Pop());
                            stack.Pop();
                            break;
                        case LoaiKyHieu.CongTru: case LoaiKyHieu.NhanChia:
                            while (stack.Count > 0 && stack.Peek().LonHon(objTT)) 
                                DSKetQua.Add(stack.Pop());
                            break;
                    }                   
                    if(objTT.Loai !=LoaiKyHieu.DongNgoac)
                        stack.Push(objTT); 
                }
            });
            while (stack.Count > 0) 
                DSKetQua.Add(stack.Pop());
        }
        private void TinhToan()
        {
            
            Stack<SoHoc> stack = new Stack<SoHoc>();
            DSKetQua.ForEach(x => {
                if (x is SoHoc) stack.Push((SoHoc)x);
                else
                {
                    SoHoc sh2 = stack.Pop();
                    SoHoc sh1 = stack.Pop();
                    stack.Push(sh1.TinhToan((ToanTu)x, sh2));
                }
            });
            KetQua = stack.Pop();
        }
    }
}
