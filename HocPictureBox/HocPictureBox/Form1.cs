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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureOff_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if(pictureOn.Visible == false)
            {
                btnTurnOnOrOff.Text = txtName.Text + ":" + "Turn on the light, Please!";
            }
            else
            {
                btnTurnOnOrOff.Text = txtName.Text + ":" + "Turn off the light, Please!";
            }
            
        }

        private void btnTurnOnOrOff_Click(object sender, EventArgs e)
        {
            if(pictureOn.Visible == false)
            {
                pictureOn.Visible = true;
                pictureOff.Visible = false;
                //btnTurnOnOrOff.Text = txtName.Text + ":" + "Turn off the light, Please!";
                btnTurnOnOrOff.Text = btnTurnOnOrOff.Text.Replace("on", "off"); //giống câu trên
            }
            else
            {
                pictureOn.Visible = false;
                pictureOff.Visible = true;
                btnTurnOnOrOff.Text = txtName.Text + ":" + "Turn on the light, Please!";
            }
        }
    }
}
