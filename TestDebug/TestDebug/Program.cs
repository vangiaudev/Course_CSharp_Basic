using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDebug
{
    class Program
    {   
        //ax^2+bx+c=0;
        static string GiaiPTBac2(int a, int b, int c)
        {
            if (a == 0)
            {
                if (b == 0 && c == 0)
                {
                    return "VSN";
                }
                if (b == 0 && c != 0)
                {
                    return "VN";
                }
                return "x="+ - ((double)c / b);
            }
            else
            {
                double delta = Math.Pow(b, 2) - 4 * a * c;
                if(delta < 0)
                {
                    return "VN";
                }
                if(delta == 0)
                {
                    double x = -b / 2 * a;
                    return "x1=x2=" + x;
                }
                else
                {
                    double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                    return "x1=" + x1 + "; x2=" + x2;
                }
            }
        }
        static void Main(string[] args)
        {
            string kq = GiaiPTBac2(0, 0, 0);
            Console.WriteLine(kq);

            kq = GiaiPTBac2(0, 0, 5);
            Console.WriteLine(kq);

            //0x^2 + 8x + 3 = 0
            //8x = -3
            //x=-3/8
            kq = GiaiPTBac2(0, 8, 3);
            Console.WriteLine(kq);

            //2x^2 + 8X -7 = 0;
            kq = GiaiPTBac2(2, 5, -7);
            Console.WriteLine(kq);
            Console.ReadKey();

        }
    }
}
