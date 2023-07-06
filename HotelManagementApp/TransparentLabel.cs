using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementApp
{
    public class TransparentLabel
    {
        private Point StartPoint { get; set; }
        private string HotelName { get; set; }

        public TransparentLabel(Point point, string hotelName) 
        {
            StartPoint = point;
            HotelName = hotelName;
        }

        public void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color.Black);
            g.DrawString(HotelName, new Font("Arial", 12), b, StartPoint);
            b.Dispose();
        }
    }
}
