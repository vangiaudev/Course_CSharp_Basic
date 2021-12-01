using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CacControlCoBan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnHo_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = txtHo.Text;
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTen_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = txtTen.Text;
        }

        private void btnHoTen_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = txtHo.Text + " " + txtTen.Text;
        }

        private void btnThoatChuongTrinh_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Muốn thoát phần mềm hả thím ?", "Hỏi thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if(ret == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
