using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class SanPhamBLL
    {
        SanPhamAccess spa = new SanPhamAccess();
        public List<SanPham> LayToanBoSanPham()
        {
            return spa.LayToanBoSanPham();
        }
        public bool XoaSanPham(int ma)
        {
            return spa.XoaSanPham(ma);
        }
        public bool ThemSanPham(SanPham sp)
        {
            if(sp.TenSP.Length == 0) { return false; }
            return spa.ThemSanPham(sp);
        }
    }
}
