﻿using System;
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
        public static Color ACTIVE_COLOR = Color.FromArgb(135, 206, 250);
        public static Color INACTIVE_COLOR = Color.FromArgb(241, 246, 249);
        public static Color BODY_COLOR = Color.FromArgb(241, 246, 249);

        public static String CONNECT_DB_URL = "Data Source=\"localhost, 1433\";Initial Catalog=QUANLYKHOHANG;Persist Security Info=True;User ID=sa;password=tai2k300@@@@@";
    }
}
