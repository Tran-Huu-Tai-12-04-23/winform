using FinalProject_QUANLYKHO.DB;
using FinalProject_QUANLYKHO.Models;
using FinalProject_QUANLYKHO.Utils;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FinalProject_QUANLYKHO.Service
{
    internal class AuthenticationService
    {
        private SqlConnection connection;
        private const string CREATE_ACCOUT_QUERY = "CreateNewAccount";
        private const string COUNT_EMAIL_EXIST = "select AccountCount from CountAccountWithEmail where email = @email";
        private const string COUNT_PHONE_EXIST = "select AccountCount from CountAccountWithPhoneNumber where sodienthoai = @PhoneNumber ";
        private const string COUNT_USER_EXIST = "select AccountCount from CountAccountWithUserName where tenTaiKhoan = @tenTaiKhoan ";
        private const string GET_USER_BY_USERNAME = "select distinct *  from taikhoan where tenTaiKhoan = @tenTaiKhoan ";

        public AuthenticationService()
        {
            ConfigDB config = ConfigDB.Instance;
            connection = config.GetConnection();
        }


        public String SignUp(Account account)
        {
            bool isPhoneNumberExist = this.CheckPhoneExistence(account.SoDienThoai);
            bool isEmailExist = this.CheckEmailExistence(account.Email);
            bool isAccountEixst = this.CheckUserExist(account.TenTaiKhoan);

            if (isPhoneNumberExist) return "Số điện thoại đã tồn tại, vui lòng nhập số khác!";
            if (isEmailExist) return "Email đã tồn tài, vui lòng nhập email khác!";
            if (isAccountEixst) return "Tên tài khoản đã tồn tại, vui lòng thử tên khác!";

            try
            {
                SqlCommand cmd = new SqlCommand(CREATE_ACCOUT_QUERY, connection);

                cmd.CommandType = CommandType.StoredProcedure;

                string hashPassword = Util.HashPassword(account.MatKhau);
                cmd.Parameters.Add(new SqlParameter("@tentaikhoan", SqlDbType.VarChar, 255)).Value = account.TenTaiKhoan;
                cmd.Parameters.Add(new SqlParameter("@matkhau", SqlDbType.VarChar, 255)).Value = hashPassword;
                cmd.Parameters.Add(new SqlParameter("@sodienthoai", SqlDbType.VarChar, 255)).Value = account.SoDienThoai;
                cmd.Parameters.Add(new SqlParameter("@email", SqlDbType.VarChar, 255)).Value = account.Email;


                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();


                }
                cmd.ExecuteNonQuery();

                connection.Close();
                return "sucess";
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return ex.Message;

            }

        }


        public Account SignIn(Account account)
        {

            try
            {
                SqlCommand cmd = new SqlCommand(GET_USER_BY_USERNAME, connection);

                cmd.Parameters.Add(new SqlParameter("@tentaikhoan", SqlDbType.VarChar, 255)).Value = account.TenTaiKhoan;

                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }


                using (SqlDataReader reader = cmd.ExecuteReader())
                {

                    if (reader.Read())
                    {
                        Account accountLogin = new Account();
                        accountLogin.TenTaiKhoan = (string)reader["tenTaiKhoan"];
                        accountLogin.IdTaiKhoan = (string)reader["idTaiKhoan"];
                        accountLogin.MatKhau = (string)reader["matKhau"];
                        accountLogin.Email = (string)reader["email"];
                        accountLogin.SoDienThoai = (string)reader["soDienThoai"];
                        accountLogin.ChucVu = (int)reader["chucVu"];


                        string passwordHash = accountLogin.MatKhau;
                        if (Util.VerifyPassword( account.MatKhau, passwordHash))
                        {
                            return accountLogin;
                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu không chính xác");
                            return null;
                        }

                    }
                }
                MessageBox.Show("Tài khoản không tồn tại!");

                connection.Close();
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return null;

            }

        }




        public bool CheckEmailExistence(string email)
        {

            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
            using (SqlCommand command = new SqlCommand(COUNT_EMAIL_EXIST, connection))
            {
                command.Parameters.Add(new SqlParameter("@Email", SqlDbType.VarChar, 255) { Value = email });
                return Convert.ToInt32(command.ExecuteScalar()) > 0;
            }
        }

        public bool CheckPhoneExistence(string phoneNumber)
        {

            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            using (SqlCommand command = new SqlCommand(COUNT_PHONE_EXIST, connection))
            {
                command.Parameters.Add(new SqlParameter("@PhoneNumber", SqlDbType.VarChar, 255) { Value = phoneNumber });
                return Convert.ToInt32(command.ExecuteScalar()) > 0;
            }
        }

        public bool CheckUserExist(string tenTaiKhoan)
        {

            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            using (SqlCommand command = new SqlCommand(COUNT_USER_EXIST, connection))
            {
                command.Parameters.Add(new SqlParameter("@tentaiKhoan", SqlDbType.VarChar, 255) { Value = tenTaiKhoan });
                return Convert.ToInt32(command.ExecuteScalar()) > 0;
            }
        }





    }
}
