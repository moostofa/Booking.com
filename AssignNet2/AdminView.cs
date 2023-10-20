using AssignNet2.model;
using System;
using System.Windows.Forms;

namespace Booking.com
{
    public partial class AdminView : Form
    {
        Admin admin;
        Start start;

        public AdminView(Admin admin, Start start)
        {
            InitializeComponent();
            this.admin = admin;
            this.start = start;
            this.Show();
        }

        private void logout_click(object sender, EventArgs e)
        {
            start.Show();
            this.Hide();
        }

        private void addhotel_click(object sender, EventArgs e)
        {
            AddHotel addHotelView = new AddHotel(this);
            addHotelView.Show();
            this.Hide();
        }

        private void button_editviewhotel_Click(object sender, EventArgs e)
        {
            EditHotel editHotelView = new EditHotel(this);
            editHotelView.Show();
            this.Hide();
        }
    }
}
