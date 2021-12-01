using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang
{
    class Program
    {
        static void HocMang1Chieu()
        {
            //1. Nhập giá trị ngẫu nhiên
            Console.WriteLine("Mời bạn nhập số phần tử của mảng");
            int n = int.Parse(Console.ReadLine());
            int[] M = new int[n];
            Random rd = new Random();
            for (int i = 0; i < M.Length; i++)
            {
                M[i] = rd.Next(100); //==> lấy ngẫu nhiên từ 0 -> 99
            }
            //2.Xuất mảng
            Console.WriteLine("Mảng ngẫu nhiên là:");
            for (int i = 0; i < M.Length; i++)
            {
                Console.Write(M[i] + " ");
            }
            Console.WriteLine();
            //3.Đảo ngược mảng
            Array.Reverse(M); // ==> hàm đảo chiều mảng
            Console.WriteLine("Mảng sau khi đảo chiều là:");
            foreach (var i in M)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            //4.Sắp xếp mảng
            Array.Sort(M); // ==> hàm sắp xếp (mặc định là tăng dần)
            Console.WriteLine("Mảng sau khi sắp xếp: ");
            foreach (var i in M)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            //5.Tính Tổng Mảng
            Console.WriteLine("Tổng phần tử mảng: ");
            int sum = 0;
            foreach (var i in M)
            {
                sum += i;
            }
            Console.WriteLine(sum);
            //6. Tìm kiếm mảng
            Console.WriteLine("Mời bạn nhập số cần tìm: ");
            int k = int.Parse(Console.ReadLine());
            int kq = Array.BinarySearch(M, k); // LƯU Ý: phải sắp xếp mảng trước khi dùng hàm BinarySearch()
            if(kq < 0)
            {
                Console.WriteLine("Không tìm thấy {0} trong mảng", k);
            }
            else
            {
                Console.WriteLine("Tìm thấy {0} ở vị trí thứ {1}", k, kq);
            }

            //7. Tìm kiếm tuyến tính(không quan tâm là mảng đã được sắp xếp hay chưa)
            Console.WriteLine("Mời bạn nhập số cần tìm theo tuyến tính: ");
            k = int.Parse(Console.ReadLine());
            int re = -1;
            for (int i = 0; i < M.Length; i++)
            {
                if(M[i] == k)
                {
                    re = i;
                    break;
                }
            }
            if (re == -1)
            {
                Console.WriteLine("Không tìm thấy {0} trong mảng", k);
            }
            else
            {
                Console.WriteLine("Tìm thấy {0} ở vị trí thứ {1}", k, re);
            }

        }
        static void HocMang2Chieu()
        {
            //CÚ PHÁP KHAI BÁO MẢNG 2 CHIỀU
            int[,] M2C = new int[2, 3]; //2 dòng 3 cột
            string[,] str2c = new string[,]
            {
                {"Ho", "Ten"},
                {"Nguyen", "Giau" }         //khởi tạo giá trị cho mảng 2 chiều
            };

            int[,] K = new int[,]
            {
                {1, 2, 3, 4, 5},
                {6, 7, 8, 9, 10},
                {11, 12, 13, 14, 15}
            };
            int sum = 0;
            for (int i = 0; i < M2C.GetLength(0); i++)
            {
                for (int j = 0; j < M2C.GetLength(1); j++)
                {
                    Console.Write(" Moi ban nhap phan tu IntM2C[{0}, {1}] = ", i, j);
                    M2C[i, j] = int.Parse(Console.ReadLine()); // Nhập mảng 2C
                }
            }

            Console.WriteLine("Mang 2 chieu sau khi nhap la: \n");
            for (int i = 0; i < M2C.GetLength(0); i++)  // GetLength(0) => trả về số DÒNG của M2C
            {
                for (int j = 0; j < M2C.GetLength(1); j++) //GetLength(1) => trả về số CỘT của M2C
                {
                    Console.Write(M2C[i, j] + " "); // Xuất mảng 2C
                    sum += M2C[i, j];
                }
                Console.Write(Environment.NewLine);
            }
            Console.WriteLine("Tong gia tri la: " + sum);
            Console.ReadKey();

        }
        static void Main(string[] args)
        {
            //int[] arr = new int[4]; // khởi tạo và cấp phát số lượng phần tử của mảng
            //string[] str = new string[] { "Nguyen", "Van", "Giau" }; // khởi tạo luôn giá trị cho mảng

            //for(int i = 0; i<arr.Length; i++) // Length là lấy độ dài của mảng
            //{
            //    arr[i] = Convert.ToInt32(Console.ReadLine()); // nhập mảng
            //}

            //for (int i = 0; i < arr.GetLength(0); i++) //GetLength tương tự Length nhưng phải truyền vào 0
            //{
            //    Console.WriteLine(arr[i]); //xuất mảng
            //}
            Console.OutputEncoding = Encoding.UTF8;
            HocMang1Chieu();
           
        }
    }
}
