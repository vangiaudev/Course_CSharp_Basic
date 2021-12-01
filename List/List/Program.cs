using System;
using System.Collections.Generic; //thư viện của LIST
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {   
        static void HocList()
        {
            //cấp phát bộ nhớ
            List<string> ds = new List<string>();
            //thêm phần tử
            ds.Add("Nguyen");
            ds.Add("Van");
            ds.Add("Giau");
            //chèn
            ds.Insert(1, "Recca");
            //xóa
            ds.Remove("Nguyen");
            ds.RemoveAt(0); // xóa phần tử vị trí thứ 0
            Console.WriteLine("Danh sach cac phan tu trong List la: ");
            for(int i = 0; i<ds.Count; i++) //count tương tự như length
            {
                Console.WriteLine(ds[i]);
            }
        }
        static void HocList2()
        {
            List<int> ds = new List<int>();
            Random rd = new Random();
            for(int i = 0; i<10; i++)
            {
                ds.Add(rd.Next(100));
            }
            Console.WriteLine("Cac phan tu trong danh sach goc la: ");
            foreach (var i in ds)
            {
                Console.Write(i + "\t");
            }
            ds.Sort();
            Console.WriteLine();
            Console.WriteLine("Cac phan tu trong danh sach sap xep la: ");
            foreach (var i in ds)
            {
                Console.Write(i + "\t");
            }

        }
        static void Main(string[] args)
        {
            //HocList2();
            string s = Console.ReadLine();
            int kq;
            int dem = 0;
            while (int.TryParse(s, out kq))
            {
                dem++;
                s = Console.ReadLine();
            }
            Console.WriteLine(dem);
        }
    }
}
