using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace HotelManagementApp
{
    public static class ValidationUtil
    {
        public static bool NameValidation(string name)
        {
            if (name.Trim().Length == 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public static bool LocationValidation(string location)
        {
            if (location.Trim().Length == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool EmailValidation(string email)
        {
            if (email.Trim().Length == 0)
            {
                return false;
            }
            else
            {
                try
                {
                    var emailAddress = new MailAddress(email);
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public static bool PasswordValidation(string password)
        {
            if (password.Trim().Length > 6)
            {
                bool containsNumber = false;
                foreach (char character in password.ToCharArray())
                {
                    if (char.IsDigit(character))
                    {
                        containsNumber = true;
                        break;
                    }
                }
                if (password.Trim() != password.ToLower() && containsNumber)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        public static bool DateValidation(DateTime checkIn, DateTime checkOut)
        {
            if (!checkIn.Equals(checkOut) && checkIn >= DateTime.Now.AddMinutes(-5) && checkOut >= DateTime.Now.AddMinutes(-5) && checkOut > checkIn)
            {
                return true;
            }
            return false;
        }
    }
}
