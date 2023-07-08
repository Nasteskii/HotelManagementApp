﻿using System;
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
    public partial class fRegister : Form
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public fRegister()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;
            DoubleBuffered = true;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FirstName = tbFirstName.Text;
            LastName = tbLastName.Text;
            Email = tbEmail.Text;
            Password = tbPassword.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
