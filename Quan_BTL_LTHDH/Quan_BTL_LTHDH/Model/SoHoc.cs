using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_BTL_LTHDH.Model
{
    class SoHoc : KyHieu
    {
        private double giaTri;
        public double GiaTri 
        { 
            get { return giaTri; } 
            private set 
            {
                giaTri = value;
                NoiDung = giaTri.ToString();
            } 
        }
        public override string TrichXuat(string str)
        {
            string strValue = "";
            int i = 0;
            for (; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                    strValue += str[i];
                else break;
            }
            if (!string.IsNullOrEmpty(strValue))
            {
                NoiDung = strValue;
                GiaTri = double.Parse(NoiDung);
                Loai = LoaiKyHieu.SoHoc;
            }
            if (str.Length > i)
                return str.Substring(i);
            return "";
        }
        public SoHoc TinhToan(KyHieu PhepTinh, SoHoc ToanHang)
        {
            switch (PhepTinh.NoiDung)
            {
                case "+":
                    return new SoHoc() { GiaTri = this.GiaTri + ToanHang.GiaTri };
                case "-":
                    return new SoHoc() { GiaTri = this.GiaTri - ToanHang.GiaTri };
                case "*":
                    return new SoHoc() { GiaTri = this.GiaTri * ToanHang.GiaTri };
                case "/":
                    return new SoHoc() { GiaTri = this.GiaTri / ToanHang.GiaTri*1.0 };
            }
            return null;
        }
    }
}
