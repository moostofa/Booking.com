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
    public partial class ViewHotel : Form
    {
        Hotel hotel;
        public ViewHotel(Hotel hotel)
        {
            InitializeComponent();
            this.hotel = hotel;
            DisplayHotelDetails();
        }

        private void DisplayHotelDetails()
        {
            text_name.Text = hotel.Name;
            text_location.Text = hotel.Location;
            text_pricepernight.Text = hotel.PricePerNight.ToString("C2");
            text_id.Text = hotel.Id.ToString();
            text_floors.Text = hotel.NumberOfFloors.ToString();
            text_amenities.Text = string.Join(", ", hotel.AvailableAmenities);
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
