using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocKetNoiLinQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (GiauDepTraiDataContext db = new GiauDepTraiDataContext())
            {
                int maSP = int.Parse(dgvData.SelectedCells[0].OwningRow.Cells["MaSP"].Value.ToString());
                string tenSP = dgvData.SelectedCells[0].OwningRow.Cells["TenSP"].Value.ToString();
                int DonGia = int.Parse(dgvData.SelectedCells[0].OwningRow.Cells["DonGia"].Value.ToString());
                int maDM = int.Parse(dgvData.SelectedCells[0].OwningRow.Cells["MaDM"].Value.ToString());

                SanPham add = db.SanPhams.Where(p => p.MaSP.Equals(maSP)).SingleOrDefault();
                add.TenSP = tenSP;
                add.DonGia = DonGia;
                add.MaDM = maDM;

                db.SanPhams.InsertOnSubmit(add);
                btnXem.PerformClick();
                MessageBox.Show("Thêm Thành Công");

            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            using (GiauDepTraiDataContext db = new GiauDepTraiDataContext())
            {
                dgvData.DataSource = db.SanPhams.Select(d => d);
                //dgvData.DataSource = from u in db.SanPhams
                //                     select new
                //                     {
                //                         Tên = u.TenSP,
                //                         Mã = u.MaSP
                //                     };
            }
            //dgvData.DataSource = db.SanPhams.Where(p => p.TenSP.CompareTo("3") == 1);
            //dgvData.DataSource = db.SanPhams.Where(p => p.DonGia > 100).OrderBy(p => p.TenSP); //cau dkien in ra sp co don gia > 120, OrderBy là dùng để sắp xếp theo tên sp
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            using (GiauDepTraiDataContext db = new GiauDepTraiDataContext())
            {
                int maSP = int.Parse(dgvData.SelectedCells[0].OwningRow.Cells["MaSP"].Value.ToString());
                SanPham delete = db.SanPhams.Where(p => p.MaSP.Equals(maSP)).SingleOrDefault();
                db.SanPhams.DeleteOnSubmit(delete);
                db.SubmitChanges();
                btnXem.PerformClick();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                using (GiauDepTraiDataContext db = new GiauDepTraiDataContext())
                {
                    dgvData.DataSource = db.SanPhams.Where(p => p.MaSP.Equals(txtMaSP.Text));
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Lỗi Kết Nối");
            }
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            using (GiauDepTraiDataContext db = new GiauDepTraiDataContext())
            {
                int maSP = int.Parse(dgvData.SelectedCells[0].OwningRow.Cells["MaSP"].Value.ToString());
                string tenSP = dgvData.SelectedCells[0].OwningRow.Cells["TenSP"].Value.ToString();
                int DonGia = int.Parse(dgvData.SelectedCells[0].OwningRow.Cells["DonGia"].Value.ToString());

                SanPham edit = db.SanPhams.Where(p => p.MaSP.Equals(maSP)).SingleOrDefault();
                edit.TenSP = tenSP;
                edit.DonGia = DonGia;

                db.SubmitChanges();
                btnXem.PerformClick();
                MessageBox.Show("Sửa Thành Công");

            }
        }
    }
}
