using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectChuongTrinhQuanLySanPham
{
    public class DanhMuc
    {
        private Dictionary<string, SanPham> dsSP = new Dictionary<string, SanPham>();
        public string MaDM { get; set; }
        public string TenDM { get; set; }
        public void ThemSP (SanPham sp)
        {
            if (this.dsSP.ContainsKey(sp.MaSp) == false)
            {
                this.dsSP.Add(sp.MaSp, sp);
                sp.Nhom = this;
            }
            else
            {
                Console.WriteLine("Bạn nhập trùng mã rồi!");
            }
        }
        public Dictionary<string, SanPham> dicSP
        {
            get { return this.dsSP; }
            set { this.dsSP = value; }
        }
        public override string ToString()
        {
            return this.TenDM;
        }
    }
}
