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

            string[] properties = new string[] {email, password, firstName, lastName, phone, streetAddress, suburb, postcode, cb_state.SelectedText};
            bool userAdded = UserFileManager.addUser(properties);

            if (userAdded)
            {
                MessageBox.Show("Successfully added User. Welcome, " + firstName);
                this.Close();
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
            this.Close();
        }
    }
}
