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
    public partial class EditDeleteHotelDetails : Form
    {
        Hotel hotel;
        Admin admin;
        public EditDeleteHotelDetails(Hotel hotel, Admin admin)
        {
            InitializeComponent();
            this.hotel = hotel;
            this.admin = admin;
            fillDetails();
            
        }

        private void fillDetails()
        {
            tb_name.Text = hotel.Name;
            tb_location.Text = hotel.Location;
            string price = hotel.PricePerNight.ToString();
            tb_price.Text = price;
        }

        private void back()
        {
            EditViewHotel editViewHotel = new EditViewHotel(admin);
            editViewHotel.Show();
            this.Hide();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            string name = tb_name.Text;
            string location = tb_location.Text;
            string price = tb_price.Text;

            string[] properties = new string[] { name, location, price };
            bool hotelUpdated = HotelFileManager.UpdateHotelDetails(hotel, properties);
            if (hotelUpdated)
            {
                back();
            }
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            back();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            bool hotelDeleted = HotelFileManager.deleteHotel(hotel);
            if (hotelDeleted)
            {
                back();
            }
        }
    }
}
