﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaHinhCS
{
    public class SinhVien : ILamViec
    {
        public string MaSV { get; set; }
        public string TenSV { get; set; }
        public string LamViec(string mota)
        {
            string s = "Sinh vien dang " +  mota ;
            return s;
        }
    }
}
