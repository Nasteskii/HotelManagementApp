using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using BCryptNet = BCrypt.Net.BCrypt;
using System.Windows.Forms;

namespace HotelManagementApp
{
    public class Scene
    {
        private Admin admin;
        private Hotel hotel;
        private List<Reservation> reservations;
        private TransparentLabel HotelNameLabel;
        public Scene() 
        {
            reservations = new List<Reservation>();
            try
            {
                using (FileStream fileStream = new FileStream(Path.Combine("..", "..", "Data", "hotel.bin"), FileMode.Open))
                {
                    IFormatter formater = new BinaryFormatter();
                    hotel = (Hotel)formater.Deserialize(fileStream);
                }

                using (FileStream fileStream = new FileStream(Path.Combine("..", "..", "Data", "admin.bin"), FileMode.Open))
                {
                    IFormatter formater = new BinaryFormatter();
                    admin = (Admin)formater.Deserialize(fileStream);
                }
            }
            catch
            {

            }
        }

        public void Register(string email, string firstName, string lastName, string password)
        {
            admin = new Admin(email, firstName, lastName, password);

            FileStream fileStream = new FileStream(Path.Combine("..", "..", "Data", "admin.bin"), FileMode.Create);
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fileStream, admin);
        }

        public bool LogIn(string email, string password)
        {
            if (admin != null)
            {
                if (admin.CheckPassword(password))
                {
                    admin.setAuthenticatedStatus(true);
                }
                return admin.IsAuthenticated();
            }
            else { return false; }
        }

        public void LogOut()
        {
            admin.setAuthenticatedStatus(false);
        }

        public void NewHotel(string hotelName, string hotelLocation, byte hotelStars)
        {
            hotel = new Hotel(hotelName, hotelLocation, hotelStars);

            FileStream fileStream = new FileStream(Path.Combine("..", "..", "Data", "hotel.bin"), FileMode.Create);
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fileStream, hotel);
        }

        public void MakeReservation()
        {

        }

        public void Draw(Point hotelNameLabelLocation, Graphics g)
        {
           // HotelNameLabel = new TransparentLabel(hotelNameLabelLocation, hotel.GetName());
           // HotelNameLabel.Draw(g);
        }

        public Hotel GetHotel()
        {
            return hotel;
        }

        public bool HasHotel()
        {
            return hotel != null;
        }

    }
}
