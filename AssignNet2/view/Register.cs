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
            Dictionary<string, string> properties = new Dictionary<string, string>
            {
                {"Email", tb_email.Text },
                {"Password", tb_password.Text },
                {"FirstName", tb_firstname.Text },
                {"LastName", tb_lastname.Text},
                {"Phone", tb_phonenumber.Text },
                {"StreetAddress", tb_streetaddress.Text },
                {"Suburb", tb_suburb.Text },
                {"Postcode", tb_postcode.Text },
                {"State", cb_state.SelectedItem.ToString() }
            };
            try
            {
                User.FileManager.AddNewEntity(properties);
                MessageBox.Show("Successfully added User. Welcome, " + properties["FirstName"]);
                this.Close();
            }
            catch
            {
                // MessageBox handled in deeper exception level
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
