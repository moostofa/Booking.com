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
                back();
            }
            catch
            {
                // MessageBox handled in deeoer level exception
            }
            
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            back();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                Hotel.FileManager.DeleteFromFile(hotel);
                back();
            }
            catch
            {
                // MessageBox handled in deeper level exception
            }

        }
    }
}
