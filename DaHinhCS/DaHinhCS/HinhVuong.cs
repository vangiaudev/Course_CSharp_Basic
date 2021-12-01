using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaHinhCS
{
    public class HinhVuong : HinhChuNhat
    {
        public int canh { get; set; }
        public HinhVuong(int canh):base(canh, canh)
        {
            
        }
        public override int TinhDienTich()
        {
            return base.TinhDienTich();
        }
        public override int ChuVi()
        {
            return base.ChuVi();
        }
    }
}
