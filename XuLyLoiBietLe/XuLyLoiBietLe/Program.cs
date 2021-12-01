using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XuLyLoiBietLe
{
    class Program
    {
        static void HocBietLe1()
        {
            try
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.WriteLine("Mời bạn nhập năm sinh:");
                string s = Console.ReadLine();
                DateTime birth = DateTime.Parse(s);
                Console.WriteLine("Bạn vừa nhập năm sinh" + birth.ToString("dd/MM/yyyy"));
                Console.ReadLine();

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);

            }
            finally
            {
                Console.WriteLine("Lỗi hay không lỗi cũng vào đây");
            }
        }
        static void HocBietLe2()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Mời bạn nhập vào tử số: ");
            int tu = int.Parse(Console.ReadLine());
            Console.WriteLine("Mời bạn nhập vào mẫu số: ");
            int mau = int.Parse(Console.ReadLine());
            if(mau == 0)
            {
                throw new ArithmeticException("Lỗi mẫu số không được bằng 0");
            }
            if(mau == -1)
            {
                throw new Exception("Mau so ko dc bang -1");
            }
        }
        static void Main(string[] args)
        {   
            //Try_catch là để xuất thông báo lỗi ra màn hình
            try
            {
                HocBietLe2();
            }
            catch (ArithmeticException ex)
            {

                Console.WriteLine(ex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Loi thu 2" + e.Message);
            }
            finally
            {
                Console.WriteLine("the end");
                // Luôn được thi hành dù có phát sinh ngoại lệ hay không
            }


            Console.ReadKey();

        }
    }
}
