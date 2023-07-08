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

        public Admin(string firstName, string lastName, string email, string password) : base(email, firstName, lastName)
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

        internal bool CheckCredentials(string email, string password)
        {
            return email == base.GetEmail() && BCryptNet.Verify(password, HashedPassword);
        }
    }
}
