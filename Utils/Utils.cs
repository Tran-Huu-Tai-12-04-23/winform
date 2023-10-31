using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FinalProject_QUANLYKHO.Utils
{
    public class Util
    {
        private bool IsVietnamesePhoneNumberValid(string phoneNumber)
        {
            string pattern = @"^(0[1-9]|84[1-9])(\d{8})$";
            return Regex.IsMatch(phoneNumber, pattern);
        }

        private bool IsEmailValid(string email)
        {
            string pattern2 = @"^[^\.]*\.[^\.]*$";
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern) && Regex.IsMatch(email, pattern2);
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
        private bool isEmtyData(String data ) {
            return data.Equals("");
        }
    }

    
    
}