using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocComboBox
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

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            string detail1, detail2, detail3, detail4, detail5;
            detail1 = "Thông tin khách hàng: \n";
            detail2 = "Họ tên: " + txtTen.Text + "\n";
            detail3 = "Số Phone: " + txtPhone.Text + "\n";
            detail4 = "Sản phẩm đặt: " + lstDanhSachSanPham.SelectedItem + "\n";
            detail5 = "Phương thức thanh toán: " + cboPhuongThucThanhToan.SelectedItem + "\n";
            lstThongTinDonHang.Items.Add(detail1);
            lstThongTinDonHang.Items.Add(detail2);
            lstThongTinDonHang.Items.Add(detail3);
            lstThongTinDonHang.Items.Add(detail4);
            lstThongTinDonHang.Items.Add(detail5);
        }

        private void cboPhuongThucThanhToan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboPhuongThucThanhToan.SelectedIndex != -1)
            {
                MessageBox.Show("Bạn chọn phương thức thanh toán " + cboPhuongThucThanhToan.SelectedItem);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HinhThucThanhToan atm = new HinhThucThanhToan();
            atm.Ma = 1;
            atm.HinhThuc = "Chuyển khoảng ATM";
            atm.PhiThanhToan = 0;
            comboBox1.Items.Add(atm);

            HinhThucThanhToan tructiep = new HinhThucThanhToan();
            tructiep.Ma = 2;
            tructiep.HinhThuc = "Thanh toán tại cửa hàng";
            tructiep.PhiThanhToan = 0;
            comboBox1.Items.Add(tructiep);

            HinhThucThanhToan giantiep = new HinhThucThanhToan();
            giantiep.Ma = 3;
            giantiep.HinhThuc = "Trả tiền sau khi nhận hàng";
            giantiep.PhiThanhToan = 10;
            comboBox1.Items.Add(giantiep);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex != -1)
            {
                HinhThucThanhToan ht = comboBox1.SelectedItem as HinhThucThanhToan;
                MessageBox.Show(ht.Ma + "-" + ht.HinhThuc + "=>" + ht.PhiThanhToan);
            }
        }
    }
}
