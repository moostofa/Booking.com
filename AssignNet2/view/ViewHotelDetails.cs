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
    public partial class ViewHotelDetails : Form
    {
        Hotel hotel;
        public ViewHotelDetails(Hotel hotel)
        {
            InitializeComponent();
            this.hotel = hotel;
            showDetails();
        }

        private void showDetails()
        {
            text_name.Text = hotel.Name;
            text_location.Text = hotel.Location;
            text_pricepernight.Text = hotel.PricePerNight.ToString();
            text_id.Text = hotel.Id.ToString();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
