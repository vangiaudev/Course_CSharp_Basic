using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1, "Nguyen Van Giau");
            dic.Add(2, "Nguyen Van Teo");
            if(dic.ContainsKey(2) == false) // kiểm tra Key(2) có tồn tại hay không rồi mới add vào
            {
                dic.Add(2, "Ho Van Do");
            }
            dic.Add(3, "Nguyen Thi Long Lanh");

            // Để duyệt toàn bộ dữ liệu trong Dictionary ta làm như sau:

            foreach (KeyValuePair<int, string> item in dic)
            {
                Console.WriteLine("Mã: " + item.Key + " Ten: " + item.Value);
            }
            dic.Remove(2);
            Console.WriteLine("Dic sau khi xoa phan tu co khoa chinh la 2: ");
            foreach (KeyValuePair<int, string> item in dic)
            {
                Console.WriteLine("Mã: " + item.Key + " Ten: " + item.Value);
            }
            Console.WriteLine();
            Console.WriteLine("Doi tuong co khoa chinh la 3: ");
            string str = dic[3];
            Console.WriteLine(str);

            //CHUYỂN TỪ DICTIONARY SANG LIST
            List<string> dsGiaTri = dic.Values.ToList(); //lấy tập các giá trị của Dic
            Console.WriteLine("Cac gia tri la: ");
            foreach (string s in dsGiaTri)
            {
                Console.WriteLine(s);
            }

            List<int> dsKey = dic.Keys.ToList(); // lấy theo Key
            Console.WriteLine("Cac Key la: ");
            foreach (int k in dsKey)
            {
                Console.WriteLine(k);
            }
        }
    }
}
