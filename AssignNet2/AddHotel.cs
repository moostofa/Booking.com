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
    public partial class AddHotel : Form
    {
        AdminView adminView;
        Admin admin;
        public AddHotel(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
            adminView = new AdminView(admin);
        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            string name = tb_name.Text;
            string location = tb_location.Text;
            double pricePerNight;

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter a valid hotel name");
            }
            else if (string.IsNullOrEmpty(tb_location.Text))
            {
                MessageBox.Show("Please enter a valid location");
            }
            else if (string.IsNullOrEmpty(tb_price.Text))
            {
                MessageBox.Show("Please enter a valid price per night");
            }
            else
            {
                try
                {
                    pricePerNight = double.Parse(tb_price.Text);
                    HotelFileManager.addHotel(name, location, pricePerNight);
                    MessageBox.Show("Hotel Added Successfully");
                    this.Hide();
                    adminView.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void tb_price_keypress(object sender, KeyPressEventArgs e)
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

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminView.Show();
        }
    }
}
