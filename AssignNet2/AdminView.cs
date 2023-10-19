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
    }
}
