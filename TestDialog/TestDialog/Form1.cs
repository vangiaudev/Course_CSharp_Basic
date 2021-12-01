using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TestDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            fontdialog1.showcolor = true; // hien thi chuc năng chon mau
            fontdialog1.color = label1.forecolor;
            fontdialog1.font = label1.font;
            if (fontdialog1.showdialog() == dialogresult.ok)
            {
                label1.font = fontdialog1.font;
                label1.forecolor = fontdialog1.color;
            }


        }
    }
}
