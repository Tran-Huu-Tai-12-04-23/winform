using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_QUANLYKHO.Models
{
    public class Decentralization
    {
        public string idPhanQuyen { get; set; }
        public string idTaiKhoan { get; set; }
        public DateTime ngayBatDau { get; set; }
        public DateTime ngayKetThuc { get; set; }
        public bool quyenSua { get; set; }
        public bool quyenThem { get; set; }
        public bool quyenXoa { get; set; }
        public int loaiQuyen { get; set; }
        public string tentaikhoan{ get; set; }
    }
}
