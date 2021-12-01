using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBoxVaRadioButton
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            radRed.Checked = true;
        }

        private void txtNhapTen_TextChanged(object sender, EventArgs e)
        {
            lblEmpty.Text = txtNhapTen.Text;
        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            if(radRed.Checked == true)
            {
                lblEmpty.ForeColor = Color.Red; 
            }
            
        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (radGreen.Checked == true)
            {
                lblEmpty.ForeColor = Color.Green;
            }
           
        }

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlue.Checked == true)
            {
                lblEmpty.ForeColor = Color.Blue;
            }
        }

        private void radBlack_CheckedChanged(object sender, EventArgs e)
        {
            if(radBlack.Checked == true)
            {
                lblEmpty.ForeColor = Color.Black;
            }
        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            if(chkBold.Checked == true)
            {
                lblEmpty.Font = new Font(
                    lblEmpty.Font.Name, //lấy tên font chữ có sẵn
                    lblEmpty.Font.Size, //lấy kích thước phông chữ có sẵn
                    lblEmpty.Font.Style ^ FontStyle.Bold); //nối lại
            }
           
        }

        private void chkItalic_CheckedChanged(object sender, EventArgs e)
        {
            if(chkItalic.Checked == true)
            {
                lblEmpty.Font = new Font(lblEmpty.Font.Name,
                    lblEmpty.Font.Size,
                    lblEmpty.Font.Style ^ FontStyle.Italic);
            }
        }

        private void chkUnderline_CheckedChanged(object sender, EventArgs e)
        {
            if(chkUnderline.Checked == true)
            {
                lblEmpty.Font = new Font(
                    lblEmpty.Font.Name,
                    lblEmpty.Font.Size,
                    lblEmpty.Font.Style ^ FontStyle.Underline);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Muốn thoát hả thím ?",
                "Hỏi thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if(ret == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
