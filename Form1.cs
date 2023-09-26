
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Security;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private readonly string connectionString = "Data Source=localhost, 1433;Initial Catalog=quanlynguoidung; User ID=sa;Password=tai2k300@@@@@;TrustServerCertificate=True;";

        public Form1()
        {
            InitializeComponent();
            inputPassword.PasswordChar = '*';
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = inputEmail.Text;
            string password = inputPassword.Text;

            if (email == "" || password == "") {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }

            Login(email, password);


        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool Login(string email, string password) {
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Định dạng email không hợp lệ!");
                return false;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM account WHERE email = @Email AND password = @Password";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password);

                    int userCount = (int)command.ExecuteScalar();

                    if (userCount > 0)
                    {
                        MessageBox.Show("Đăng nhập thành công!");
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập thất bại. Vui lòng kiểm tra lại email và mật khẩu.");
                        return false;
                    }
                }
            }
            return true;
        }
        private void label4_Click(object sender, EventArgs e)
        {
            Register rg = new Register();
            rg.Show();
            Close();
        }
    }
}