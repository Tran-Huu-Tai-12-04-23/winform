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
        public static string NAME_NAV_HOME = "  Màn hình chính";
        public static string NAME_NAV_CUSTOMER = "  Khách  hàng";
        public static string NAME_NAV_MATERIAL = "  Nguyên liệu";
        public static string NAME_NAV_BAKE = "  Bánh";
        public static string NAME_NAV_EXPORTMATERIAL = "  HD xuất nguyên liệu";
        public static string NAME_NAV_IMPORTMATERIAL = "  HD nhập nguyên liệu";
        public static string NAME_NAV_EXPORTBAKE = "  HD xuất bánh";
        public static string NAME_NAV_IMPORTBAKE = "  HD nhập bánh";
        public static string NAME_NAV_DECENTRILIZATION= "  Phân quyền";

        public static Color ACTIVE_COLOR = Color.FromArgb(135, 206, 250);
        public static Color INACTIVE_COLOR = Color.FromArgb(241, 246, 249);
        public static Color BODY_COLOR = Color.FromArgb(241, 246, 249);

        public static String CONNECT_DB_URL = "Data Source=\"localhost, 1433\";Initial Catalog=QUANLYKHOHANG;Persist Security Info=True;User ID=sa;password=tai2k300@@@@@";
        public static string ERROR_EMPTY_USER = "Vui lòng nhập tên tài khoản";
        public static string ERROR_EMPTY_PASSWORD = "Vui lòng nhập tên mật khẩu";
        public static string ERROR_LESS_LENGTH = "Vui lòng nhập nhiều hơn 6 ký tự";
        public static string ERROR_INVALID_PASSWORD = "Vui lòng nhập tên mật khẩu";
        public static string ERROR_INVALID_USERNAME = "Vui lòng nhập tên mật khẩu";

    }
}
