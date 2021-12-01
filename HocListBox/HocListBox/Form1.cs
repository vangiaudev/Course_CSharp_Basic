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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //trước khi chọn số chẵn thì ta phải bỏ chọn toàn bộ các số cũ
            lstSo.SelectedIndex = -1; //tự bỏ chọn toàn bộ các dòng đang chọn trên ListBox
            for(int i = 0; i<lstSo.Items.Count; i++)
            {
                if((int)lstSo.Items[i] % 2 == 0)
                {
                    lstSo.SelectedIndex = i;
                }
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtNhapSo.Text);
            lstSo.Items.Add(x); //thêm số vừa hàm vào ListBox
        }

        private void btnXoaDauVaCuoi_Click(object sender, EventArgs e)
        {
            //ptu đầu ở vị trí 0, ptu cuối ở vị trí n-1
            lstSo.Items.RemoveAt(0);
            lstSo.Items.RemoveAt(lstSo.Items.Count - 1);
        }

        private void btnTongDanhSach_Click(object sender, EventArgs e)
        {
            int sum = 0;
            foreach (int i in lstSo.Items)
            {
                sum += i;
            }
            MessageBox.Show("Tổng các phần tử của danh sách là " + sum);
        }

        private void btnXoaPhanTuDangChon_Click(object sender, EventArgs e)
        {
            //ta phải luôn kiểm tra Người dùng có đang chọn dòng nào hay không
            //nếu listbox chưa chọn gì thì SelectedIndex == -1, có chọn thì != -1;
            //if(lstSo.SelectedIndex != -1)
            //{
            //    lstSo.Items.RemoveAt(lstSo.SelectedIndex); //SelectedIndex là vị trí đang chọn
            //}
            while(lstSo.SelectedIndices.Count > 0) //SelectedIndices trả về các vị trí đang chọn
            {
                lstSo.Items.RemoveAt(lstSo.SelectedIndices[0]); //xóa phần tử thứ 0 trong ds được chọn
            }
        }

        private void btnTangLen2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstSo.Items.Count; i++)
            {
                int x = (int)lstSo.Items[i]; //phải ép kiểu về int
                lstSo.Items[i] = x + 2;
            }
        }

        private void btnThayBangBinhPhuong_Click(object sender, EventArgs e)
        {
            for(int i = 0; i<lstSo.Items.Count; i++)
            {
                int value = (int)lstSo.Items[i];
                lstSo.Items[i] = Math.Pow(value, 2);
            }
        }

        private void btnChonSoLe_Click(object sender, EventArgs e)
        {
            lstSo.SelectedIndex = -1;
            for (int i = 0; i<lstSo.Items.Count; i++)
            {
                if((int)lstSo.Items[i] % 2 != 0)
                {
                    lstSo.SelectedIndex = i;
                }
            }
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát không?",
                "Hỏi Thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if(ret == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
