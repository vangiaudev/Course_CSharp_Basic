using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTongHop
{
    class Program
    {
        static void Play()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Random rd = new Random();
            int soMay = rd.Next(501);
            int soNguoi, soLanDoan = 0;
            while (true)
            {
                Console.WriteLine("Máy đã ra một số [0, 500],  mời bạn dự đoán: ");
                soNguoi = int.Parse(Console.ReadLine());
                soLanDoan++;
                Console.WriteLine("Bạn đoán lần thứ {0}", soLanDoan);
                if(soNguoi == soMay) //thắng vì đoán đúng
                {
                    Console.WriteLine("Congratulations! Bạn đã đoán đúng, số của máy = {0}", soMay);
                    break;
                }
                if (soNguoi < soMay)
                {
                    Console.WriteLine("Số bạn đoán nhỏ hơn số của máy");
                }
                else
                {
                    Console.WriteLine("Số bạn đoán lớn hơn số của máy");
                }
                if(soLanDoan == 7)
                {
                    Console.WriteLine("GAME OVER! Bạn đã đoán quá 7 lần");
                    Console.WriteLine("Số của máy là: {0}", soMay);
                    break;
                }
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Play();
                Console.OutputEncoding = Encoding.UTF8;
                Console.WriteLine("Bạn có muốn tiếp tục không(c/k)?");
                string s = Console.ReadLine();
                if (s == "k")
                {
                    break;
                }
            }
           
            Console.ReadKey();
        }
    }
}
