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
    public partial class EditViewHotel : Form
    {
        Admin admin;
        public EditViewHotel(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;            
            listHotels();
        }

        private void back()
        {
            AdminView adminView = new AdminView(admin);
            adminView.Show();
            this.Hide();
        }

        private void listHotels()
        {
            List<Hotel> hotels = HotelFileManager.getHotelList();

            foreach (Hotel hotel in hotels)
            {
                lb_hotellist.Items.Add(hotel);
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            back();
        }

        private void button_view_Click(object sender, EventArgs e)
        {
            Hotel hotel = (Hotel)lb_hotellist.SelectedItem;
            if (hotel != null)
            {
                ViewHotelDetails viewHotel = new ViewHotelDetails(hotel);
                viewHotel.ShowDialog();
            }
        }

        private void button_editdetails_Click(object sender, EventArgs e)
        {
            Hotel hotel = (Hotel)lb_hotellist.SelectedItem;
            if (hotel != null)
            {
                EditDeleteHotelDetails editDeleteHotel = new EditDeleteHotelDetails(hotel, admin);
                editDeleteHotel.Show();
                this.Hide();
            }
        }
    }
}
