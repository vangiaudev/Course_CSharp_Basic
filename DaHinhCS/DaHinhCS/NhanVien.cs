using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaHinhCS
{
    public class NhanVien : ILamViec
    {
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string LamViec(string mota)
        {
            string s = "Nhan Vien dang " + mota;
            return s;
        }
    }
}
