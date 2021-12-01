using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaHinhCS
{
    public class HinhChuNhat
    {
        public int dai { get; set; }
        public int rong { get; set; }
        public HinhChuNhat(int _dai, int _rong)
        {
            this.dai = _dai;
            this.rong = _rong;
        }
        public virtual int TinhDienTich()
        {
            return this.dai * this.rong;
        }
        public virtual int ChuVi()
        {
            return (this.dai + this.rong) * 2;
        }
    }
}
