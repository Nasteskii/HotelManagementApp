using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementApp
{
    public class User
    {
        private string Email { get; set; }

        private string FirstName { get; set; }
        private string LastName { get; set; }

        public User(string email, string firstName, string lastName) 
        {
            Email = email;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
