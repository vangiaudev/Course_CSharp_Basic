using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraCuuTuDien
{
    class Program
    {
        static Dictionary<string, string> dic = new Dictionary<string, string>();

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {
                menu();
                Console.WriteLine("Bạn có tiếp tục sử dụng từ điển không?(c/k) ");
                string s = Console.ReadLine();
                if(s == "k")
                {
                    Console.WriteLine("Bye bye!");
                    break;
                }
            }
               
        }
        private static void menu()
        {
            Console.WriteLine("Mời bạn chọn chức năng: ");
            Console.WriteLine("1. Tạo từ mới");
            Console.WriteLine("2. Sửa từ");
            Console.WriteLine("3. Tra cứu từ");
            Console.WriteLine("4. Xóa từ");
            
            try
            {
                int chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        TaoTuMoi();
                        break;
                    case 2:
                        SuaTu();
                        break;
                    case 3:
                        TraCuu();
                        break;
                    case 4:
                        XoaTu();
                        break;
                    default:
                        Console.WriteLine("Bạn đã nhập sai");
                        break;
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Bị lỗi rồi: " + ex.Message);
            }
           

        }

        private static void XoaTu()
        {
            Console.WriteLine("Mời bạn nhập vào từ muốn xóa: ");
            string ta = Console.ReadLine();
            if(dic.ContainsKey(ta) == true)
            {
                dic.Remove(ta);
                Console.WriteLine("Xóa thành công từ [{0}]", ta);
            }
            else
            {
                Console.WriteLine("Không tìm thấy từ để xóa");
            }
        }

        private static void TraCuu()
        {
            Console.WriteLine("Mời bạn nhập từ tiếng Anh: ");
            string ta = Console.ReadLine();
            if(dic.ContainsKey(ta) == false)
            {
                Console.WriteLine("Từ điển chưa đc cập nhật");
            }
            else
            {
                string tv = dic[ta];
                Console.WriteLine("Nghĩa của [{0}] là [{1}]", ta, tv);
            }
        }

        private static void SuaTu()
        {
            Console.WriteLine("Nhập vào Tiếng Anh để sửa lại nghĩa: ");
            string ta = Console.ReadLine();
            if(dic.ContainsKey(ta) == false)
            {
                Console.WriteLine("Khong tim thấy [{0}] để sửa ", ta);
            }
            else
            {
                Console.WriteLine("Mời bạn nhập lại nghĩa Tiếng Việt");
                string tv = Console.ReadLine();
                dic[ta] = tv;
            }
        }

        private static void TaoTuMoi()
        {
            Console.WriteLine("Mời bạn nhập vào từ tiếng Anh:");
            string ta = Console.ReadLine();
            if (dic.ContainsKey(ta))
            {
                Console.WriteLine("Từ [{0}] đã tồn tại ", ta);
            }
            else
            {
                Console.WriteLine("Mời bạn nhập nghĩa tiếng Việt: ");
                string tv = Console.ReadLine();
                dic.Add(ta, tv);
            }

        }
    }
}
