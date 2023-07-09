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

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            Email = tbEmail.Text;
            Password = tbPassword.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider errorProvider = new ErrorProvider();
            if (ValidationUtil.EmailValidation(tbEmail.Text))
            {
                errorProvider.SetError(tbEmail, null);
                e.Cancel = false;
            }
            else
            {
                errorProvider.SetError(tbEmail, "Enter valid Email");
                e.Cancel = true;
            }
        }

        private void tbPassword_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider errorProvider = new ErrorProvider();
            if (ValidationUtil.PasswordValidation(tbPassword.Text))
            {
                errorProvider.SetError(tbPassword, null);
                e.Cancel = false;
            }
            else
            {
                errorProvider.SetError(tbPassword, "Password should contain minimum 6 characters, at least 1 number and 1 uppercase letter");
                e.Cancel = true;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
