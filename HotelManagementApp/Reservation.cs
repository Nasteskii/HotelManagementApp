using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementApp
{
    [Serializable]
    public class Reservation
    {
        private User ReservationUser { get; set; }
        private int RoomNumber { get; set; }
        private List<Guest> Guests { get; set; }
        private DateTime CheckInDate { get; set; }
        private DateTime CheckOutDate { get; set; }


        public Reservation(User user, int roomNumber, List<Guest> guests, DateTime checkInDate, DateTime checkOutDate)
        {
            ReservationUser = user;
            RoomNumber = roomNumber;
            Guests = guests;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
        }

        public User GetReservationUser()
        {
            return ReservationUser;
        }

        public int GetRoomNumber()
        {
            return RoomNumber;
        }

        public List<Guest> GetGuests()
        {
            return Guests;
        }

        public DateTime GetCheckInDate()
        {
            return CheckInDate.Date;
        }

        public DateTime GetCheckOutDate()
        {
            return CheckOutDate.Date;
        }
    }
}
