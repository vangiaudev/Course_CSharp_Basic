using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //thư viện để kết nối vs SQL Server

namespace HocKetNoiCSDL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        string strConn = "Data Source=DESKTOP-0GQGB3U; Database=CSDL_QLDanhBa; Integrated Security = True"; // có 5 cách kết nối

        private void btnKetNoi_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(strConn);
                conn.Open();
                MessageBox.Show("Kết nối CSDL Thành công");
            }
            catch (Exception exx)
            {

                MessageBox.Show(exx.Message);
            }
        }

        private void btnDongKetNoi_Click(object sender, EventArgs e)
        {
            if(conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
                MessageBox.Show("Đã đóng kết nối CSDL thành công");
            }
        }
    }
}
