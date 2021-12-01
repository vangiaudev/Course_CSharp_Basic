using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HocListView
{
    public class DanhMuc
    {
        public string Ma { get; set; }
        public string Ten { get; set; }
        public List<SanPham> sp { get; set; }
        public DanhMuc()
        {
            sp = new List<SanPham>();
        }
        public void ThemSP(SanPham sp)
        {
            this.sp.Add(sp);
            sp.Nhom = this;
        }
    }
}
