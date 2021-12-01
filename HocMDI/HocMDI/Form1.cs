using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocMDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bàiTập1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBai1 frm1 = new frmBai1();
            frm1.MdiParent = this;
            frm1.Show();

        }

        private void bàiTập2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBai2 frm2 = new frmBai2();
            frm2.MdiParent = this;
            frm2.Show();
        }

        private void bàiTập3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBai3 frm3 = new frmBai3();
            frm3.MdiParent = this;
            frm3.Show();
        }

        private void arrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }
    }
}
