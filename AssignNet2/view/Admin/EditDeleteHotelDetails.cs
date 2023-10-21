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
            fillDetails();
            this.admin = admin;
        }

        public void fillDetails()
        {
            tb_name.Text = hotel.Name;
            tb_location.Text = hotel.Location;
            string price = hotel.PricePerNight.ToString();
            tb_pricepernight.Text = price;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            string name = tb_name.Text;
            string location = tb_location.Text;
            string price = tb_pricepernight.Text;

            if (string.IsNullOrEmpty(name) )
            {
                MessageBox.Show("Please enter a valid name");
            }
            else if (string.IsNullOrEmpty(location) )
            {
                MessageBox.Show("Please enter a valid location");
            }
            else if (string.IsNullOrEmpty(price) )
            {
                MessageBox.Show("Please enter a valid price");
            }
            else
            {
                try
                {
                    double pricePerNight = double.Parse(price);
                    ArrayList properties = new ArrayList { name, location, pricePerNight };
                    HotelFileManager.UpdateHotelDetails(hotel, properties);
                    this.Hide();
                    EditViewHotel editViewHotel = new EditViewHotel(admin);
                    editViewHotel.Show();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            EditViewHotel editViewHotel = new EditViewHotel(admin);
            editViewHotel.Show();
            this.Hide();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            HotelFileManager.deleteHotel(hotel);
            this.Hide();
            EditViewHotel editViewHotel = new EditViewHotel(admin);
            editViewHotel.Show();
        }
    }
}
