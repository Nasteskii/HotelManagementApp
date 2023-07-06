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
                lbHotelName.Text = scene.GetHotel().GetName();
                lbHotelName.Visible = true;
                btnSearch.Visible = true;
            }
            else
            {
                btnNewHotel.Visible = true;
                lbHotelName.Visible = false;
                btnSearch.Visible = false;
            }
            Invalidate();  
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
                scene.LogIn(logIn.Email, logIn.Password);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            fRegister register = new fRegister();
            DialogResult dialogResult = register.ShowDialog(this);
            if (dialogResult == DialogResult.OK)
            {
                scene.Register(register.FirstName, register.LastName, register.Email, register.Password);
            }
        }

        private void btnNewHotel_Click(object sender, EventArgs e)
        {
            fNewHotel newHotel = new fNewHotel();
            DialogResult dialogResult =  newHotel.ShowDialog(this);
            if (dialogResult == DialogResult.OK)
            {
                scene.NewHotel(newHotel.HotelName, newHotel.HotelLocation, (byte)newHotel.HotelStars);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
