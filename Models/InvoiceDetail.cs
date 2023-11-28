using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_QUANLYKHO.Models
{
    public class InvoiceDetail
    {
        public string idNguyenLieu
        {
            get; set;
        }
        public string idChiTietHoaDon
        {
            get; set;
        }
        public string idHoaDon
        {
            get; set;
        }

        public int sl
        {
            get; set;
        }

        public Material material
        {
            get; set;
        }


        public double tongTien
        {
            get; set;
        }
        public InvoiceDetail()
        {

        }
        public InvoiceDetail Clone()
        {
            return new InvoiceDetail
            {
                idNguyenLieu = this.idNguyenLieu,
                idChiTietHoaDon = this.idChiTietHoaDon,
                idHoaDon = this.idHoaDon,
                sl = this.sl,
                material = this.material?.Clone(), // assuming Material has its own Clone method
                tongTien = this.tongTien
            };
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"ID Nguyên Liệu: {idNguyenLieu}");
            sb.AppendLine($"ID Chi Tiết Hóa Đơn: {idChiTietHoaDon}");
            sb.AppendLine($"ID Hóa Đơn: {idHoaDon}");
            sb.AppendLine($"Số Lượng: {sl}");
            sb.AppendLine($"Nguyên Liệu: {material}");
            sb.AppendLine($"Tổng Tiền: {tongTien}");

            return sb.ToString();
        }

    }
}
