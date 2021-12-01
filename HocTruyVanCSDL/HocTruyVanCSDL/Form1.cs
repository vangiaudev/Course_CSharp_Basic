using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HocTruyVanCSDL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        string strConn = "Data Source=DESKTOP-0GQGB3U; Database=CSDLTest; Integrated Security = True";
        private void btnDemSoSanPham_Click(object sender, EventArgs e)
        {
            if(conn == null)
            {
                conn = new SqlConnection(strConn);
            }
            if(conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select count(*) from SinhVien";
            command.Connection = conn;

            object data = command.ExecuteScalar();
            int n = (int)data;
            lblSoSanPham.Text = "Có " + n + " Sinh viên";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
               
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (conn == null)
            {
                conn = new SqlConnection(strConn);
            }
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from SinhVien where Ma =" + txtMaMuonTim.Text;
            command.Connection = conn;

            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read()) //có dữ liệu
            {
                txtMa.Text = reader.GetInt32(0) + "";
                txtTen.Text = reader.GetString(1);
                txtNgaySinh.Text = reader.GetDateTime(2) + "";

            }
        }

        private void btnCach2_Click(object sender, EventArgs e)
        {
            if(conn == null)
            {
                conn = new SqlConnection(strConn);
            }
            if(conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select* from SinhVien where Ma=@ma";
            command.Connection = conn;

            SqlParameter paraMa = new SqlParameter("@ma", SqlDbType.Int); //SqlDbType chấm tới kiếu dữ liệu mà ta khai báo trong cột Ma của CSDL
            paraMa.Value = txtMaMuonTim.Text;
            command.Parameters.Add(paraMa);

            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                txtMa.Text = reader.GetInt32(0)+"";
                txtTen.Text = reader.GetString(1);
                txtNgaySinh.Text = reader.GetDateTime(2) + "";
            }
            reader.Close();

        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (conn == null)
            {
                conn = new SqlConnection(strConn);
            }
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from SinhVien";
            command.Connection = conn;

            SqlDataReader reader = command.ExecuteReader();
            lvSinhVien.Items.Clear();
            while (reader.Read())
            {
                ListViewItem lvi = new ListViewItem(reader.GetInt32(0) + "");
             
                lvi.SubItems.Add(reader.GetString(1));
                lvi.SubItems.Add(reader.GetDateTime(2) + "");

                lvSinhVien.Items.Add(lvi);
            }
            reader.Close();
        }
    }
}
