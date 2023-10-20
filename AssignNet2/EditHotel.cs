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
    public partial class EditHotel : Form
    {
        ListBox hotelList;
        Form previousView;
        public EditHotel(Form prevView)
        {
            InitializeComponent();
            hotelList = listbox_hotellist;
            previousView = prevView;
            listHotels();
        }

        private void listHotels()
        {
            List<Hotel> hotels = HotelFileManager.getHotelList();

            foreach (Hotel hotel in hotels)
            {
                hotelList.Items.Add($"{hotel.Name}, {hotel.Location}");
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            previousView.Show();
        }

        private void button_view_Click(object sender, EventArgs e)
        {
            if (listbox_hotellist.SelectedItems[0] != null)
            {
                Hotel hotel = HotelFileManager.searchHotel(listbox_hotellist.SelectedItems[0].ToString());
                if (hotel != null)
                {
                    ViewHotel viewHotel = new ViewHotel(hotel);
                    viewHotel.ShowDialog();

                }
                else
                {
                    MessageBox.Show("cannot find hotel"); // split working incorrectly in HotelFileManager
                }
            }
        }

        private void button_editdetails_Click(object sender, EventArgs e)
        {

        }
    }
}
