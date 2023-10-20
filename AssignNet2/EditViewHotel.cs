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
        ListBox hotelList;
        Admin admin;
        public EditViewHotel(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;            
            hotelList = listbox_hotellist;
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
            AdminView adminView = new AdminView(admin);
            adminView.Show();
            this.Hide();
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
            if (listbox_hotellist.SelectedItems[0] != null)
            {
                Hotel hotel = HotelFileManager.searchHotel(listbox_hotellist.SelectedItems[0].ToString());
                if (hotel != null)
                {
                    EditDeleteHotelDetails editDeleteHotel = new EditDeleteHotelDetails(hotel, admin);
                    editDeleteHotel.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("cannot find hotel"); // split working incorrectly in HotelFileManager
                }
            }

        }
    }
}
