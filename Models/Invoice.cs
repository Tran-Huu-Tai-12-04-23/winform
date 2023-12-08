using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_QUANLYKHO.Models
{
    public class Invoice
    {
        public string idHoaDon
        {
            get; set;
        }
        public string tenBoPhanXuat
        {
            get; set;
        }

        public string idBoPhanXuat
        {
            get; set;
        }
        public string idLoaiHoaDon
        {
            get; set;
        }

        public string idTaiKhoan
        {
            get; set;
        }

        public DateTime ngayXuat
        {
            get; set;
        }

        public double tongTien
        {
            get; set;
        }

        public int soLuong
        {
            get; set;
        }
        public Invoice()
        {

        }
        public Invoice(string idHoaDon, string tenBoPhanXuat, string idBoPhanXuat, string idLoaiHoaDon, string idTaiKhoan, DateTime ngayXuat, double tongTien, int soLuong)
        {
            this.idHoaDon = idHoaDon;
            this.tenBoPhanXuat = tenBoPhanXuat;
            this.idBoPhanXuat = idBoPhanXuat;
            this.idLoaiHoaDon = idLoaiHoaDon;
            this.idTaiKhoan = idTaiKhoan;
            this.ngayXuat = ngayXuat;
            this.tongTien = tongTien;
            this.soLuong = soLuong;
        }
    }
}
