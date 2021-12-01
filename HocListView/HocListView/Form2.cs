using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocListView
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        List<DanhMuc> khohang = new List<DanhMuc>();
        private void Form2_Load(object sender, EventArgs e)
        {
            DanhMuc bia = new DanhMuc();
            bia.Ma = "dm1";
            bia.Ten = "Nhóm bia";
            khohang.Add(bia);
            SanPham biaken = new SanPham();
            biaken.Ma = "sp1";
            biaken.Ten = "Heineiken";
            biaken.Gia = 200000;
            bia.ThemSP(biaken);
            SanPham bia333 = new SanPham();
            bia333.Ma = "sp2";
            bia333.Ten = "Bia 333";
            bia333.Gia = 300000;
            bia.ThemSP(bia333);
            DanhMuc ruou = new DanhMuc();
            ruou.Ma = "dm2";
            ruou.Ten = "Nhóm rượu";
            khohang.Add(ruou);
            SanPham vodka = new SanPham();
            vodka.Ma = "sp3";
            vodka.Ten = "Rượu Vodka";
            vodka.Gia = 600000;
            ruou.ThemSP(vodka);
            foreach(DanhMuc dm in khohang)
            {
                //tạo nhóm cho list View
                ListViewGroup lvg = new ListViewGroup(dm.Ten);
                
                listView1.Groups.Add(lvg);
                foreach (SanPham i in dm.sp)
                {
                    ListViewItem lvi = new ListViewItem(i.Ma);
                    lvi.SubItems.Add(i.Ten);
                    lvi.SubItems.Add(i.Gia + "");
                    lvi.Group = lvg;
                    listView1.Items.Add(lvi);
                    if(dm == ruou)
                    {
                        lvi.ForeColor = Color.Red;
                    }
                }
            }


        }
    }
}
