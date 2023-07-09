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
        ErrorProvider errorProvider = new ErrorProvider();

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
            UserEmail = tbLastName.Text;
            UserFirstName = tbEmail.Text;
            UserLastName = tbFirstName.Text;
            CheckInDate = dtpCheckIn.Value;
            CheckOutDate = dtpCheckOut.Value;
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
            if (UserEmail.Trim().Length > 0 && UserFirstName.Length > 0 && UserLastName.Length > 0 && ValidationUtil.DateValidation(CheckInDate, CheckOutDate))
            {               
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Enter valid data");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            if (ValidationUtil.EmailValidation(tbEmail.Text))
            {
                errorProvider.SetError(tbEmail, null);
                e.Cancel = false;
            }
            else
            {
                errorProvider.SetError(tbEmail, "Enter correct Email");
                e.Cancel = true;
            }
        }

        private void tbFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (ValidationUtil.NameValidation(tbFirstName.Text))
            {
                errorProvider.SetError(tbFirstName, null);
                e.Cancel = false;
            }
            else
            {
                errorProvider.SetError(tbFirstName, "Enter First Name");
                e.Cancel = true;
            }
        }

        private void tbLastName_Validating(object sender, CancelEventArgs e)
        {
            if (ValidationUtil.NameValidation(tbLastName.Text))
            {
                errorProvider.SetError(tbLastName, null);
                e.Cancel = false;
            }
            else
            {
                errorProvider.SetError(tbLastName, "Enter Last Name");
                e.Cancel = true;
            }
        }
    }
}
