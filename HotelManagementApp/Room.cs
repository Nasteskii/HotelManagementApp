using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementApp
{
    [Serializable]
    public class Room
    {
        public int Number { get; set; }
        public BedTypes BedType { get; set; }
        public int Capacity { get; set; }
        public bool SeaView { get; set; }

        public Room(int number, BedTypes bedType, int capacity, bool seaView)
        {
            Number = number;
            BedType = bedType;
            Capacity = capacity;
            SeaView = seaView;
        }
    }
}
