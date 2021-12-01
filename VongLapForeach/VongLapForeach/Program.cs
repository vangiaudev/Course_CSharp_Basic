using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VongLapForeach
{
    class Program
    {
       
        static void Main()
        {
            int[] diem = new int[5] { 6, 7, 8, 9, 10 };
            foreach (int i in diem)
            {
                //Console.WriteLine(i.ToString());
                Console.WriteLine(i); // xuất ra các giá trị trong mảng điểm
            }
            // KHÔNG NÊN DÙNG FOREACH KHi:
            // -Cần duyệt 1 phần tử nào đó trong mảng (ví dụ từ phần tử 2 -> 9)
            // -Cần duyệt từ cuối mảng về đầu mảng
            // -Cần biết chỉ số mảng trong vòng lặp
            // -Cần thay đổi giá trị của phần tử mảng
            // -Cần xóa phần tử
        }
    }
}
