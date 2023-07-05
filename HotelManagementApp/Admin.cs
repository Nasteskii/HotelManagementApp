using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementApp
{
    public class Admin
    {
        private string Email { get; set; }
        private string Password { get; set; }

        public Admin(string email, string password)
        {
            Email = email;
            Password = password;
        }


    }
}
