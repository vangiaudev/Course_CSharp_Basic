using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuongDoiTuong
{
    public class SinhVien
    {
        #region Các biến lớp
        private int ma;
        private string ten;
        #endregion

        #region Các constructor
        public SinhVien() // hàm contructer
        {
            this.ma = 1;
            this.ten = "Tên gì đó";
        }
        public SinhVien(int ma, string ten)
        {
            this.ma = ma;
            this.ten = ten;
        }
        #endregion

        #region Các properties
        public int Ma
        {
            get { return this.ma; }
            set { this.ma = value; }
        }
        public string Ten
        {
            get { return this.ten; }
            set { this.ten = value; }
        }
        #endregion

        #region Các phương thức
        public override string ToString()
        {
            return this.ma + "\t" + this.ten;
        }
        #endregion
    }
}
