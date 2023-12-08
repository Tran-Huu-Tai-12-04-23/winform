using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_QUANLYKHO.Contanst
{
    internal class ContanstApp
    {
        public static int MAIN_SCREEN = -1;
        public static int BAKE_SCREEN = 0;
        public static int CUSTOMER_SCREEN = 1;
        public static int MATERIAL_SCREEN = 2;
        public static int DECENTRALIZATION = 3;
        //nav invoce 
        //BAKE
        public static int IMPORT_BAKE_IN = 4;//NHAP BÁNH NỘI BỘ
        public static int IMPORT_BAKE_OUT = 5;//NHẬP BÁNH NGOÀI
        public static int EXPORT_BAKE_CANCEL = 6;//XUẤT BÁNH HỦY
        public static int EXPORT_BAKE_RETURN = 7;//XUẤT BÁNH TRẢ
        public static int EXPORT_BAKE_OTHER = 8;//NHẬP BÁNH KHÁC
        public static int EXPORT_BAKE_GO = 9;//NHẬP BÁNH ĐI

        public static string NAME_NAV_IMPORT_BAKE_IN = "  Hóa đơn nhập bánh nội bộ";
        public static string NAME_NAV_IMPORT_BAKE_OUT = "  Hóa đơn nhập bánh mua ngoài";
        public static string NAME_NAV_EXPORT_BAKE_CANCEL = "  Hóa đơn xuất bánh hủy";
        public static string NAME_NAV_EXPORT_BAKE_RETURN = "  Hóa đơn xuất bánh trả";
        public static string NAME_NAV_EXPORT_BAKE_OTHER = "  Hóa đơn xuất bánh khác";
        public static string NAME_NAV_EXPORT_BAKE_GO = "  Hóa đơn xuất bánh đi";

        //MATERIAL
        public static int IMPORT_MATERIAL_IN = 10;//NHAP NGUYÊN LIỆU NỘI BỘ
        public static int IMPORT_MATERIAL_OUT = 11;//NHẬP NGUYÊN LIỆU NGOÀI
        public static int EXPORT_MATERIAL_CANCEL = 12;//XUẤT NGUYÊN LIỆU HỦY
        public static int EXPORT_MATERIAL_RETURN = 13;//XUẤT NGUYÊN LIỆU TRẢ
        public static int EXPORT_MATERIAL_OTHER = 14;//NHẬP NGUYÊN LIỆU KHÁC
        public static int EXPORT_MATERIAL_GO = 15;//NHẬP NGUYÊN LIỆU ĐI

        public static string NAME_NAV_IMPORT_MATERIAL_IN = "  Hóa đơn nhập nguyên liệu nội bộ";
        public static string NAME_NAV_IMPORT_MATERIAL_OUT = "  Hóa đơn nhập nguyên liệu mua ngoài";
        public static string NAME_NAV_EXPORT_MATERIAL_CANCEL = "  Hóa đơn xuất nguyên liệu hủy";
        public static string NAME_NAV_EXPORT_MATERIAL_RETURN = "  Hóa đơn xuất nguyên liệu trả";
        public static string NAME_NAV_EXPORT_MATERIAL_OTHER = "  Hóa đơn xuất nguyên liệu khác";
        public static string NAME_NAV_EXPORT_MATERIAL_GO = "  Hóa đơn xuất nguyên liệu đi";
        //OTHER
        public static int MAIN_MENU_INVOCE = 16;//NHẬP NGUYÊN LIỆU ĐI

        public static string NAME_NAV_HOME = "  Màn hình chính";
        public static string NAME_NAV_CUSTOMER = "  Khách  hàng";
        public static string NAME_NAV_MATERIAL = "  Nguyên liệu";
        public static string NAME_NAV_BAKE = "  Bánh";
        public static string NAME_NAV_MANAGER_INVOCE = "  Quản lý hóa đơn";
        public static string NAME_NAV_DECERLIZATION = "  Quản lý hóa đơn";




        public static Color ACTIVE_COLOR = Color.FromArgb(32, 42, 49);
        public static Color INACTIVE_COLOR = Color.FromArgb(20, 27, 31);
        public static Color BODY_COLOR = Color.FromArgb(241, 246, 249);
        public static Color TEXT_COLOR = Color.FromArgb(240, 240, 240);
        public static Color TEXT_ACTIVE_COLOR = Color.FromArgb(45, 130, 214);

        public static String CONNECT_DB_URL = @"Data Source=LAPTOP-HQS92G2N\ILOVEIU3K;Initial Catalog=QUANLYKHOHANG2;MultipleActiveResultSets=true;Integrated Security=True";
        public static string ERROR_EMPTY_USER = "Vui lòng nhập tên tài khoản";
        public static string ERROR_EMPTY_PASSWORD = "Vui lòng nhập tên mật khẩu";
        public static string ERROR_LESS_LENGTH = "Vui lòng nhập nhiều hơn 6 ký tự";
        public static string ERROR_INVALID_PASSWORD = "Vui lòng nhập tên mật khẩu";
        public static string ERROR_INVALID_USERNAME = "Vui lòng nhập tên mật khẩu";




        ///loai hoa don constanst 
        public static readonly string XuatNguyenLieuDi = "1";
        public static readonly string XuatNguyenLieuHuy = "2";
        public static readonly string XuatNguyenLieuTra = "3";
        public static readonly string XuatNguyenLieuKhac = "4";
        public static readonly string NhapNguyenLieuMuaNgoai = "5";
        public static readonly string NhapNguyenLieuNoiBo = "6";
        public static readonly string XuatBanhDi = "7";
        public static readonly string XuatBanhHuy = "8";
        public static readonly string XuatBanhTra = "9";
        public static readonly string XuatBanhKhac = "10";
        public static readonly string NhapBanhMuaNgoai = "11";
        public static readonly string NhapBanhNoiBo = "12";
    }
}
