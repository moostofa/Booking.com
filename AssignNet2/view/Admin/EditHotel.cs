using System;
using System.Collections;
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
    public partial class EditHotel : Form
    {
        Hotel hotel;
        Admin admin;
        public EditHotel(Hotel hotel, Admin admin)
        {
            InitializeComponent();
            this.hotel = hotel;
            this.admin = admin;
            DisplayHotelDetails();

        }

        private void DisplayHotelDetails()
        {
            tb_name.Text = hotel.Name;
            tb_location.Text = hotel.Location;
            string price = hotel.PricePerNight.ToString();
            tb_price.Text = price;
        }

        private void ReturnToPreviousForm()
        {
            ViewAllHotels viewHotelsView = new ViewAllHotels(admin);
            viewHotelsView.Show();
            this.Close();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> properties = new Dictionary<string, string>
            {
                { "Name", tb_name.Text },
                { "Location", tb_location.Text },
                { "Price", tb_price.Text }
            };

            try
            {
                Hotel.FileManager.UpdateDetails(hotel, properties);
                ReturnToPreviousForm();
            }
            catch
            {
                // no need to do anything here. any MessageBox errors to do with updating are handled in a deeper level exception. allow the user to try again.
            }

        }

        private void button_back_Click(object sender, EventArgs e)
        {
            ReturnToPreviousForm();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                Hotel.FileManager.DeleteEntity(hotel);
                ReturnToPreviousForm();
            }
            catch
            {
                // no need to do anything here. any MessageBox errors to do with deleting are handled in a deeper level exception. allow the user to try again.
            }

        }
    }
}
