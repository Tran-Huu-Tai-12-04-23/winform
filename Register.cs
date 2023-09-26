using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp1
{

    public partial class Register : Form
    {
        private readonly string connectionString = "Data Source=localhost, 1433;Initial Catalog=quanlynguoidung; User ID=sa;Password=tai2k300@@@@@;TrustServerCertificate=True;";


        public Register()
        {
            InitializeComponent();
            inputPassword.PasswordChar = '*';
            inputConformPassword.PasswordChar = '*';
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private bool IsVietnamesePhoneNumberValid(string phoneNumber)
        {
            string pattern = @"^(0[1-9]|84[1-9])(\d{8})$";
            return Regex.IsMatch(phoneNumber, pattern);
        }
        private bool ValidateRegister(string username, string email, string password, string confirmPassword, string phoneNumber)
        {
            if (username.Length <= 6)
            {
                MessageBox.Show("Tên người dùng phải có ít nhất 6 ký tự!");
                return false;
            }
            if (password.Length < 8)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 8 ký tự!");
                return false;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Mật khẩu và xác nhận mật khẩu không khớp!");
                return false;
            }

            if (!IsEmailValid(email))
            {
                MessageBox.Show("Định dạng email không hợp lệ!");
                return false;
            }
            if (!IsVietnamesePhoneNumberValid(phoneNumber))
            {
                MessageBox.Show("Định dạng số điện thoại không hợp lệ!");
                return false;
            }

            if (!IsNameValid(username)) {

                MessageBox.Show("tên người dùng không chứa dấu *!");
                return false;
            }
            return true;
        }

      
        private bool IsEmailValid(string email)
        {
            string pattern2 = @"^[^\.]*\.[^\.]*$";
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern) && Regex.IsMatch(email, pattern2);
        }
        private bool checkDataExist(string email, string username)
        {

            using (SqlConnection connc = new SqlConnection(connectionString))
            {
                string emailCheckQuery = "SELECT COUNT(*) FROM account WHERE email = @Email";
                using (SqlCommand command = new SqlCommand(emailCheckQuery, connc))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    connc.Open();
                    int emailCount = (int)command.ExecuteScalar();
                    if (emailCount > 0)
                    {
                        MessageBox.Show("Email already exists. Please choose a different email.");
                        return false;
                    }
                }

                string usernameCheckQuery = "SELECT COUNT(*) FROM account WHERE username = @Username";
                using (SqlCommand command = new SqlCommand(usernameCheckQuery, connc))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    int usernameCount = (int)command.ExecuteScalar();
                    if (usernameCount > 0)
                    {
                        MessageBox.Show("Username already exists. Please choose a different username.");
                        return false;
                    }
                }
            }
            return true;
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = inputUsername.Text;
            string password = inputPassword.Text;
            string confirmPassword = inputConformPassword.Text;
            string email = inputEmail.Text;
            string phoneNumber = inputPhone.Text;


            bool validate = ValidateRegister(username, email, password, confirmPassword, phoneNumber);

            if (validate)
            {
                bool dataNotExist = checkDataExist(email, username);

                if (dataNotExist)
                {
                    CreateAccount(username, email, password, phoneNumber);
                }
            }
        }

        private void CreateAccount(string username, string email, string password, string phoneNumber)
        {
            using (SqlConnection connc = new SqlConnection(connectionString))
            {
                string insertQuery = "INSERT INTO account (username, email, password, phoneNumber) VALUES (@Username, @Email, @Password, @phoneNumber)";
                using (SqlCommand command = new SqlCommand(insertQuery, connc))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                    command.Parameters.AddWithValue("@Password", password);
                    connc.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Tạo tài khoản thành công!");
                        Form1 login = new Form1();
                        login.Show();
                        this.Hide();
                        // Perform any further actions (e.g., redirect to a login page) here.
                    }
                    else
                    {
                        MessageBox.Show("Tạo taoif khoản thất bại vui lòng thử lại!");
                    }
                }
            }
        }


        private bool IsNameValid(string name)
        {
            string pattern = @"\*";

            if (Regex.IsMatch(name, pattern))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void label4_Click_1(object sender, EventArgs e)
        {

        }
    }


}
