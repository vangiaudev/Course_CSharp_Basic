using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuVien
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; // hàm chỉnh tiếng việt
            //Random rd = new Random();
            //int z = rd.Next(1, 51); // xuất ra số ngẫu nhiên từ 1-50 => [1, 51)
            //Console.WriteLine(z);
            //double k = rd.NextDouble(); // xuất số thập phân ngẫu nhiên từ 0->1 
            //Console.WriteLine(k);

            //NGÀY THÁNG: DATETIME
            DateTime birth = new DateTime(2002, 12, 13); //năm-tháng-ngày
            Console.WriteLine(birth.ToString("dd/MM/yyyy"));

            DateTime d = DateTime.Parse("06/04/2001");
            Console.WriteLine(d.ToString("dd/MM/yyyy"));

            //Ví Dụ
            Console.WriteLine("Mời bạn nhập ngày sinh: ");
            string s = Console.ReadLine();
            DateTime ns = new DateTime();
            ns = DateTime.Parse(s);
            Console.WriteLine("Bạn sinh ngày: " + ns.Day);
            Console.WriteLine("Bạn sinh tháng: " + ns.Month);
            Console.WriteLine("Bạn sinh năm: " + ns.Year);


            
        }
    }
}
