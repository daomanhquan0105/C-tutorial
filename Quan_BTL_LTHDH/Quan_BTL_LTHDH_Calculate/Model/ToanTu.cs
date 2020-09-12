using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_BTL_LTHDH.Model
{
    class ToanTu : KyHieu
    {
        public override string TrichXuat(string str)
        {
            if (str.Length == 0) return "";
            switch (str[0])
            {
                case '+': case '-': Loai = LoaiKyHieu.CongTru;break;
                case '*': case '/': Loai = LoaiKyHieu.NhanChia; break;
                case '(': Loai = LoaiKyHieu.MoNgoac; break;
                case ')': Loai = LoaiKyHieu.DongNgoac; break;
            }
            if (Loai == LoaiKyHieu.ChuaCoLoai) return str;
            else
            {
                NoiDung = str[0].ToString();
            }
            if (str.Length > 1)
                return str.Substring(1);
            return "";
        }
        public bool LonHon(ToanTu tt)
        {
            switch (this.Loai)
            {
                case LoaiKyHieu.MoNgoac: case LoaiKyHieu.DongNgoac: return false;
                case LoaiKyHieu.NhanChia: return true;
                case LoaiKyHieu.CongTru: return tt.Loai == LoaiKyHieu.CongTru;
            }
            return true;
        }
    }
}
