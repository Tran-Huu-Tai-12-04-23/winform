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
    }
}
