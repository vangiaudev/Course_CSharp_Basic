using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lstDanhSachA_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien();
            sv.Ten = txtNhapTen.Text;
            //đưa vào ListBox
            lstDanhSachA.Items.Add(sv);

            if(txtNhapTen.Text == "")
            {
                MessageBox.Show("Bạn vui lòng nhập vào Tên Sinh Viên");
            }
        }

        private void btnRight1_Click(object sender, EventArgs e)
        {
           
           if(lstDanhSachA.SelectedIndex != -1)
            {
                while(lstDanhSachA.SelectedIndices.Count > 0)
                {
                    SinhVien sv = lstDanhSachA.SelectedItem as SinhVien;
                    lstDanhSachB.Items.Add(sv);
                    lstDanhSachA.Items.Remove(sv);
                }
                
            }

        }

        private void btnLeft1_Click(object sender, EventArgs e)
        {
            if(lstDanhSachB.SelectedIndex != -1) //có chọn
            {
                
                while(lstDanhSachB.SelectedIndices.Count > 0)
                {
                    SinhVien sv = lstDanhSachB.SelectedItem as SinhVien;
                    lstDanhSachA.Items.Add(sv);
                    lstDanhSachB.Items.Remove(sv);
                }
            }
        }
        
        private void btnRight2_Click(object sender, EventArgs e)
        {
            lstDanhSachA.SelectedIndex = -1; //hủy chọn tất cả
            for(int i = 0; i<lstDanhSachA.Items.Count; i++)
            {
                lstDanhSachB.Items.Add(lstDanhSachA.Items[i]);
            }
            lstDanhSachA.Items.Clear();
        }

        private void btnLeft2_Click(object sender, EventArgs e)
        {
            lstDanhSachB.SelectedIndex = -1;
            for(int i = 0; i<lstDanhSachB.Items.Count; i++)
            {
                lstDanhSachA.Items.Add(lstDanhSachB.Items[i]);
            }
            //for(int i = 0; i<lstDanhSachB.Items.Count; i++)
            //{
            //    lstDanhSachB.Items.Remove(lstDanhSachB.Items[i]);
            //    i--;
            //}
            lstDanhSachB.Items.Clear();
        }

        private void btnXoaLopA_Click(object sender, EventArgs e)
        {

        }
    }
}
