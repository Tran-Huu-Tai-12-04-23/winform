using FinalProject_QUANLYKHO.Contanst;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FinalProject_QUANLYKHO.Utils
{
    public class Util
    {

      
        public static bool  IsVietnamesePhoneNumberValid(string phoneNumber)
        {
            string pattern = @"^(0[1-9]|84[1-9])(\d{8})$";
            return Regex.IsMatch(phoneNumber, pattern);
        }

        public static bool IsEmailValid(string email)
        {
            string pattern2 = @"^[^\.]*\.[^\.]*$";
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern) && Regex.IsMatch(email, pattern2);
        }

        public static bool IsNameValid(string name)
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
        public static bool isEmtyData(String data ) {
            return data.Equals("");
        }

        public static bool isLessLengthData(String data, int length)
        {
            return data.Length < length;
        }

        public static bool CheckInputAndNotificationApp(string nameInput, string data, Label notification)
        {

            if (Util.isEmtyData(data))
            {
                notification.Text = "Vui lòng nhập " + nameInput;
                return true;
            }
            else if (Util.isLessLengthData(data, 6))
            {
                notification.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nameInput) + "yêu cầu tối thiểu 6 ký tự!" ;
                return true;
            }

            return false;

        }

        public static string HashPassword(string password)
        {
            byte[] salt;
            byte[] buffer;

            if (password == null)
            {
                throw new ArgumentNullException(nameof(password));
            }

            using (var rng = new RNGCryptoServiceProvider())
            {
                salt = new byte[16];
                rng.GetBytes(salt);
            }

            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000))
            {
                buffer = pbkdf2.GetBytes(20);
            }

            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(buffer, 0, hashBytes, 16, 20);

            return Convert.ToBase64String(hashBytes);
        }

        public static bool VerifyPassword(string password, string hashedPassword)
        {
            byte[] hashBytes = Convert.FromBase64String(hashedPassword);

            byte[] salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);

            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000))
            {
                byte[] buffer = pbkdf2.GetBytes(20);

                for (int i = 0; i < 20; i++)
                {
                    if (hashBytes[i + 16] != buffer[i])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }

    
    
}