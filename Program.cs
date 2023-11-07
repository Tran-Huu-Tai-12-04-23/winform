
using FinalProject_QUANLYKHO.View.Authentication;

namespace FinalProject_QUANLYKHO
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (Properties.Settings.Default.login)
            {
                ApplicationConfiguration.Initialize();
                Application.Run(new Form1());
                // Người dùng đã đăng nhập, cho phép truy cập vào các chức năng của ứng dụng
            }
            else
            {
                ApplicationConfiguration.Initialize();
                Application.Run(new Authentication());
            }
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
           
        }
    }

   
}