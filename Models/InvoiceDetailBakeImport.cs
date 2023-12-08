using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_QUANLYKHO.Models
{
    public class InvoiceDetailBakeImport
    {
        public string idBanh
        {
            get; set;
        }
        public string idHoaDon
        {
            get; set;
        }
        public string idKhachHang
        {
            get;set;
        }
        public int sl
        {
            get; set;
        }
        public double tongTien
        {
            get; set;
        }
        public InvoiceDetailBakeImport(  string idBanh,string idKhachHang, string idHoaDon, int sl, double tongTien)
        {
            this.idBanh = idBanh;
            this.idHoaDon = idHoaDon;
            this.sl = sl;
            this.tongTien = tongTien;
            this.idKhachHang = idKhachHang;
        }

        public InvoiceDetailBakeImport() { }

    }
}
