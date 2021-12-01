using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocPictureBox
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtID.Text == "admin" && txtPassword.Text == "anhyeuem1")
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                DialogResult ret = MessageBox.Show("Sai tên tài khoản hoặc mật khẩu !", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát ?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if(ret == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
