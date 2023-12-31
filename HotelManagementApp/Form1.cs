﻿using Microsoft.Win32;
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
    public partial class Form1 : Form
    {
        public Scene scene;

        public Form1()
        {
            InitializeComponent();
            scene = new Scene();
            this.BackgroundImageLayout = ImageLayout.Stretch;
            DoubleBuffered = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (scene.HasHotel())
            {
                btnNewHotel.Visible = false;
                btnEditHotel.Visible = true;
                lbHotelName.Text = scene.GetHotel().GetName();
                lbHotelName.Visible = true;
                btnSearch.Visible = true;
            }
            else
            {
                btnEditHotel.Visible = true;
                btnNewHotel.Visible = true;
                lbHotelName.Visible = false;
                btnSearch.Visible = false;
            }
            if (scene.HasAdmin())
            {
                btnRegister.Visible = false;
                if (scene.GetAdmin().IsAuthenticated()) 
                {
                    btnEditHotel.Visible = true;
                    btnSearch.Visible = false;
                    btnLogIn.Visible = false;
                    btnRooms.Visible = true;
                    btnReservations.Visible = true;
                    btnLogOut.Visible = true;
                }
                else
                {
                    btnEditHotel.Visible = false;
                    btnSearch.Visible = true;
                    btnLogIn.Visible = true;
                    btnRooms.Visible = false;
                    btnReservations.Visible = false;
                    btnLogOut.Visible = false;
                }

            }
            else
            {
                btnSearch.Visible = true;
                btnLogIn.Visible = true;
                btnRegister.Visible = true;
                btnRooms.Visible = false;
                btnReservations.Visible = false;
                btnLogOut.Visible = false;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // scene.Draw(lbHotelName.Location, e.Graphics);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            fLogIn logIn = new fLogIn();
            DialogResult dialogResult = logIn.ShowDialog(this);
            if (dialogResult == DialogResult.OK)
            {
                if (!scene.LogIn(logIn.Email, logIn.Password))
                {
                    MessageBox.Show("Incorrect Email or Password!");
                }
            }
            this.Form1_Load(sender, e);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            fRegister register = new fRegister();
            DialogResult dialogResult = register.ShowDialog(this);
            if (dialogResult == DialogResult.OK)
            {
                scene.Register(register.FirstName, register.LastName, register.Email, register.Password);
            }
            this.Form1_Load(sender, e);
        }

        private void btnNewHotel_Click(object sender, EventArgs e)
        {
            if (scene.HasAdmin())
            {
                if (scene.GetAdmin().IsAuthenticated())
                {
                    fNewHotel newHotel = new fNewHotel();
                    DialogResult dialogResult = newHotel.ShowDialog(this);
                    if (dialogResult == DialogResult.OK)
                    {
                        scene.NewHotel(newHotel.HotelName, newHotel.HotelLocation, (byte)newHotel.HotelStars);
                    }
                }
                else
                {
                    MessageBox.Show("Please Log In");
                }
            }
            else
            {
                MessageBox.Show("No registered admin!");
            }
            this.Form1_Load(sender, e);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            scene.LogOut();
            this.Form1_Load(sender, e);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (scene.GetHotel() != null)
            {
                fSearchRooms searchRooms = new fSearchRooms();
                searchRooms.scene = scene;
                DialogResult dialogResult = searchRooms.ShowDialog(this);
            }
            else 
            {
                MessageBox.Show("No hotel!");
            }

        }

        private void btnEditHotel_Click(object sender, EventArgs e)
        {
            if (scene.HasHotel())
            {
                if (scene.HasAdmin())
                {
                    if (scene.GetAdmin().IsAuthenticated())
                    {
                        fNewHotel editHotel = new fNewHotel();
                        editHotel.Text = "Edit Hotel";
                        editHotel.HotelName = scene.GetHotel().GetName();
                        editHotel.HotelLocation = scene.GetHotel().GetLocation();
                        editHotel.HotelStars = scene.GetHotel().GetStars();
                        editHotel.LoadFields();

                        DialogResult dialogResult = editHotel.ShowDialog(this);
                        if (dialogResult == DialogResult.OK)
                        {
                            scene.NewHotel(editHotel.HotelName, editHotel.HotelLocation, (byte)editHotel.HotelStars);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Log In");
                    }
                }
                else
                {
                    MessageBox.Show("No registered admin!");
                }
            }
            else
            {
                MessageBox.Show("No hotel!");
            }
            this.Form1_Load(sender, e);
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            if (scene.HasHotel() && scene.HasAdmin() && scene.GetAdmin().IsAuthenticated())
            {
                if (scene.HasAdmin())
                {
                    if (scene.GetAdmin().IsAuthenticated())
                    {
                        fManageRooms manageRooms = new fManageRooms();
                        manageRooms.scene = scene;

                        DialogResult dialogResult = manageRooms.ShowDialog(this);
                    }
                    else
                    {
                        MessageBox.Show("Please Log In");
                    }
                }
                else
                {
                    MessageBox.Show("No registered admin!");
                }
            }
            else
            {
                MessageBox.Show("No hotel!");

            }
        }

        private void btnReservations_Click(object sender, EventArgs e)
        {
            if (scene.HasHotel() && scene.HasAdmin() && scene.GetAdmin().IsAuthenticated())
            {
                if (scene.HasAdmin())
                {
                    if (scene.GetAdmin().IsAuthenticated())
                    {
                        fReservations reservations = new fReservations();
                        reservations.scene = scene;

                        DialogResult dialogResult = reservations.ShowDialog(this);
                    }
                    else
                    {
                        MessageBox.Show("Please Log In");
                    }
                }
                else
                {
                    MessageBox.Show("No registered admin!");
                }
            }
            else
            {
                MessageBox.Show("No hotel!");

            }
        }
    }

}
