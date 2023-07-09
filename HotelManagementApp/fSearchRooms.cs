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
    public partial class fSearchRooms : Form
    {
        private Panel panel;
        public Scene scene;

        public fSearchRooms()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;
            DoubleBuffered = true;
        }

        private void fSearchRooms_Load(object sender, EventArgs e)
        {
            panel = new Panel();
            panel.Name = "pRooms";
            panel.AutoScroll = true;
            panel.Location = new Point(30, 30);
            panel.Size = new Size(360, 300);
            Controls.Add(panel);
            LoadRooms();
        }

        private void LoadRooms()
        {
            if (scene != null && scene.GetHotel() != null)
            {
                List<Room> rooms = scene.GetHotel().GetRooms();
                panel.Controls.Clear();
                if (rooms.Count != 0)
                {
                    int i = 0;
                    foreach (Room room in rooms)
                    {
                        Panel imagePanel = new Panel();
                        imagePanel.BackgroundImageLayout = ImageLayout.Zoom;
                        imagePanel.AutoScroll = false;
                        imagePanel.Name = "p" + room.GetNumber();
                        if (room.GetCapacity() == 1)
                        {
                            if (room.GetBedType() == BedTypes.Single)
                            {
                                imagePanel.BackgroundImage = Image.FromFile(Path.Combine("..", "..", "Data", "Images", "single_1.jpg"));
                            }
                            else
                            {
                                imagePanel.BackgroundImage = Image.FromFile(Path.Combine("..", "..", "Data", "Images", "double_1.jpg"));
                            }
                        }
                        else if (room.GetCapacity() == 2)
                        {
                            if (room.GetBedType() == BedTypes.Single)
                            {
                                imagePanel.BackgroundImage = Image.FromFile(Path.Combine("..", "..", "Data", "Images", "single_2.jpg"));
                            }
                            else
                            {
                                imagePanel.BackgroundImage = Image.FromFile(Path.Combine("..", "..", "Data", "Images", "double_1.jpg"));
                            }
                        }
                        else if (room.GetCapacity() == 3)
                        {

                            if (room.GetBedType() == BedTypes.Single)
                            {
                                imagePanel.BackgroundImage = Image.FromFile(Path.Combine("..", "..", "Data", "Images", "single_3.jpg"));
                            }
                            else
                            {
                                imagePanel.BackgroundImage = Image.FromFile(Path.Combine("..", "..", "Data", "Images", "double_2.jpg"));
                            }
                        }
                        else
                        {
                            if (room.GetBedType() == BedTypes.Single)
                            {
                                imagePanel.BackgroundImage = Image.FromFile(Path.Combine("..", "..", "Data", "Images", "single_4.jpg"));
                            }
                            else
                            {
                                imagePanel.BackgroundImage = Image.FromFile(Path.Combine("..", "..", "Data", "Images", "double_2.jpg"));
                            }
                        }

                        Label lNumber = new Label();
                        lNumber.Text = "Room: " + room.GetNumber().ToString();
                        lNumber.BackColor = Color.Transparent;
                        lNumber.Font = new Font("Arial", 10);

                        Label lBedType = new Label();
                        lBedType.Text = "Bed Type: " + room.GetBedType().ToString();
                        lBedType.BackColor = Color.Transparent;
                        lBedType.Font = new Font("Arial", 10);

                        Label lCapacity = new Label();
                        lCapacity.Text = "Capacity: " + room.GetCapacity().ToString();
                        lCapacity.BackColor = Color.Transparent;
                        lCapacity.Font = new Font("Arial", 10);

                        Label lSeaView = new Label();
                        lSeaView.Text = "Sea view? " + (room.HasSeaView() ? "-Yes" : "-No");
                        lSeaView.BackColor = Color.Transparent;
                        lSeaView.Font = new Font("Arial", 10);

                        Button btnBookRoom = new Button();
                        btnBookRoom.Name = "btnBookRoom" + room.GetNumber();
                        btnBookRoom.Text = "Book";
                        btnBookRoom.FlatStyle = FlatStyle.Popup;
                        btnBookRoom.Click += btnBookRoom_Click;
                        btnBookRoom.Tag = room;

                        GroupBox groupBox = new GroupBox();
                        groupBox.Name = "gbRoom" + room.GetNumber();
                        groupBox.Text = "Room" + room.GetNumber();
                        groupBox.Location = new Point(10, 10 + (i * 160));
                        groupBox.Size = new Size(330, 160);
                        groupBox.Controls.Add(imagePanel);
                        groupBox.Controls.Add(lNumber);
                        groupBox.Controls.Add(lBedType);
                        groupBox.Controls.Add(lCapacity);
                        groupBox.Controls.Add(lSeaView);
                        groupBox.Controls.Add(btnBookRoom);

                        imagePanel.Location = new Point(10, 15);
                        imagePanel.Size = new Size(145, 135);

                        lNumber.Location = new Point(165, 20);
                        lNumber.Size = new Size(120, 15);

                        lBedType.Location = new Point(165, 40);
                        lBedType.Size = new Size(125, 15);

                        lCapacity.Location = new Point(165, 60);
                        lCapacity.Size = new Size(120, 15);

                        lSeaView.Location = new Point(165, 80);
                        lSeaView.Size = new Size(120, 15);

                        btnBookRoom.Location = new Point(245, 115);
                        btnBookRoom.Size = new Size(75, 25);

                        panel.Controls.Add(groupBox);
                        i++;
                    }
                }
                else
                {
                    Label lNoRooms = new Label();
                    lNoRooms.Text = "There are no rooms available!";
                    lNoRooms.BackColor = Color.Transparent;
                    lNoRooms.Font = new Font("Arial", 12);
                    lNoRooms.Location = new Point(10, 40);
                    lNoRooms.Size = new Size(300, 200);
                    panel.Controls.Add(lNoRooms);
                }
            }
        }

        private void btnBookRoom_Click(Object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Room room = (Room)button.Tag;

            fMakeReservation makeReservation = new fMakeReservation();
            DialogResult dialogResult = makeReservation.ShowDialog(this);
            if (dialogResult == DialogResult.OK)
            {
                if (CheckReservation(makeReservation, room))
                {
                    scene.MakeReservation(new User(makeReservation.UserEmail, makeReservation.UserFirstName, makeReservation.UserLastName),
                        room.GetNumber(), makeReservation.Guests, makeReservation.CheckInDate, makeReservation.CheckOutDate);
                }
                else
                {
                    MessageBox.Show("There is already reservation in that periot");
                }

            }
            this.LoadRooms();
        }

        private bool CheckReservation(fMakeReservation makeReservation, Room room)
        {
            bool status = true;
            if (scene.GetReservations().Count > 0)
            {
                foreach (Reservation reservation in scene.GetReservations())
                {
                    if (reservation.GetRoomNumber() == room.GetNumber() && (makeReservation.CheckInDate >= reservation.GetCheckInDate() && makeReservation.CheckInDate <= reservation.GetCheckOutDate() ||
                        makeReservation.CheckOutDate >= reservation.GetCheckInDate() && makeReservation.CheckOutDate <= reservation.GetCheckOutDate() || makeReservation.CheckInDate < reservation.GetCheckInDate() && makeReservation.CheckOutDate > reservation.GetCheckOutDate()))
                    {
                        status = false;
                        break;
                    }
                }
            }
            return status;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
