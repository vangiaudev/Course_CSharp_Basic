using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuongDoiTuongTrongCS
{
    public class SinhVien
    {
        #region Các biến lớp
        private int ma;
        private string ten;
        private DateTime namsinh;
        #endregion

        #region Các constructor
        public SinhVien() // hàm contructer
        {
            this.ma = 1;
            this.ten = "Tên gì đó";
        }
        public SinhVien(int ma, string ten)
        {
            this.ma = ma;
            this.ten = ten;
        }
        #endregion

        #region Các properties
        public int Ma
        {
            get { return this.ma; }
            set { this.ma = value; }
        }
        public string Ten
        {
            get { return this.ten; }
            set { this.ten = value; }
        }
        public DateTime NamSinh
        {
            get { return this.namsinh; }
            set { this.namsinh = value; }
        }
        #endregion

        #region Các phương thức
        public override string ToString()
        {
            return this.ma + "\t" + this.ten;
        }
        private bool KiemTraNamSinhHopLe()
        {
            return DateTime.Now.Year - this.namsinh.Year >= 18;
        }
        public void XuatThongTin()
        {
            if(KiemTraNamSinhHopLe() == false)
            {
                Console.WriteLine("Năm sinh không hợp lê");
            }
            else
            {
                Console.WriteLine(ToString());
            }
        }
        #endregion

    }
    public class HamParam
    {
        public int TinhTong(params int []arr)
        {
            int sum = 0;
            foreach (int i in arr)
            {
                sum = sum + i;
            }
            return sum;
        }
    }
    public class KhachHang // Cách không cần khởi tạo các biến lớp mà sử dụng trực tiếp thông qua Properties
    {
        public int Ma { get; set; }
        public string Ten { get; set; }
        public string Phone { get; set; }

        //Alias và cơ chế gom rác tự động: Sao chép class KhachHang và tạo thành vùng nhớ riêng
        public KhachHang copy()
        {
            return this.MemberwiseClone() as KhachHang;
        }
    }
    class Program
    {
        static void TestKhachHang()
        {
            List<KhachHang> dskh = new List<KhachHang>();
            dskh.Add(new KhachHang() { Ma = 1, Ten = "Ông Tèo", Phone = "0909083132" });
            //cách 2:
            KhachHang kh = new KhachHang();
            kh.Ma = 2;
            kh.Ten = "Hồ Văn Đồ";
            kh.Phone = "0343479496";
            dskh.Add(kh);

            foreach (KhachHang i in dskh)
            {
                Console.WriteLine(i.Ma + "\t" + i.Ten + "\t" + i.Phone);
            }
        }
        static void TestAliasVaGomRac()
        {
            KhachHang teo = new KhachHang();
            teo.Ma = 10;
            teo.Ten = "Trần Văn Tèo";
            teo.Phone = "07777777777";
            KhachHang ty = new KhachHang();
            ty.Ma = 11;
            ty.Ten = "Hồ Thị Tý";
            ty.Phone = "099999999999";
            teo = ty;
            Console.WriteLine("Tên của tèo là: {0}", teo.Ten);
            //vậy ô nhớ Tèo đang trỏ trước lúc gán bị thu hồi
            //và lúc này ô nhớ của Tý có thêm tèo
            // ==> Tèo đổi thì Tý cũng đổi theo
            //Ví dụ:
            teo.Ten = "OBAMA Alibaba";
            Console.WriteLine("Tên của Tý là: {0}", ty.Ten);

            //Test Hàm Copy()

            KhachHang an = new KhachHang() { Ma = 100, Ten = "An" };
            KhachHang binh = an.copy();
            //lúc này theo MemberwiseClone thì nó sao chép toàn bộ thông tin của an
            //ra 1 ô nhớ mới hoàn toàn độc lâp, ô nhớ này do Bình quản lý
            //==> An đổi chả ảnh hưởng gì tới Bình
            binh.Ten = "Bình Bình Bình";
            Console.WriteLine("Tên của An là: {0}", an.Ten);
            
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            SinhVien teo = new SinhVien();
            teo.Ma = 113;
            teo.Ten = "Nguyễn Văn Tèo"; // bên trái dấu = là gọi thương thức set
            Console.WriteLine(teo);

            string s = teo.Ten; // bên phải dấu = gọi theo phương thức get

            SinhVien ty = new SinhVien(114, "Hồ Thị Tý");
            Console.WriteLine(ty);

            SinhVien giau = new SinhVien();
            giau.Ma = 4061;
            giau.Ten = "Nguyễn Văn Giàu";
            giau.NamSinh = new DateTime(2001, 06, 04);
            giau.XuatThongTin();

            // từ khóa params giúp ta nhập bao nhiêu đối số cũng được
            HamParam t = new HamParam();
            Console.WriteLine(t.TinhTong(1, 2, 3));
            Console.WriteLine(t.TinhTong(-8));
            Console.WriteLine(t.TinhTong());

            //
            TestKhachHang();
            //
            TestAliasVaGomRac();


        }
    }
}
