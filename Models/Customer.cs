using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_QUANLYKHO.Models
{
    public class Customer
    {
        private string id;
        private string name;
        private string address;
        private string phoneNumber;
        private bool active;

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

        public string sodienthoai
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public bool hien
        {
            get { return active; }
            set { active = value; }
        }

        public Customer(string maKhachHang, string tenKhachHang, string diaChi, string phoneNumber)
        {
            id = maKhachHang;
            name = tenKhachHang;
            address = diaChi;
            this.phoneNumber = phoneNumber;
            this.sodienthoai = sodienthoai;
            this.hien = hien;
        }
        public Customer( string tenKhachHang, string diaChi, string phoneNumber)
        {
            name = tenKhachHang;
            address = diaChi;
            this.phoneNumber = phoneNumber;
            this.sodienthoai = sodienthoai;
            this.hien = hien;
        }
        public Customer()
        {
            id = "";
            name = "";
            address = "";
            phoneNumber = "";
        }
    }

}
