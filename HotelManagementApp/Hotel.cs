using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementApp
{
    [Serializable]
    public class Hotel
    {
        private string Name { get; set; }
        private string Location { get; set; }
        private StarsNumber Stars { get; set; }
        private double Rating { get; set; } = 0;

        private List<Room> Rooms;

        public Hotel(string name, string location, byte stars) {
            Name = name;
            Location = location;
            Stars = (StarsNumber)stars;
            Rooms = new List<Room>();
        }

        public void AddRoom(Room room)
        {
            Rooms.Add(room);
        }

        public void AddRooms(List<Room> rooms)
        {
            this.Rooms = rooms;
        }

        public void RemoveRoom(Room room) 
        {
            this.Rooms.Remove(room);
        }

        public List<Room> GetRooms()
        {
            return Rooms;
        }

        public string GetName() { return Name; }
        
        public string GetLocation() { return Location; }

        public StarsNumber GetStars() { return Stars;  }
    }
}
