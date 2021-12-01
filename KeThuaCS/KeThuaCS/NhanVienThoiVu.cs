using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeThuaCS
{
    public class NhanVienThoiVu : NhanVien
    {
        public new void TinhLuong()
        {
            base.TinhLuong();
            Console.WriteLine("Day la phuong thuc tinh luong cua nhan vien thoi vu");
        }
    }
}
