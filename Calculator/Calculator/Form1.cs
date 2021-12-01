using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        bool IsTypingNumber = false;
        bool isFloatingPoint = false;
        enum PhepToan
        {
            None, Cong, Tru, Nhan, Chia, PhanTram,
            Can, Sin, Cos, Tan, Pow
        };
        PhepToan pheptoan = PhepToan.None;
        double nho = 0.0;

        private void NhapSo(object sender, EventArgs e)
        {
            Button btn = (Button)(sender);
            NhapSo(btn.Text);
        }
        private void NhapSo(string so)
        {
            if (IsTypingNumber)
                lblHienThi.Text = lblHienThi.Text + so;
            else
            {
                lblHienThi.Text = so;
                IsTypingNumber = true;
            }
        }
        private void NhapPhepToan(object sender, EventArgs e)
        {
            if(nho != 0)
            {
                TinhKetQua();
            }
            Button btn = (Button)sender;
            switch (btn.Text)
            {
                case "+": pheptoan = PhepToan.Cong; break;
                case "-": pheptoan = PhepToan.Tru; break;
                case "*": pheptoan = PhepToan.Nhan; break;
                case "/": pheptoan = PhepToan.Chia; break;
                case "%": pheptoan = PhepToan.PhanTram; break;
                case "√": pheptoan = PhepToan.Can; break;
                case "Sin": pheptoan = PhepToan.Sin; break;
                case "Cos": pheptoan = PhepToan.Cos; break;
                case "Tan": pheptoan = PhepToan.Tan; break;
                case "^": pheptoan = PhepToan.Pow; break;
            }
            nho = double.Parse(lblHienThi.Text);
            isFloatingPoint = false;
            IsTypingNumber = false;
        }
        private void TinhKetQua()
        {
            // tinh toan dua tren: bien nho, pheptoan, lblHienThi.Text
            double tmp = double.Parse(LaySoTuDisplayText());
            double ketqua = 0.0;
            switch (pheptoan)
            {
                case PhepToan.Cong: ketqua = nho + tmp; break;
                case PhepToan.Tru: ketqua = nho - tmp; break;
                case PhepToan.Nhan: ketqua = nho * tmp; break;
                case PhepToan.Chia: ketqua = nho / tmp; break;
                case PhepToan.PhanTram:ketqua = tmp / 100;break;
                case PhepToan.Can: ketqua = Math.Sqrt(tmp); break;
                case PhepToan.Sin: ketqua = Math.Sin(tmp); break;
                case PhepToan.Cos: ketqua = Math.Cos(tmp); break;
                case PhepToan.Tan: ketqua = Math.Tan(tmp); break;
                case PhepToan.Pow: ketqua = Math.Pow(nho, tmp); break;
            }
                    

            // gan ket qua tinh duoc len lblHienThi
            double phanNguyen = System.Math.Truncate(ketqua);
            double phanThapPhan = ketqua - phanNguyen;
            
            lblHienThi.Text = ketqua.ToString();
            //ThemDauCham();
        }
       
        private void ThemDauCham()
        {
            if (!isFloatingPoint || !lblHienThi.Text.Contains(","))
                lblHienThi.Text = lblHienThi.Text + ",";
        }
        private void btnKetQua_Click(object sender, EventArgs e)
        {
            TinhKetQua();
            IsTypingNumber = false;
            Clear();
        }
        private string LaySoTuDisplayText()
        {
            string text = lblHienThi.Text;
            int lastIndex = text.Length - 1;

            if (text[lastIndex] == ',')
                text = text.Remove(lastIndex);

            return text;
        }
        private void Clear()
        {
            nho = 0;
            pheptoan = PhepToan.None;
        }

        private void frmMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    NhapSo("" + e.KeyChar);
                    break;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string txt = lblHienThi.Text;
            if(txt.Length == 1)
            {
                lblHienThi.Text = "0";
            }
            else
            {
                lblHienThi.Text = txt.Remove(txt.Length - 1);
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            lblHienThi.Text = "0";
            nho = 0.0;
            isFloatingPoint = false;
            IsTypingNumber = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)(sender);
            lblHienThi.Text = lblHienThi.Text + btn.Text;
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SinhVienThucHien svth = new SinhVienThucHien();
            svth.Show();
        }

        private void càiĐặtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Muốn thoát chương trình hả thím ?",
                "Hỏi thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if(ret == DialogResult.Yes)
            {
                Close();
            }
        }

        private void càiĐặtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ColorDialog cdl = new ColorDialog();
            if(cdl.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = cdl.Color;
            }
        }
    }
}
