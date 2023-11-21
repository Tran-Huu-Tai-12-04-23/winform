using FinalProject_QUANLYKHO.View.CustomerView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProject_QUANLYKHO.Utils;
using FinalProject_QUANLYKHO.Contanst;
using FinalProject_QUANLYKHO.Service;
using FinalProject_QUANLYKHO.Models;

namespace FinalProject_QUANLYKHO.View.Authentication
{
    public partial class Login : Form
    {
        private AuthenticationService authenticationService;
        public Login()
        {
            authenticationService = new AuthenticationService();
            InitializeComponent();
            notificationPassword.Text = "";
            notificationUsername.Text = "";

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Authentication form = (Authentication)Application.OpenForms["Authentication"];

            if (form != null)
            {
                form.NavigateRegister();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool isCheckErr = false;
            ResetNotification();
            string username = inputUsername.Texts;
            string password = inputPassword.Texts;

            isCheckErr = Util.CheckInputAndNotificationApp("Tên tài khoản", username, notificationUsername);
            isCheckErr = Util.CheckInputAndNotificationApp("Mật khẩu", password, notificationPassword) || isCheckErr;


            if (isCheckErr)
            {
                return;
            }


            Account account = new Account();
            account.MatKhau = password.Trim();
            account.TenTaiKhoan = username.Trim();

            Account accountLogin = authenticationService.SignIn(account);
            if (accountLogin == null) {
                return;
            }

            MessageBox.Show("Đăng nhập thành công!");
            Properties.Settings.Default.username = accountLogin.TenTaiKhoan;
            Properties.Settings.Default.role = accountLogin.ChucVu;
            Properties.Settings.Default.login = true;
            Properties.Settings.Default.idTaiKhoan = accountLogin.IdTaiKhoan;
            Properties.Settings.Default.Save();

            Authentication form = (Authentication)Application.OpenForms["Authentication"];
            Form1 formmain = new Form1();
            formmain.Show();
            form.Hide();

        }

        private void ResetNotification()
        {
            notificationPassword.Text = " ";
            notificationUsername.Text = " ";
        }
    }
}
