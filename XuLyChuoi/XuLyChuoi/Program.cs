using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XuLyChuoi
{
    class Program
    {   
        static void XuLyChuoi1()
        {
            string s = "";
            Console.WriteLine("Mời bạn nhập vào 1 chuỗi: ");
            s = Console.ReadLine();

            int demInHoa = 0, demInThuong = 0, demSo = 0, demKT = 0;
            char[] arr = s.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {

                if (char.IsLower(arr[i])) demInThuong++;
                if (char.IsUpper(arr[i])) demInHoa++;
                if (char.IsDigit(arr[i])) demSo++;
                if (char.IsWhiteSpace(arr[i])) demKT++;
            }
                Console.WriteLine("Có {0} kí tự in thường", demInThuong);
                Console.WriteLine("Có {0} kí tự in HOA", demInHoa);
                Console.WriteLine("Có {0} kí tự số", demSo);
                Console.WriteLine("Có {0} kí tự khoảng trắng", demKT);
            Console.ReadKey();
        }
        static void XuLyChuoi2()
        {
            string s = "";
            Console.WriteLine("Mời bạn nhập vào 1 chuỗi: ");
            s = Console.ReadLine();

            int demInHoa = 0, demInThuong = 0, demSo = 0, demKT = 0;
           
            for (int i = 0; i < s.Length; i++)
            {
                char kt = s[i];
                if (char.IsLower(kt)) demInThuong++;
                if (char.IsUpper(kt)) demInHoa++;
                if (char.IsDigit(kt)) demSo++;
                if (char.IsWhiteSpace(kt)) demKT++;
            }
            Console.WriteLine("Có {0} kí tự in thường", demInThuong);
            Console.WriteLine("Có {0} kí tự in HOA", demInHoa);
            Console.WriteLine("Có {0} kí tự số", demSo);
            Console.WriteLine("Có {0} kí tự khoảng trắng", demKT);
            Console.ReadKey();
        }
        static void XuLyChuoi3()
        {
            string s;
            Console.WriteLine("Mời bạn nhập vào chuỗi thứ 1: ");
            s = Console.ReadLine();
            Console.WriteLine("Mời bạn nhập chuỗi thứ 2: ");
            string s2 = Console.ReadLine();
            int kq = s.ToLower().CompareTo(s2.ToLower()); //so sánh mà không phân biệt chữ hoa chữ thường

            if(kq == 0)
            {
                Console.WriteLine("Chuỗi 1 bằng chuỗi 2");
            }
            if(kq < 0)
            {
                Console.WriteLine("Chuỗi 1 nhỏ hơn chuỗi 2");
            }
            if(kq > 0)
            {
                Console.WriteLine("Chuỗi 1 lớn hơn chuỗi 2");
            }
        }
        static void XuLyChuoi4()
        {
            string s = string.Format("{0:dd//MM/yyyy HH:mm:ss}", DateTime.Now); //trả về ngày giờ của hệ thống hiện tại
            Console.WriteLine(s);
            Console.ReadLine();
        }
        static void XuLyChuoi5()
        {
            string s = "D:/baihat/nhactre/Co chac yeu la day.mp3";
            //tìm vị trí đầu tiên của kí tự "/"
            int pos = s.IndexOf("/");
            Console.WriteLine("Đã tìm thấy kí tự / ở vị trí thứ {0}", pos);
            //tìm vị trí cuối cùng của kí tự "/"
            int posend = s.LastIndexOf("*");
            Console.WriteLine("Đã tìm thấy kí tự / ở vị trí cuối cùng là {0}", posend);
            Console.ReadLine();
        }
        static void XuLyChuoi6()
        {
            string s = "D:/baihat/nhactre/Co chac yeu la day.mp3";
            //tách tên bài hát ra khỏi chuỗi s
            int pos = s.LastIndexOf("/");
            string tenBaiHat = s.Substring(pos + 1); // lấy tên bài hát từ vị trí pos + 1
            Console.WriteLine(tenBaiHat);
            int pos2 = tenBaiHat.LastIndexOf(".");
            string tenBaiHat2 = tenBaiHat.Substring(0, pos2); // lấy ra chuỗi từ vị trí thứ 0 cho tới vị trí nào đó
            Console.WriteLine(tenBaiHat2);
        }
        static void XuLyChuoi7()
        {
            string line = "45.01.104.061;Nguyễn Văn Giàu;01/04/2001";
            string[] arr = line.Split(';');
            
            Console.WriteLine("MSSV: {0}", arr[0]);
            Console.WriteLine("Họ Tên: {0}", arr[1]);
            Console.WriteLine("Ngày sinh: {0}", arr[2]);
            //Array.Reverse(arr);

        }
        static void ChuanHoaChuoi()
        {
            //cho 1 chuỗi gốc, yêu cầu:
            //1.Xóa các khoảng trắng thừa bên trái, phải chuỗi,
            //các từ cách nhau 1 khoảng trắng, kí tự đầu tiên IN HOA
            //VD:
            //   Nguyen     vAN   TEO
            //sau khi chuẩn hóa: Nguyen Van Teo
            Console.WriteLine("Mời bạn nhập vào một chuỗi: ");
            string name = Console.ReadLine();
            Console.WriteLine("Chuỗi gốc bạn nhập: ");
            Console.WriteLine(name);

            name = name.Trim(); // xóa khoảng trắng dư thừa ở đầu và cuối chuỗi
            string[] arr = name.Split(
                new char[] { ' ' }, // kí tự để tách chuỗi: VD khoảng trắng
                StringSplitOptions.RemoveEmptyEntries);
            name = "";
            for (int i = 0; i < arr.Length; i++)
            {
                
                string word = arr[i];
                word = word.ToLower(); //đưa về in thường
                char[] arrWord = word.ToCharArray();//hàm ToCharArr() trả về các kí tự nằm bên trong word
                       arrWord[0] = char.ToUpper(arrWord[0]); // in hoa kí tự đầu của mỗi từ


                string newWord = new string(arrWord);
                name = name + newWord + " "; // nối lại

            }
            name = name.Trim(); //xóa khoảng trắng cuối chuỗi
            Console.WriteLine("Chuỗi sau khi được chuẩn hóa: ");
            Console.WriteLine(name);


            //Cách 2:
            //Console.OutputEncoding = Encoding.UTF8;
            //Console.WriteLine("Nhập họ và tên: ");
            //string HoVaTen = Console.ReadLine();
            //HoVaTen = HoVaTen.Trim(); // xóa khảng trắng dư thừa

            //string[] arr = HoVaTen.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            //HoVaTen = "";
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    string ho = arr[i].Substring(0, 1).ToUpper() + arr[i].Substring(1, arr[i].Length - 1).ToLower();
            //    HoVaTen = HoVaTen + ho + " ";
            //}
            //Console.WriteLine("Ten sau khi chuan hoa: " + HoVaTen);

        }
        static void Main(string[] args)
        {
            //bài tâp: nhập vào 1 chuỗi
            //1. đếm xem có bao nhiêu in hoa, in thường, số;
            //2. đếm khoảng trắng trong chuỗi
            Console.OutputEncoding = Encoding.UTF8;
            //XuLyChuoi1();
            //XuLyChuoi1();
            //XuLyChuoi3();
            //XuLyChuoi4();
            XuLyChuoi5();
            //XuLyChuoi6();
            //XuLyChuoi7();
            //ChuanHoaChuoi();
          
        }
    }
}
