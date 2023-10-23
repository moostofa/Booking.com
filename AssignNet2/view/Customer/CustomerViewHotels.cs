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
    public partial class CustomerViewHotels : Form
    {
        Customer customer;
        public CustomerViewHotels(Customer customer)
        {
            InitializeComponent();
            this.customer = customer;
            listHotels();
        }

        private void back()
        {
            CustomerView customerView = new CustomerView(customer);
            this.Close();
        }

        private void listHotels()
        {
            List<Hotel> hotels = Hotel.FileManager.GetListOfEntities();

            foreach (Hotel hotel in hotels)
            {
                lb_hotellist.Items.Add(hotel);
            }
        }

        private void button_book_Click(object sender, EventArgs e)
        {
            if (lb_hotellist.SelectedItems[0] != null)
            {
                BookHotel bookHotel = new BookHotel(customer, (Hotel)lb_hotellist.SelectedItems[0]);
                bookHotel.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a hotel from the list");
            }
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            back();
        }

        private void button_view_Click(object sender, EventArgs e)
        {
            if (lb_hotellist.SelectedItems[0] != null)
            {
                ViewHotelDetails viewHotelDetails = new ViewHotelDetails((Hotel)lb_hotellist.SelectedItems[0]);
                viewHotelDetails.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a hotel from the list");
            }
        }
    }
}
