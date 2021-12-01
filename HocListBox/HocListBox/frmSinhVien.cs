using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocListBox
{
    public partial class frmSinhVien : Form
    {
        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien();
            sv.Ma = int.Parse(txtMa.Text);
            sv.Ten = txtTen.Text;

            //đưa vào ListBox
            lstSinhVien.Items.Add(sv);
        }

        private void lstSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstSinhVien.SelectedIndex != -1) //có chọn
            {
                SinhVien sv = lstSinhVien.SelectedItem as SinhVien;
                txtMa.Text = sv.Ma.ToString();
                txtTen.Text = sv.Ten.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstSinhVien.SelectedIndex != -1) //có chọn
            {
                SinhVien sv = lstSinhVien.SelectedItem as SinhVien;
                lstSinhVien.Items.Remove(sv);
                txtMa.Text = "";
                txtTen.Text = "";
                
            }
        }
    }
}
