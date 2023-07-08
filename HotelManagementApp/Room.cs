using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementApp
{
    [Serializable]
    public class Room
    {
        private int Number { get; set; }
        private BedTypes BedType { get; set; }
        private int Capacity { get; set; }
        private bool SeaView { get; set; }
        private List<Image> Images { get; set; }


        public Room(int number, BedTypes bedType, int capacity, bool seaView)
        {
            Number = number;
            BedType = bedType;
            Capacity = capacity;
            SeaView = seaView;
        }

        public void AddImage(Image image)
        {
            Images.Add(image);
        }

        public int GetNumber()
        {
            return Number;
        }

        public BedTypes GetBedType()
        {
            return BedType;
        }

        public int GetCapacity()
        {
            return Capacity;
        }

        public bool HasSeaView()
        {
            return SeaView;
        }

        public List<Image> GetImages()
        {
            return Images;
        }
    }
}
