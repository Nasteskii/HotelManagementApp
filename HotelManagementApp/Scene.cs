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
        public Scene() 
        {
            try
            {
                using (FileStream fileStream = new FileStream(Path.Combine("..", "..", "Data", "hotel.bin"), FileMode.Open))
                {
                    IFormatter formater = new BinaryFormatter();
                    hotel = (Hotel)formater.Deserialize(fileStream);
                }
            }
            catch
            {

            }
            try
            {
                using (FileStream fileStream = new FileStream(Path.Combine("..", "..", "Data", "admin.bin"), FileMode.Open))
                {
                    IFormatter formater = new BinaryFormatter();
                    admin = (Admin)formater.Deserialize(fileStream);
                }
            }
            catch
            {

            }
            try
            {
                using (FileStream fileStream = new FileStream(Path.Combine("..", "..", "Data", "reservations.bin"), FileMode.Open))
                {
                    IFormatter formater = new BinaryFormatter();
                    reservations = (List<Reservation>)formater.Deserialize(fileStream);
                }
            }
            catch
            {
                reservations = new List<Reservation>();
            }
        }

        public void Register(string firstName, string lastName, string email, string password)
        {
            admin = new Admin(firstName, lastName, email, password);

            using (FileStream fileStream = new FileStream(Path.Combine("..", "..", "Data", "admin.bin"), FileMode.Create))
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fileStream, admin);
            }
        }

        public bool LogIn(string email, string password)
        {
            if (HasAdmin())
            {
                if (admin.CheckCredentials(email, password))
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
            List<Room> rooms;
            if (hotel != null)
            {
                rooms = hotel.GetRooms();
            }
            else
            {
                rooms = new List<Room>();
            }
            hotel = new Hotel(hotelName, hotelLocation, hotelStars);
            hotel.AddRooms(rooms);
            

            using (FileStream fileStream = new FileStream(Path.Combine("..", "..", "Data", "hotel.bin"), FileMode.Create))
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fileStream, hotel);
            }
        }

        public void MakeReservation(User user, int roomNumber, List<Guest> guests, DateTime checkInDate, DateTime checkOutDate)
        {
            reservations.Add(new Reservation(user, roomNumber, guests, checkInDate, checkOutDate));
            using (FileStream fileStream = new FileStream(Path.Combine("..", "..", "Data", "reservations.bin"), FileMode.Create))
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fileStream, reservations);
            }
        }

        public void RemoveReservation(Reservation reservation)
        {
            reservations.Remove(reservation);
            using (FileStream fileStream = new FileStream(Path.Combine("..", "..", "Data", "reservations.bin"), FileMode.Create))
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fileStream, reservations);
            }
        }

        public bool HasHotel()
        {
            return hotel != null;
        }

        public Hotel GetHotel()
        {
            return hotel;
        }

        public bool HasAdmin()
        {
            return admin != null;
        }

        public Admin GetAdmin()
        {
            return admin;
        }

        public List<Reservation> GetReservations()
        {
            return reservations;
        }
    }
}
