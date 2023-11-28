using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_QUANLYKHO.Models
{
    internal class MaterialType
    {
        public string idLoaiNguyenLieu { get; set; }
        public string tenLoaiNguyenLieu { get; set; }
        public MaterialType() { }
        public MaterialType(string idLoaiNguyenLieu, string tnLoaiNguyenLieu)
        {
            this.idLoaiNguyenLieu = idLoaiNguyenLieu;
            this.tenLoaiNguyenLieu = tenLoaiNguyenLieu;
        }

    }
}
