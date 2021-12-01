using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTO;
using BLL;

namespace GUI_Web
{
    public partial class XemDanhSachSanPham : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SanPhamBLL spbll = new SanPhamBLL();
            GridView1.DataSource = spbll.LayToanBoSanPham();
            GridView1.DataBind();
        }
    }
}