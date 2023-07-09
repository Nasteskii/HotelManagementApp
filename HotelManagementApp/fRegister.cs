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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbFirstName_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider errorProvider = new ErrorProvider();
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
            ErrorProvider errorProvider = new ErrorProvider();
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
                errorProvider.SetError(tbEmail, "Enter correct Email");
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
    }
}
