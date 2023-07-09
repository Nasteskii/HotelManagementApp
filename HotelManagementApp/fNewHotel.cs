using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementApp
{
    public partial class fNewHotel : Form
    {
        public string HotelName { get; set; }
        public string HotelLocation { get; set; }
        public StarsNumber HotelStars { get; set; }

        public fNewHotel()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;
            DoubleBuffered = true;
            cbHotelStars.DataSource = Enum.GetValues(typeof(StarsNumber));
        }

        public void LoadFields()
        {
            tbHotelName.Text = HotelName;
            tbHotelLocation.Text = HotelLocation;
            cbHotelStars.SelectedItem = HotelStars;
        }

        private void btnSubmitHotel_Click(object sender, EventArgs e)
        {
            HotelName = tbHotelName.Text;
            HotelLocation = tbHotelLocation.Text;
            HotelStars = (StarsNumber)cbHotelStars.SelectedItem;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
