using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_QUANLYKHO.Models
{
    internal class Customer
    {
        private string id;
        private string name;
        private string address;

        public string maKhachHang
        {
            get { return id; }
            set { id = value; }
        }

        public string tenKhachHang
        {
            get { return name; }
            set { name = value; }
        }

        public string diaChi
        {
            get { return address; }
            set { address = value; }
        }

        public Customer(string maKhachHang, string tenKhachHang, string diaChi)
        {
            id = maKhachHang;
            name = tenKhachHang;
            address = diaChi;
        }
        public Customer()
        {
            id = "";
            name = "";
            address = "";
        }
    }

}
