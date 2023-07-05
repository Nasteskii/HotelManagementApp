﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementApp
{
    public class Hotel
    {
        private string Name { get; set; }
        private string Location { get; set; }
        private StarsNumber Stars { get; set; }
        private double Rating { get; set; } = 0;

        private List<Room> Rooms;

        public Hotel(string name, string location, StarsNumber stars) {
            Name = name;
            Location = location;
            Stars = stars;
            Rooms = new List<Room>();
        }

        public void addRoom(Room room)
        {
            Rooms.Add(room);
        }
    }
}