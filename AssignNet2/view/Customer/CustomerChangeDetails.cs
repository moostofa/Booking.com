using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booking.com
{
    public partial class CustomerChangeDetails : Form
    {
        Customer customer;
        public CustomerChangeDetails(Customer customer)
        {
            InitializeComponent();
            this.customer = customer;

            tb_email.Text = customer.Email;
            tb_password.Text = customer.Password;
            tb_firstname.Text = customer.FirstName;
            tb_lastname.Text = customer.LastName;
            tb_phonenumber.Text = customer.Phone;
            tb_address.Text = customer.Address;
        }

        private void changedetails_click(object sender, EventArgs e)
        {
            Dictionary<string, string> properties = new Dictionary<string, string>
            {
                { "Email", tb_email.Text },
                { "Password", tb_password.Text },
                { "FirstName", tb_firstname.Text },
                { "LastName", tb_lastname.Text },
                { "Phone", tb_phonenumber.Text },
                { "Address", tb_address.Text }
            };
            bool detailsChanged = customer.changeAccountDetails(properties);
            if (detailsChanged)
            {
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
            this.Hide();
        }
    }
}
