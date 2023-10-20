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

        private void button_addairfare_Click(object sender, EventArgs e)
        {
            string name = tb_airlinename.Text;
            string location = tb_location.Text;
            string destination = tb_destination.Text;
            string price = tb_price.Text;

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter a valid Airline name");
            }
            else if (string.IsNullOrEmpty(location))
            {
                MessageBox.Show("Please enter a valid location");
            }
            else if (string.IsNullOrEmpty(destination))
            {
                MessageBox.Show("Please enter a valid destination");
            }
            else if (string.IsNullOrEmpty(price))
            {
                MessageBox.Show("Please enter a valid price");
            }
            else
            {
                try
                {
                    double priceperticket = double.Parse(price);
                    AirfareFileManager.addAirfare(name, location, destination, priceperticket);       
                    MessageBox.Show("Airfare Added Successfully");
                    this.Hide();
                    AdminView adminview = new AdminView(admin);
                    adminview.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminView adminView = new AdminView(admin);
            adminView.Show();
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
