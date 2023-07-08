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
                if (reservations != null)
                {
                    int i = 0;
                    foreach (Reservation reservation in reservations)
                    {
                        Label lUserEmail = new Label();
                        lUserEmail.Text = "User Email: " + reservation.GetReservationUser().GetEmail();
                        lUserEmail.BackColor = Color.Transparent;
                        lUserEmail.Font = new Font("Arial", 10);

                        Label lNumber = new Label();
                        lNumber.Text = "Room: " + reservation.GetRoomNumber().ToString();
                        lNumber.BackColor = Color.Transparent;
                        lNumber.Font = new Font("Arial", 10);

                        DateTimePicker dtpCheckInDate = new DateTimePicker();
                        dtpCheckInDate.Value = reservation.GetCheckInDate();

                        DateTimePicker dtpCheckOutDate = new DateTimePicker();
                        dtpCheckOutDate.Value = reservation.GetCheckOutDate();

                        Button btnRemoveReservation = new Button();
                        btnRemoveReservation.Name = "btnRemoveReservation" + i;
                        btnRemoveReservation.Text = "Remove";
                        btnRemoveReservation.FlatStyle = FlatStyle.Popup;
                        btnRemoveReservation.Click += btnRemoveReservation_Click;
                        btnRemoveReservation.Tag = reservation;

                        GroupBox groupBox = new GroupBox();
                        groupBox.Name = "gbReservation" + i;
                        groupBox.Text = "Reservation" + i;
                        groupBox.Location = new Point(10, 10 + (i * 160));
                        groupBox.Size = new Size(330, 160);
                        groupBox.Controls.Add(lNumber);
                        groupBox.Controls.Add(lUserEmail);
                        groupBox.Controls.Add(lNumber);
                        groupBox.Controls.Add(dtpCheckInDate);
                        groupBox.Controls.Add(dtpCheckOutDate);

                        lNumber.Location = new Point(165, 20);
                        lNumber.Size = new Size(120, 15);

                        lUserEmail.Location = new Point(165, 40);
                        lUserEmail.Size = new Size(125, 15);

                        dtpCheckInDate.Location = new Point(165, 60);
                        dtpCheckInDate.Size = new Size(120, 15);

                        dtpCheckOutDate.Location = new Point(165, 80);
                        dtpCheckOutDate.Size = new Size(120, 15);

                        btnRemoveReservation.Location = new Point(245, 115);
                        btnRemoveReservation.Size = new Size(75, 25);

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
            LoadReservations();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
