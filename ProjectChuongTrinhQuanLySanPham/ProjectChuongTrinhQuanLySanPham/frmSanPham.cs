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
    public partial class frmSanPham : Form
    {
        public static List<DanhMuc> dsDanhMuc = new List<DanhMuc>();
        List<SanPham> DanhSachSP = new List<SanPham>();
        public frmSanPham()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            frmDanhMuc frmDM = new frmDanhMuc();
            frmDanhMuc.CoThayDoi = false;
            if(frmDM.ShowDialog() == DialogResult.OK)
            {
                HienThiDanhMucLenComboBox();
            }
        }
        private void HienThiDanhMucLenComboBox()
        {
            cboDanhMuc.Items.Clear();
            foreach (DanhMuc i in dsDanhMuc)
            {
                cboDanhMuc.Items.Add(i);
            }

        }
        private void frmSanPham_Load(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(cboDanhMuc.SelectedIndex == -1)
            {
                MessageBox.Show("Thím ơi, chưa có chọn danh mục");
            }
            else
            {
                DanhMuc dm = cboDanhMuc.SelectedItem as DanhMuc;
                SanPham sp = new SanPham();
                sp.MaSp = txtMaSP.Text;
                sp.TenSP = txtTenSP.Text;
                
                try
                {
                    sp.DonGia = float.Parse(txtDonGia.Text);
                }
                catch (Exception ex)
                {

                    DialogResult ret = MessageBox.Show("Đơn giá nhập sai rồi");
                    return;
                }
                
                sp.XuatXu = txtXuatXu.Text;
                sp.HanDung = dtpHanDung.Value;

                dm.ThemSP(sp);
                DanhSachSP.Add(sp);
                HienThiSanPhamLenGiaoDien();
                XoaTrangChiTietSP();
            }
           
        }
        void HienThiSanPhamLenGiaoDien()
        {
            lstSanPham.Items.Clear();
            foreach (SanPham item in DanhSachSP)
            {
                lstSanPham.Items.Add(item);
            }
        }
        void XoaTrangChiTietSP()
        {
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtDonGia.Text = "";
            txtXuatXu.Text = "";
            txtMaSP.Focus();
        }
        private void lstSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstSanPham.SelectedIndex != -1)
            {
                SanPham sp = lstSanPham.SelectedItem as SanPham;
                cboDanhMuc.Text = sp.TenSP;
                txtMaSP.Text = sp.MaSp;
                txtTenSP.Text = sp.TenSP;
                txtDonGia.Text = sp.DonGia + "";
                txtXuatXu.Text = sp.XuatXu;
                dtpHanDung.Text = sp.HanDung + "";
                
            }
            else { return; }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(lstSanPham.SelectedIndex != -1)
            {
                SanPham sp = lstSanPham.SelectedItem as SanPham;
                DialogResult ret = MessageBox.Show("Muốn xóa " + sp.TenSP + " hả thím", "Hỏi xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(ret == DialogResult.Yes)
                {
                    DanhSachSP.Remove(sp);
                    HienThiSanPhamLenGiaoDien();
                    XoaTrangChiTietSP();
                }

            }
            else
            {
                MessageBox.Show("Thím chưa chọn SP mà xóa gì");
            }
        }
    }
}
