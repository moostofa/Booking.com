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
    public partial class BookHotel : Form
    {
        Customer customer;
        Hotel hotel;

        public BookHotel(Customer customer, Hotel hotel)
        {
            InitializeComponent();
            this.customer = customer;
            this.hotel = hotel;
            fillDetails();
        }

        private void back()
        {
            CustomerViewHotels customerViewHotels = new CustomerViewHotels(customer);
            customerViewHotels.Show();
            this.Close();
        }

        private void fillDetails()
        {
            text_bookhotel.Text = "Book Hotel : " + hotel;
        }

        private void button_confirm_Click(object sender, EventArgs e)
        {
            Hashtable properties = new Hashtable()
            {
                {"Email", customer.Email },
                {"CheckIn", dtp_checkin.Value },
                {"CheckOut", dtp_checkout.Value },
                {"CompanyId", hotel.Id }
            };
            bool bookingSuccess = BookingsManager.createBooking(properties);
            if (bookingSuccess)
            {
                MessageBox.Show("Booking Successful");
                back();
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            back();
        }

        private void dtp_checkin_value_changed(object sender, EventArgs e)
        {
            if (dtp_checkin.Value < dtp_checkout.Value)
            {
                updatePriceAndNights();
            }
        }

        private void dtp_checkout_value_changed(object sender, EventArgs e)
        {
            if (dtp_checkin.Value < dtp_checkout.Value)
            {
                updatePriceAndNights();
            }
        }

        private void updatePriceAndNights()
        {
            int nights = BookingsManager.calculateNights(dtp_checkin.Value, dtp_checkout.Value);
            text_nights.Text = nights.ToString();
            text_price.Text = (nights * hotel.PricePerNight).ToString("F2");
        }
    }
}
