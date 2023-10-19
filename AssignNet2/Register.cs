using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booking.com
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            cb_state.Items.Add("ACT");
            cb_state.Items.Add("NSW");
            cb_state.Items.Add("NT");
            cb_state.Items.Add("SA");
            cb_state.Items.Add("TAS");
            cb_state.Items.Add("QLD");
            cb_state.Items.Add("VIC");
            cb_state.Items.Add("WA");
        }

        private void register_click(object sender, EventArgs e)
        {
            string email = tb_email.Text;
            string password = tb_password.Text;
            string firstName = tb_firstname.Text;
            string lastName = tb_lastname.Text;
            string phone = tb_phonenumber.Text;
            string streetAddress = tb_streetaddress.Text;
            string suburb = tb_suburb.Text;
            string postcode = tb_postcode.Text;

            if (string.IsNullOrEmpty(email) || !email.Contains('@'))
            {
                label_errormessage.Text = "Please enter a valid email address";
            }
            else if (string.IsNullOrEmpty(password) || password.Count() < 8)
            {
                label_errormessage.Text = "Please enter a valid password (at least 8 characters)";
            }
            else if (string.IsNullOrEmpty(firstName))
            {
                label_errormessage.Text = "Please enter a First Name";
            }
            else if (string.IsNullOrEmpty(lastName))
            {
                label_errormessage.Text = "Please enter a Last Name";
            }
            else if (string.IsNullOrEmpty(phone) || phone.Count() < 8)
            {
                label_errormessage.Text = "Please enter a valid phone number (at least 8 digits)";
            }
            else if (string.IsNullOrEmpty(streetAddress))
            {
                label_errormessage.Text = "Please enter a valid Street Address";
            }
            else if (string.IsNullOrEmpty(suburb))
            {
                label_errormessage.Text = "Please enter a valid suburb";
            }
            else if (string.IsNullOrEmpty(postcode) || postcode.Count() < 4)
            {
                label_errormessage.Text = "Please enter a valid Postcode";
            }
            else if (cb_state.SelectedItem == null)
            {
                label_errormessage.Text = "Please select a State or Territory";
            }
            else
            {
                String address = tb_streetaddress.Text + " " + tb_suburb.Text + " " + tb_postcode.Text + " " + cb_state.SelectedItem.ToString();
                User customer = new Customer(email, password, firstName, lastName, phone, address);
                UserFileManager.addUser(customer);
                MessageBox.Show("Successfully added User. Welcome, " + firstName);
                this.Hide();
            }
        }

        private void phone_keypress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void postcode_keypress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cancel_click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
