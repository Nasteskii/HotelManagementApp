using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementApp
{
    public partial class fReservations : Form
    {
        public Scene scene;
        private Panel panel;
        public fReservations()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;
            DoubleBuffered = true;
        }

        private void fReservations_Load(object sender, EventArgs e)
        {
            panel = new Panel();
            panel.Name = "pReservations";
            panel.AutoScroll = true;
            panel.Location = new Point(30, 30);
            panel.Size = new Size(360, 300);
            Controls.Add(panel);

            LoadReservations();
        }

        private void LoadReservations()
        {
            if (scene != null)
            {
                List<Reservation> reservations = scene.GetReservations();
                panel.Controls.Clear();
                if (reservations.Count != 0)
                {
                    int i = 0;
                    foreach (Reservation reservation in reservations)
                    {
                        Label lUserEmail = new Label();
                        lUserEmail.Text = "User Email: " + reservation.GetReservationUser().GetEmail();
                        lUserEmail.BackColor = Color.Transparent;
                        lUserEmail.Font = new Font("Arial", 10);

                        Label lFirstName = new Label();
                        lFirstName.Text = "First Name: " + reservation.GetReservationUser().GetFirstName();
                        lFirstName.BackColor = Color.Transparent;
                        lFirstName.Font = new Font("Arial", 10);

                        Label lLastName = new Label();
                        lLastName.Text = "Last Name: " + reservation.GetReservationUser().GetLastName();
                        lLastName.BackColor = Color.Transparent;
                        lLastName.Font = new Font("Arial", 10);

                        Label lNumber = new Label();
                        lNumber.Text = "Room: " + reservation.GetRoomNumber().ToString();
                        lNumber.BackColor = Color.Transparent;
                        lNumber.Font = new Font("Arial", 10);

                        Label lNumberOfGuests = new Label();
                        lNumberOfGuests.Text = "Number of guests: " + reservation.GetGuests().Count.ToString();
                        lNumberOfGuests.BackColor = Color.Transparent;
                        lNumberOfGuests.Font = new Font("Arial", 10);

                        Label lCheckInDate = new Label();
                        lCheckInDate.Text = "Check In: ";
                        lCheckInDate.BackColor = Color.Transparent;
                        lCheckInDate.Font = new Font("Arial", 10);

                        DateTimePicker dtpCheckInDate = new DateTimePicker();
                        dtpCheckInDate.Enabled = false;
                        dtpCheckInDate.Value = reservation.GetCheckInDate();

                        Label lCheckOutDate = new Label();
                        lCheckOutDate.Text = "Check Out: ";
                        lCheckOutDate.BackColor = Color.Transparent;
                        lCheckOutDate.Font = new Font("Arial", 10);

                        DateTimePicker dtpCheckOutDate = new DateTimePicker();
                        dtpCheckOutDate.Enabled = false;
                        dtpCheckOutDate.Value = reservation.GetCheckOutDate();

                        Button btnRemoveReservation = new Button();
                        btnRemoveReservation.Name = "btnRemoveReservation";
                        btnRemoveReservation.Text = "Remove";
                        btnRemoveReservation.FlatStyle = FlatStyle.Popup;
                        btnRemoveReservation.Click += btnRemoveReservation_Click;
                        btnRemoveReservation.Tag = reservation;

                        GroupBox groupBox = new GroupBox();
                        groupBox.Name = "gbReservation" + (i + 1);
                        groupBox.Text = "Reservation" + (i + 1);
                        groupBox.Location = new Point(10, 10 + (i * 160));
                        groupBox.Size = new Size(330, 260);
                        groupBox.Controls.Add(lNumber);
                        groupBox.Controls.Add(lUserEmail);
                        groupBox.Controls.Add(lFirstName);
                        groupBox.Controls.Add(lLastName);
                        groupBox.Controls.Add(lNumberOfGuests);
                        groupBox.Controls.Add(lCheckInDate);
                        groupBox.Controls.Add(dtpCheckInDate);
                        groupBox.Controls.Add(lCheckOutDate);
                        groupBox.Controls.Add(dtpCheckOutDate);
                        groupBox.Controls.Add(btnRemoveReservation);


                        lNumber.Location = new Point(10, 20);
                        lNumber.Size = new Size(200, 20);

                        lUserEmail.Location = new Point(10, 50);
                        lUserEmail.Size = new Size(200, 20);

                        lFirstName.Location = new Point(10, 80);
                        lFirstName.Size = new Size(200, 20);

                        lLastName.Location = new Point(10, 110);
                        lLastName.Size = new Size(200, 20);

                        lNumberOfGuests.Location = new Point(10, 140);
                        lNumberOfGuests.Size = new Size(200, 20);

                        lCheckInDate.Location = new Point(10, 170);
                        lCheckInDate.Size = new Size(100, 20);

                        dtpCheckInDate.Location = new Point(120, 170);
                        dtpCheckInDate.Size = new Size(200, 20);

                        lCheckOutDate.Location = new Point(10, 200);
                        lCheckOutDate.Size = new Size(100, 20);

                        dtpCheckOutDate.Location = new Point(120, 200);
                        dtpCheckOutDate.Size = new Size(200, 20);

                        btnRemoveReservation.Location = new Point(10, 230);
                        btnRemoveReservation.Size = new Size(75, 20);

                        panel.Controls.Add(groupBox);
                        i++;
                    }
                }
                else
                {
                    Label lNoReservations = new Label();
                    lNoReservations.Text = "There are no reservations!";
                    lNoReservations.BackColor = Color.Transparent;
                    lNoReservations.Font = new Font("Arial", 12);
                    lNoReservations.Location = new Point(10, 40);
                    lNoReservations.Size = new Size(200, 200);
                    panel.Controls.Add(lNoReservations);
                }
            }
        }
        private void btnRemoveReservation_Click(Object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Reservation reservation = (Reservation)button.Tag;
            scene.RemoveReservation(reservation);
            this.LoadReservations();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
