using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HocComboBox
{
    public class HinhThucThanhToan
    {
        public int Ma { get; set; }
        public string HinhThuc { get; set; }
        public int PhiThanhToan { get; set; }
        public override string ToString()
        {
            return this.Ma + "-" + this.HinhThuc + " (" + this.PhiThanhToan + ")";
        }
    }
}
