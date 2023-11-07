using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_QUANLYKHO.Models
{
    internal class Account
    {
        public string IdTaiKhoan { get; set; }
        public int ChucVu { get; set; }
        public string TenTaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public string Email { get; set; }
        public string SoDienThoai { get; set; }

        public Account()
        {
            
        }

        // Parameterized constructor
        public Account(string idTaiKhoan, int chucVu, string tenTaiKhoan, string matKhau, string email, string soDienThoai)
        {
            IdTaiKhoan = idTaiKhoan;
            ChucVu = chucVu;
            TenTaiKhoan = tenTaiKhoan;
            MatKhau = matKhau;
            Email = email;
            SoDienThoai = soDienThoai;
        }
    }
}

