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
    public class Material
    {
        public string idNguyenLieu { get; set; }
        public string idLoaiNguyenLieu { get; set; }
        public string tenNguyenLieu { get; set; }
        public int sl { get; set; }
        public float giaTien { get; set; }
        public string donVi { get; set; }
        public bool hien { get; set; }
        public string tenLoaiNguyenLieu { get; set; }
        public Material() {

        }
        public Material(string idNguyenLieu,string idLoaiNguyenLieu, string tenNguyenLieu, int sl, float giaTien, string donVi, bool hien)
        {
            this.idLoaiNguyenLieu = idLoaiNguyenLieu;
            this.idNguyenLieu= idNguyenLieu;
            this.tenNguyenLieu= tenNguyenLieu;
            this.sl = sl;
            this.giaTien = giaTien;
            this.donVi = donVi;
            this.hien = hien;
        }
        public Material(string idLoaiNguyenLieu,string tenNguyenLieu,string donVi, float giaTien, int sl) {
            this.tenNguyenLieu = tenNguyenLieu;
            this.sl = sl;
            this.giaTien = giaTien;
            this.donVi = donVi;
            this.idLoaiNguyenLieu = idLoaiNguyenLieu;
        }
        public Material(string idNguyenLieu, string idLoaiNguyenLieu, string tenNguyenLieu, int sl, float giaTien, string donVi)
        {
            this.idLoaiNguyenLieu = idLoaiNguyenLieu;
            this.idNguyenLieu = idNguyenLieu;
            this.tenNguyenLieu = tenNguyenLieu;
            this.sl = sl;
            this.giaTien = giaTien;
            this.donVi = donVi;
            this.hien = hien;   
        }
    }
}
