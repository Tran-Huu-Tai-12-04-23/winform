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
    }
}
