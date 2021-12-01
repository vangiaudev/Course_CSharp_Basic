using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeThuaCS
{
    public class NhanVienChinhThuc : NhanVien 
    {
        public new void TinhLuong() //thêm từ khóa new
        {
            base.TinhLuong();
            Console.WriteLine("Day la phuong thuc tinh luong cua nhan vien chinh thuc");
        }
        public override int TinhLuong(int NgayCong)
        {
            if (NgayCong == 20)
            {
                return 10000000;
            }
            return base.TinhLuong(NgayCong);
        }
    }
}
