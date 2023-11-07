using FinalProject_QUANLYKHO.Models;
using FinalProject_QUANLYKHO.Service;
using FinalProject_QUANLYKHO.Utils;
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

namespace FinalProject_QUANLYKHO.View.Authentication
{
    public partial class Register : Form
    {
        private AuthenticationService authenticationService;
        public Register()
        {
            authenticationService = new AuthenticationService();
            InitializeComponent();
            notifiPassword.Visible = false;
            notifiEmail.Visible = false;
            notifiConfirmPassword.Visible = false;
            notifiPhoneNumber.Visible = false;
            notifiUsername.Visible = false;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NavigateLogin()
        {
            Authentication form = (Authentication)Application.OpenForms["Authentication"];

            if (form != null)
            {
                form.NavigateLogin();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            NavigateLogin();

        }


        private void btnRegister_Click(object sender, EventArgs e)
        {

            bool isError = verifyInformation();

            if (isError == true) return;

            String username = inputUsername.Texts;
            String email = inputEmail.Texts;
            String password = inputPassword.Texts;
            String confirmPassword = inputConfirmPassword.Texts;
            String phoneNumber = inputPhonenumber.Texts;

            Account account = new Account();
            account.TenTaiKhoan = username;
            account.Email = email;
            account.SoDienThoai = phoneNumber;
            account.MatKhau = password;

            String notification= authenticationService.SignUp(account);
            if (notification.Trim().Equals("sucess")) {
                ClearForm();
                MessageBox.Show("Tạo tài khoản thành công!");
            }else
            {
                MessageBox.Show(notification);
            }

        }
        private void ClearForm()
        {
            inputEmail.Texts = "";
            inputPassword.Texts = "";
            inputConfirmPassword.Texts = "";
            inputPhonenumber.Texts = "";
            inputUsername.Texts = "";
        }


        private bool verifyInformation()
        {
            bool isError = false;
            String username = inputUsername.Texts;
            String email = inputEmail.Texts;
            String password = inputPassword.Texts;
            String confirmPassword = inputConfirmPassword.Texts;
            String phoneNumber = inputPhonenumber.Texts;

            if (username.Trim().Equals(""))
            {
                notifiUsername.Text = "Vui lòng nhập tên tài khoản!";
                notifiUsername.Visible = true;
                isError = true;
            }
            else if (Util.isLessLengthData(username, 6))
            {
                notifiUsername.Text = "Tên tài khoản dài hơn 6 ký tự!";
                notifiUsername.Visible = true;
                isError = true;
            }

            if (email.Trim().Equals(""))
            {
                notifiEmail.Text = "Vui lòng nhập email!";
                notifiEmail.Visible = true;
                isError = true;
            }
            else if (!Util.IsEmailValid(email))
            {
                notifiEmail.Text = "Email không đúng định dạng!";
                notifiEmail.Visible = true;
                isError = true;
            }

            if (phoneNumber.Trim().Equals(""))
            {
                notifiPhoneNumber.Text = "Vui lòng nhập số điện thoại!";
                notifiPhoneNumber.Visible = true;
                isError = true;
            }
            else if (!Util.IsVietnamesePhoneNumberValid(phoneNumber))
            {
                notifiPhoneNumber.Text = "Số điện thoại không đúng định dạng!";
                notifiPhoneNumber.Visible = true;
                isError = true;
            }

            if (password.Trim().Equals(""))
            {
                notifiPassword.Text = "Vui lòng nhập mật khẩu của bạn!";
                notifiPassword.Visible = true;
                isError = true;
            }
            else if (Util.isLessLengthData(password, 6))
            {
                notifiPassword.Text = "Mật khẩu dài hơn 6 ký tự!";
                notifiPassword.Visible = true;
                isError = true;
            }
            if (confirmPassword.Trim().Equals(""))
            {
                notifiConfirmPassword.Text = "Vui lòng nhập xác nhận mật khẩu!";
                notifiConfirmPassword.Visible = true;
                isError = true;
            }
            else if (!confirmPassword.Trim().Equals(password))
            {
                notifiConfirmPassword.Text = "Xác nhận mật khẩu không khớp!";
                notifiConfirmPassword.Visible = true;
                isError = true;
            }

            return isError;
        }

        private void input_phone_number_keypress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                notifiPhoneNumber.Text = "Chỉ nhập số...";
                notifiPhoneNumber.Visible = true;
            }
            else
            {
                notifiPhoneNumber.Visible = true;
                notifiPhoneNumber.Text = "";
            }
        }


    }
}
