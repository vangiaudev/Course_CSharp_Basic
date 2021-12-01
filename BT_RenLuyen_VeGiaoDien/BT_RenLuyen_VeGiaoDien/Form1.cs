using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_RenLuyen_VeGiaoDien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Button lasted = null;
        private void btnThem_Click(object sender, EventArgs e)
        {
            Button btn = new Button(); //khoi tao button
            Random rd = new Random();
            btn.Text = rd.Next(102) + ""; //gán số ngẫu nhiên cho button
            btn.Width = 80; //ch.rong
            btn.Height = 30; //ch.cao
            btn.BackColor = Color.Yellow;
            pnButton.Controls.Add(btn);
            btn.Click += Btn_Click;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            if(lasted != null) //trước đó đã nhấn rồi
            {
                lasted.BackColor = Color.Yellow;
            }
            Button btn = sender as Button;
            btn.BackColor = Color.Red;
            lasted = btn;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(lasted != null)
            {
                pnButton.Controls.Remove(lasted);
            }
        }
    }
}
