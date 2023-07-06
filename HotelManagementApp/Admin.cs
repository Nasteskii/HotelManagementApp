using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCryptNet = BCrypt.Net.BCrypt;


namespace HotelManagementApp
{
    [Serializable]
    public class Admin : User
    {
        private string HashedPassword { get; set; }
        private bool Authenticated { get; set; } = false;

        public Admin(string email, string firstName, string lastName, string password) : base(email, firstName, lastName)
        {
            HashedPassword = BCryptNet.HashPassword(password);
        }

        public void setAuthenticatedStatus(bool status)
        {
            Authenticated = status;
        }

        public bool IsAuthenticated()
        {
            return Authenticated;
        }

        internal bool CheckPassword(string password)
        {
            return BCryptNet.Verify(password, HashedPassword);
        }
    }
}
