using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaHinhCS
{
    class Program
    {
        static void TestHinhHoc()
        {
            HinhHoc hh = new HinhHoc();
            int kq = hh.TinhDienTich();
            Console.WriteLine(kq);

        }
        static void TestHCN()
        {
            HinhChuNhat hcn = new HinhVuong(5);
            
            Console.WriteLine(hcn.ChuVi());
            Console.WriteLine(hcn.TinhDienTich());

        }
        static void TestInterface()
        {
            ILamViec teo = new NhanVien();
            Console.WriteLine(teo.LamViec("Báo cáo kinh doanh"));
            ILamViec giau = new SinhVien();
            Console.WriteLine(giau.LamViec("Học bài c#"));
        }
        static void TestHocISvaAS() //dùng để phân loại đối tượng nào
        {

            List<ILamViec> ds = new List<ILamViec>();
            NhanVien teo = new NhanVien() { MaNV = "1", TenNV = "Nguyễn Văn Tèo" };
            ds.Add(teo);
            SinhVien ty = new SinhVien() { MaSV = "3", TenSV = "Hồ Thị Tí" };
            ds.Add(ty);
            ds.Add(new NhanVien() { MaNV = "2", TenNV = "Trần Văn Obama" });
            foreach (ILamViec item in ds)
            {
                if(item is NhanVien) //kiểm tra nếu ds thứ item mà là NhanVien bằng từ khóa "is"
                {
                    NhanVien nv = item as NhanVien; //thì ta ép lại đúng kiểu đó bằng từ khóa "as"
                    Console.WriteLine(nv.TenNV + " là nhân viên");
                }
                else if(item is SinhVien)
                {
                    SinhVien sv = item as SinhVien;
                    Console.WriteLine(sv.TenSV + " là sinh viên");
                }
            }
        }
        static void Main(string[] args)
        {
            TestHinhHoc();
            Console.OutputEncoding = Encoding.UTF8;
            //TestHCN();
            //TestInterface();
            //TestHocISvaAS();
            
        }
    }
}
