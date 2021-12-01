using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectChuongTrinhQuanLySanPham
{
    public class SanPham
    {
        public string MaSp { get; set; }
        public string TenSP { get; set; }
        public float DonGia { get; set; }
        public string XuatXu { get; set; }
        public DateTime HanDung { get; set; }
        public DanhMuc Nhom { get; set; }

        public override string ToString()
        {
            return this.TenSP;
        }
    }
}
