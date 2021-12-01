using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectChuongTrinhQuanLySanPham
{
    public partial class frmDanhMuc : Form
    {
        public static bool CoThayDoi = false;
        public frmDanhMuc()
        {
            InitializeComponent();
        }

        private void btnLuuDM_Click(object sender, EventArgs e)
        {
            CoThayDoi = true;
            DanhMuc dm = new DanhMuc();
            dm.MaDM = txtMaDanhMuc.Text;
            dm.TenDM = txtTenDanhMuc.Text;
            frmSanPham.dsDanhMuc.Add(dm);
            HienThiDanhMucLenListBox();
            txtMaDanhMuc.Text = "";
            txtTenDanhMuc.Text = "";

            txtMaDanhMuc.Focus(); //đưa con trỏ trở lại ví trí nhập mã

        }
        void HienThiDanhMucLenListBox()
        {
            lstDanhMuc.Items.Clear();
            foreach (DanhMuc i in frmSanPham.dsDanhMuc)
            {
                lstDanhMuc.Items.Add(i);
            }
        }

        private void lstDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstDanhMuc.SelectedIndex != -1) //có chọn
            {
                DanhMuc dm = lstDanhMuc.SelectedItem as DanhMuc;
                txtMaDanhMuc.Text = dm.MaDM;
                txtTenDanhMuc.Text = dm.TenDM;
            }
        }

        private void btnXoaDM_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có chắc chắn muốn xóa danh mục này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
                if(ret == DialogResult.No)
            {
                return;
            }
                if (lstDanhMuc.SelectedIndex != -1)
                {
                    DanhMuc dm = lstDanhMuc.SelectedItem as DanhMuc;
                    lstDanhMuc.Items.Remove(dm);
                CoThayDoi = true;
                }
        }

        private void btnDongDM_Click(object sender, EventArgs e)
        {
            if(CoThayDoi == true)
            {
                DialogResult =  DialogResult.OK;
            }
            else
            {
                DialogResult = DialogResult.Cancel;
            }
        }

        private void frmDanhMuc_Load(object sender, EventArgs e)
        {
            HienThiDanhMucLenListBox();
        }
    }
}
