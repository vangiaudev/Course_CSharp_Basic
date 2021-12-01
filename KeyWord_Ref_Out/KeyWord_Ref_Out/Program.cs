using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyWord_Ref_Out
{
    class Program
    {
        static void Main(string[] args)
        {
            int value;
            value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Gia tri truoc khi tang: {0}", value);
            //TangGiaTri(ref value); // nếu không có từ khóa ref thì Hàm TangGiaTri sẽ không liên kết vs câu lệnh bên dưới

            TangGiaTri(out value); // từ khóa out sẽ giúp hàm bên dưới thoát khỏi giá trị value bên trên và thực hiện một giá trị mới,
                                   // bắt buộc phải khởi tạo giá trị mặc định phía dưới hàm
            Console.WriteLine("Gia tri sau khi tang: {0}", value);

        }
        static void TangGiaTri(out int n)
        {
            n = 100;
            n++;
        }
    }
}
