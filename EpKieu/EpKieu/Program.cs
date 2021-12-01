using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpKieu
{
    class Program
    {
        static void Main(string[] args)
        {   //Cách 1: Parse()

            //string s = "100";
            //int x = int.Parse(s); // ép chuỗi 10 thành số 10
            //Console.WriteLine(x+20); // xuất ra màn hình 120;

            //Cách 2: TryParse()

            //int result;
            //string data = "100";
            //bool k = int.TryParse(data, out result);
            //Console.WriteLine(result+20);// xuất ra 120 là ép kiểu thành công

            //Cách 3: Convert.

            //double d = 9.6;
            //double value = Convert.ToInt16(d); //chuyển từ kiểu DOUBLE sang INT
            //Console.WriteLine(value);

            //VÍ DỤ CHƯƠNG TRÌNH TÍNH TỔNG HIỆU TÍCH THƯƠNG:
            Console.WriteLine("*******************************");
            Console.WriteLine("* Tong ~ Hieu ~ Tich ~ Thuong *");
            Console.WriteLine("*******************************");
            Console.WriteLine(Environment.NewLine);

            int A, B;
            string InA, InB;

            Console.WriteLine("Moi ban nhap so A: ");
            InA = Console.ReadLine();
            Console.WriteLine("Moi ban nhap so B: ");
            InB = Console.ReadLine();

            A = int.Parse(InA);
            B = int.Parse(InB);
           
            Console.WriteLine("Tong = " + (A+B));

            Console.WriteLine("Hieu = "+ (A - B));
            Console.WriteLine("Tich = "+ (A * B));
            Console.WriteLine("Thuong = " + ((float)A / B));
            Console.ReadKey();




        }
    }
}
