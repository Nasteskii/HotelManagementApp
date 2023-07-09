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
    public partial class fMakeReservation : Form
    {
        public string UserEmail { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public List<Guest> Guests { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }

        public fMakeReservation()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;
            DoubleBuffered = true;
        }

        private void fMakeReservation_Load(object sender, EventArgs e)
        {
            Guests = new List<Guest>();
        }

        private void numNumberOfGuests_ValueChanged(object sender, EventArgs e)
        {
            if (numNumberOfGuests.Value == 1)
            {
                numGuest1Age.Visible = true;
                numGuest2Age.Visible = false;
                numGuest3Age.Visible = false;
                numGuest4Age.Visible = false;
            }
            else if (numNumberOfGuests.Value == 2)
            {
                numGuest1Age.Visible = true;
                numGuest2Age.Visible = true;
                numGuest3Age.Visible = false;
                numGuest4Age.Visible = false;
            }
            else if (numNumberOfGuests.Value == 3)
            {
                numGuest1Age.Visible = true;
                numGuest2Age.Visible = true;
                numGuest3Age.Visible = true;
                numGuest4Age.Visible = false;
            }
            else
            {
                numGuest1Age.Visible = true;
                numGuest2Age.Visible = true;
                numGuest3Age.Visible = true;
                numGuest4Age.Visible = true;
            }

        }

        private void btnMakeReservation_Click(object sender, EventArgs e)
        {
            UserEmail = tbEmail.Text;
            UserFirstName = tbFirstName.Text;
            UserLastName = tbLastName.Text;
            if (numNumberOfGuests.Value == 1) 
            {
                Guests.Add(new Guest((int)numGuest1Age.Value));
            }
            else if (numNumberOfGuests.Value == 2)
            {
                Guests.Add(new Guest((int)numGuest1Age.Value));
                Guests.Add(new Guest((int)numGuest2Age.Value));
            }
            else if (numNumberOfGuests.Value == 3)
            {
                Guests.Add(new Guest((int)numGuest1Age.Value));
                Guests.Add(new Guest((int)numGuest2Age.Value));
                Guests.Add(new Guest((int)numGuest3Age.Value));
            }
            else
            {
                Guests.Add(new Guest((int)numGuest1Age.Value));
                Guests.Add(new Guest((int)numGuest2Age.Value));
                Guests.Add(new Guest((int)numGuest3Age.Value));
                Guests.Add(new Guest((int)numGuest4Age.Value));
            }
            CheckInDate = dtpCheckIn.Value;
            CheckOutDate = dtpCheckOut.Value;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
