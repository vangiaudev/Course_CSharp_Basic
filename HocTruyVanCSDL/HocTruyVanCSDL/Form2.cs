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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        string strConn = "server=DESKTOP-0GQGB3U; Database=CSDLTest; Integrated Security = True";

        private void Form2_Load(object sender, EventArgs e)
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
            command.CommandText = "select * from LopHoc";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string line = reader.GetInt32(0) + "-" + reader.GetString(1);
                listBox1.Items.Add(line);

            }
            reader.Close();
            //Display();
        }
        private void Display()
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
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedItems.Count > 0)
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
                command.CommandText = "select * from SinhVien where Ma = @ma";
                command.Connection = conn;

                SqlParameter paraMaLop = new SqlParameter("@ma", SqlDbType.Int);
                paraMaLop.Value = 1;
                command.Parameters.Add(paraMaLop);

                lvSinhVien.Items.Clear();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int ma = reader.GetInt32(0);
                    string ten = reader.GetString(1);
                    string ns = reader.GetDateTime(2) + "";

                    ListViewItem lvi = new ListViewItem(ma + "");
                    lvi.SubItems.Add(ten);
                    lvi.SubItems.Add(ns);

                    lvSinhVien.Items.Add(lvi);
                }
                reader.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
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
            string sql = "insert into SinhVien(Ma, Ten)"+
                "value("+txtMa.Text + ", N'" + txtTen.Text + ")";
            command.CommandText = sql;
            command.Connection = conn;

            int ret = command.ExecuteNonQuery();
            if(ret > 0)
            {
                Display();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }

        }
    }
}
