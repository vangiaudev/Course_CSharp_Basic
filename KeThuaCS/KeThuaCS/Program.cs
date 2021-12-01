using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeThuaCS
{   public class NhanVien
    {
        public int Ma { get; set; }
        public string Ten { get; set; }
        public void TinhLuong()
        {
            Console.WriteLine("Day la phuong thuc tinh luong cua nhan vien");
        }
        public virtual int TinhLuong(int NgayCong)
        {
            return NgayCong * 100000;
        }
    }
    class Program
    {   static void TestNhanVien()
        {
            NhanVienChinhThuc Teo = new NhanVienChinhThuc();
            Teo.Ma = 1;
            Teo.Ten = "Nguyễn Văn Tèo";
            Console.WriteLine("Lương của " + Teo.Ten + " là: "  );
            Teo.TinhLuong();

            NhanVienThoiVu Ty = new NhanVienThoiVu();
            Ty.Ma = 2;
            Ty.Ten = "Hồ Thị Tý";
            Console.WriteLine("Lương của " + Ty.Ten + " là: " );
            Ty.TinhLuong();
        }
        static void TestNhanVien2()
        {
            NhanVienChinhThuc Obama = new NhanVienChinhThuc();
            int luong = Obama.TinhLuong(20);
            Console.WriteLine(luong);
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //TestNhanVien();
            TestNhanVien2();
            Console.ReadLine();
        }
    }
}
