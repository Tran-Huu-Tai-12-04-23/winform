using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FinalProject_QUANLYKHO.Models
{
    public class Bake
    {
        public string idBanh { get; set; }
        public string idLoaiBanh { get; set; }
        public string tenBanh { get; set; }
        public int sl { get; set; }
        public float giaTien { get; set; }
        public string donVi { get; set; }
        public bool hien { get; set; }

        public Bake()
        {

        }

        public Bake(string idBanh, string idLoaiBanh, string tenBanh, int sl, float giaTien, string donVi, bool hien)
        {
            this.idLoaiBanh = idLoaiBanh;
            this.idBanh = idBanh;
            this.tenBanh = tenBanh;
            this.sl = sl;
            this.giaTien = giaTien;
            this.donVi = donVi;
            this.hien = hien;
        }

        public Bake(string idLoaiBanh, string tenBanh, string donVi, float giaTien, int sl)
        {
            this.tenBanh = tenBanh;
            this.sl = sl;
            this.giaTien = giaTien;
            this.donVi = donVi;
            this.idLoaiBanh = idLoaiBanh;
        }

        public Bake(string idBanh, string idLoaiBanh, string tenBanh, int sl, float giaTien, string donVi)
        {
            this.idLoaiBanh = idLoaiBanh;
            this.idBanh = idBanh;
            this.tenBanh = tenBanh;
            this.sl = sl;
            this.giaTien = giaTien;
            this.donVi = donVi;
            this.hien = hien;
        }
    }
}
