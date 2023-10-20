
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
            this.Hide();
        }

        private void addhotel_click(object sender, EventArgs e)
        {
            AddHotel addHotelView = new AddHotel(admin);
            addHotelView.Show();
            this.Hide();
        }

        private void button_editviewhotel_Click(object sender, EventArgs e)
        {
            EditViewHotel editHotelView = new EditViewHotel(admin);
            editHotelView.Show();
            this.Hide();
        }

        private void button_addairline_Click(object sender, EventArgs e)
        {
            AddAirfare addAirfareView = new AddAirfare(admin);
            this.Hide();
            addAirfareView.Show();
        }
    }
}
