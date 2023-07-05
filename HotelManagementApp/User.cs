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
        private List<Guest> Guests;

        public User(string email, List<Guest> guests)
        {
            Email = email;
            Guests = guests;
        }
    }
}
