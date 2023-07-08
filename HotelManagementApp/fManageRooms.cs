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
    public partial class fManageRooms : Form
    {
        public Scene scene { get; set; }
        private Panel panel;
        public fManageRooms()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;
            DoubleBuffered = true;
        }

        private void fManageRooms_Load(object sender, EventArgs e)
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
            if (scene != null)
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

                        Button btnEditRoom = new Button();
                        btnEditRoom.Name = "btnEditRoom" + room.GetNumber();
                        btnEditRoom.Text = "Edit";
                        btnEditRoom.FlatStyle = FlatStyle.Popup;
                        btnEditRoom.Click += btnEditRoom_Click;
                        btnEditRoom.Tag = room;

                        Button btnRemoveRoom = new Button();
                        btnEditRoom.Name = "btnDeleteRoom" + room.GetNumber();
                        btnRemoveRoom.Text = "Remove";
                        btnRemoveRoom.FlatStyle = FlatStyle.Popup;
                        btnRemoveRoom.Click += btnRemoveRoom_Click;
                        btnRemoveRoom.Tag = room;

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
                        groupBox.Controls.Add(btnEditRoom);
                        groupBox.Controls.Add(btnRemoveRoom);

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

                        btnEditRoom.Location = new Point(165, 115);
                        btnEditRoom.Size = new Size(75, 25);

                        btnRemoveRoom.Location = new Point(245, 115);
                        btnRemoveRoom.Size = new Size(75, 25);

                        panel.Controls.Add(groupBox);
                        i++;
                    }
                }
                else
                {
                    Label lNoRooms = new Label();
                    lNoRooms.Text = "There are no rooms!";
                    lNoRooms.BackColor = Color.Transparent;
                    lNoRooms.Font = new Font("Arial", 12);
                    lNoRooms.Location = new Point(10, 40);
                    lNoRooms.Size = new Size(200, 200);
                    panel.Controls.Add(lNoRooms);
                }
            }
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            if (scene.HasHotel() && scene.HasAdmin() && scene.GetAdmin().IsAuthenticated())
            {
                fAddRoom addRoom = new fAddRoom();
                DialogResult dialogResult = addRoom.ShowDialog(this);
                if (dialogResult == DialogResult.OK)
                {
                    Hotel hotel = scene.GetHotel();
                    hotel.AddRoom(new Room(addRoom.Number, addRoom.BedType, addRoom.Capacity, addRoom.SeaView));

                    using (FileStream fileStream = new FileStream(Path.Combine("..", "..", "Data", "hotel.bin"), FileMode.Create))
                    {
                        IFormatter formatter = new BinaryFormatter();
                        formatter.Serialize(fileStream, hotel);
                    }
                }
            }
            this.LoadRooms();
        }

        private void btnEditRoom_Click(Object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Room room = (Room)button.Tag;

            fAddRoom editRoom = new fAddRoom();
            editRoom.Number = room.GetNumber();
            editRoom.BedType = room.GetBedType();
            editRoom.Capacity = room.GetCapacity();
            editRoom.SeaView = room.HasSeaView();
            editRoom.LoadFields();

            DialogResult dialogResult = editRoom.ShowDialog(this);
            if (dialogResult == DialogResult.OK)
            {
                Hotel hotel = scene.GetHotel();
                hotel.RemoveRoom(room);
                hotel.AddRoom(new Room(editRoom.Number, editRoom.BedType, editRoom.Capacity, editRoom.SeaView));

                using (FileStream fileStream = new FileStream(Path.Combine("..", "..", "Data", "hotel.bin"), FileMode.Create))
                {
                    IFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fileStream, hotel);
                }
            }
            this.LoadRooms();
        }

        private void btnRemoveRoom_Click(Object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Room room = (Room)button.Tag;
            Hotel hotel = scene.GetHotel();
            hotel.RemoveRoom(room);
            using (FileStream fileStream = new FileStream(Path.Combine("..", "..", "Data", "hotel.bin"), FileMode.Create))
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fileStream, hotel);
            }
            this.LoadRooms();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
