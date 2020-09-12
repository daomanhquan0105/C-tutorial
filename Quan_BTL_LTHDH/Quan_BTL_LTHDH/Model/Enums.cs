using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_BTL_LTHDH.Model
{
    enum LoaiKyHieu
    {
        SoHoc,
        CongTru,
        NhanChia,
        MoNgoac,
        DongNgoac,
        ChuaCoLoai,
        KyTuDacBiet
    }
    enum LoiChuoi
    {
        ChuoiDungDinhDang,
        ChuoiHopLe,
        ChuoiTrong,
        ChuoiKhongHopLe,     //Co ky tu khac ngoai so/ toan tu
        ChuoiThieuNgoac,        //Thua hoac Thieu mo/dong ngoac
        ChuoiSaiFormat,         //1++2--3
    }
}
