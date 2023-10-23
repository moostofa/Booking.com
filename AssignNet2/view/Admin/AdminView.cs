
using System;
using System.Windows.Forms;

namespace Booking.com
{
    public partial class AdminView : Form
    {
        Admin admin;
        public AdminView(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        private void logout_click(object sender, EventArgs e)
        {
            Start start = new Start();
            start.Show();
            this.Close();
        }

        private void addhotel_click(object sender, EventArgs e)
        {
            AddHotel addHotelView = new AddHotel(admin);
            addHotelView.Show();
            this.Close();
        }

        private void button_editviewhotel_Click(object sender, EventArgs e)
        {
            EditViewHotel editHotelView = new EditViewHotel(admin);
            editHotelView.Show();
            this.Close();
        }

        private void button_addairline_Click(object sender, EventArgs e)
        {
            AddAirfare addAirfareView = new AddAirfare(admin);
            this.Close();
            addAirfareView.Show();
        }

        private void button_registercustomer_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.ShowDialog();
        }

        private void button_searchcustomerbookings_Click(object sender, EventArgs e)
        {
            SearchCustomer searchCustomerView = new SearchCustomer();
            searchCustomerView.ShowDialog();
        }

        private void button_viewallcustomers_Click(object sender, EventArgs e)
        {
            ViewAllCustomers viewAllCustomers = new ViewAllCustomers(admin);
            viewAllCustomers.ShowDialog();
        }

        private void button_searchbookings_Click(object sender, EventArgs e)
        {

        }


    }
}
