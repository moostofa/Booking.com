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
    public partial class AddAirfare : Form
    {
        Admin admin;
        public AddAirfare(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        private void back()
        {
            this.Close();
            AdminView adminView = new AdminView(admin);
            adminView.Show();
        }

        private void button_addairfare_Click(object sender, EventArgs e)
        {
            string name = tb_airlinename.Text;
            string location = tb_location.Text;
            string destination = tb_destination.Text;
            string price = tb_price.Text;
            string[] properties = new string[] { name, location, destination, price };
            bool airfareAdded = AirfareFileManager.addAirfare(properties);
            if (airfareAdded)
            {
                back();
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            back();
        }

        private void tb_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains('.'))
            {
                e.Handled = true;
            }
        }
    }
}
