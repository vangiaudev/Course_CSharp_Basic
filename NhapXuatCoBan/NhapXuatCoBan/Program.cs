using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhapXuatCoBan
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Nguyen Van Giau"); //Write co them chu Line la xuong dong
            //Console.Write("06/04/2001 \n"); // \n la xuong dong
            //Console.Write(10.66f);

            //Console.Write(Environment.NewLine); // cung la lenh xuong dong
            //Console.Write(true);
            //Console.ReadLine(); // (=) ReadKey() => stop man hinh

            //int a = 999;
            //int b = 45;
            //Console.WriteLine("a = {1}", a, b); // in ra man hinh a = 999 neu {0}, b = 45 neu {1}
            //Console.Write("{0} {1} {2}", 111, 222, "Nguyen Van Giau"); //in ra theo thu tu

            //Console.WriteLine(Console.Read()); //doc 1 ki tu nhap tu ban phim, in ra so trong ma ASCII
            //Console.WriteLine(Console.ReadLine()); // doc du lieu cho den khi nhan Enter thi stop, in ra chu nhap vao

            //Console.Readkey(); //ko truyen tham so vao mac dinh la false
            //Console.Readkey(false); //hien thi phim an ra man hinh
            //Console.ReadKey(true); // ko hien thi phim an ra man hinh
            //Console.ReadKey();

            //VÍ DỤ TẠO TÀI KHOẢN ID
            Console.OutputEncoding = Encoding.UTF8;//lệnh xuất chữ tiếng việt có dấu
            Console.ForegroundColor = ConsoleColor.Blue; // tô màu cho chữ
            Console.Write("Please Enter Your Username:");
            Console.WriteLine("Username your is: \t" + Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Please Enter Your Password:");
            Console.WriteLine("Password your is: \t" + Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Congratulations on create your account successfully");
            Console.ReadKey();

        }

    }
}
