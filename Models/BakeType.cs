using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_QUANLYKHO.Models
{
    internal class BakeType
    {
        public string idLoaiBanh { get; set; }
        public string tenLoaiBanh { get; set; }
        public BakeType() { }
        public BakeType(string idLoaiBanh, string tenLoaiBanh)
        {
            this.idLoaiBanh = idLoaiBanh;
            this.tenLoaiBanh = tenLoaiBanh;
        }

    }
}
