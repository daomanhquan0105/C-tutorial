using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_BTL_LTHDH.Model
{
    abstract class KyHieu
    {
        public string NoiDung { get; set; }
        public LoaiKyHieu Loai { get; protected set; } = LoaiKyHieu.ChuaCoLoai;
        public abstract string TrichXuat(string str);
        public void Hien() { Console.Write("{0} ", NoiDung); }
    }
}
