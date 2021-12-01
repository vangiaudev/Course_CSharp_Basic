using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuyenTapNhapXuatCB
{
    class Program
    {   
        static int ReverseNumber(int n)
        {
            int tmp = 0;
            while (n != 0)
            {
                int sd = n % 10;
                tmp = tmp * 10 + sd;
                n /= 10;
            }
            return tmp;
        }
        static void Main()
        {
            int n;
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i < 10; i++)
            {
                int item = n * i;
                if (item < 10)
                {
                    Console.WriteLine("{0}x{1}={3}", n, i, item);
                }
                else
                {
                    Console.WriteLine("{0}x{1}={3}", n, i, ReverseNumber(item));
                }
            }
        }
      
    }
}
