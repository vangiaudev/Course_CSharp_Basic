using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class SanPhamAccess : DatabaseAccess
    {
        public List<SanPham> LayToanBoSanPham()
        {
            List<SanPham> dsSP = new List<SanPham>();
            OpenConnection();
            SqlCommand com= new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "select * from SanPham";
            com.Connection = conn;
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                int ma = reader.GetInt32(0);
                string ten = reader.GetString(1);
                int gia = reader.GetInt32(2);
                int madm = reader.GetInt32(3);

                SanPham sp = new SanPham();
                sp.MaSP = ma;
                sp.TenSP = ten;
                sp.DonGia = gia;
                sp.MaDM = madm;
                dsSP.Add(sp);
            }
            reader.Close();
            return dsSP;
        }
        public bool XoaSanPham(int ma)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from SanPham where masp = @ma";
            cmd.Connection = conn;
            cmd.Parameters.Add("@ma", SqlDbType.Int).Value = ma;
            int kq = cmd.ExecuteNonQuery();
            if(kq > 0)
            {
                return true;
            }
            else { return false; }
        }
        public bool ThemSanPham(SanPham sp)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into SanPham(MaSP, TenSP, DonGia, MaDM) values (@MaSP, @TenSP, @DonGia, @MaDM)";
            cmd.Connection = conn;
            cmd.Parameters.Add("@MaSP", SqlDbType.Int).Value = sp.MaSP;
            cmd.Parameters.Add("@TenSP", SqlDbType.NVarChar).Value = sp.TenSP;
            cmd.Parameters.Add("@DonGia", SqlDbType.Int).Value = sp.DonGia;
            cmd.Parameters.Add("@MaDm", SqlDbType.Int).Value = sp.MaDM;

            int kq = cmd.ExecuteNonQuery();
            if(kq > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
