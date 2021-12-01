using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocDateTimeVaMonthCalendar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtTen, "");
            errorProvider1.SetError(txtTuoi, "");
            errorProvider1.SetError(dtpNgayDangKy, "");
            if(txtTen.Text == "")
            {
                errorProvider1.SetError(txtTen, "Nhà ngươi chưa nhập tên mà lị");
            }
            int tuoi = 0;
            if(int.TryParse(txtTuoi.Text, out tuoi) == false)
            {
                errorProvider1.SetError(txtTuoi, "Tuổi nhập lụi rồi!");
            }
            else
            {
                if(tuoi < 18)
                {
                    errorProvider1.SetError(txtTuoi, "Tuổi phải lớn hơn 17 mà thím");
                }
            }
            if(dtpNgayDangKy.Value.DayOfWeek == DayOfWeek.Sunday)
            {
                errorProvider1.SetError(dtpNgayDangKy, "Chủ nhật đi nhậu không có thi");
            }
            if(txtTen.Text != "" && int.TryParse(txtTuoi.Text, out tuoi) == true && tuoi >= 18 && dtpNgayDangKy.Value.DayOfWeek != DayOfWeek.Sunday)
            {
                DialogResult ret = MessageBox.Show("Đăng kí thành công !", "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                DialogResult ret = MessageBox.Show("Đăng kí không thành công !", "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            
        }

        private void txtTuoi_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpNgayDangKy_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
