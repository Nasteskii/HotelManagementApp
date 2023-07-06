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
    public partial class fLogIn : Form
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public fLogIn()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;
            DoubleBuffered = true;
        }

        private void btnSubmitHotel_Click(object sender, EventArgs e)
        {
            Email = tbEmail.Text;
            Password = tbPassword.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

       
    }
}
