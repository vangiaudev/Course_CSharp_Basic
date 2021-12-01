using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocDataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<NhanVien> dsNhanVien = new List<NhanVien>();
            dsNhanVien.Add(new NhanVien { Ma = 1, Ten = "Trần Văn Obama", Phone = "0343232323" });
            dsNhanVien.Add(new NhanVien { Ma = 2, Ten = "Nguyễn Văn Lé", Phone = "0128392482" });
            dsNhanVien.Add(new NhanVien { Ma = 3, Ten = "Hồ Văn Bèo", Phone = "0938293231" });

            gvNhanVien.DataSource = dsNhanVien;
        }

        private void gvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex == -1) return; //e la dong dang dc chon, neu !=-1 tra ve cai dong dang dc chon
            
            //DataGridViewRow row = gvNhanVien.Rows[e.RowIndex];
            //string ten = row.Cells[1].Value + "";
            //MessageBox.Show(ten);
        }

        private void gvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return; //e la dong dang dc chon, neu !=-1 tra ve cai dong dang dc chon

            DataGridViewRow row = gvNhanVien.Rows[e.RowIndex];
            string ten = row.Cells[1].Value + "";
            MessageBox.Show(ten);
        }
    }
}
