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
    public partial class ViewBookings : Form
    {
        Admin admin;
        public ViewBookings(Admin admin)
        {
            InitializeComponent();
        }

        public void ReturnToPreviousForm()
        {
            AdminMain adminView = new AdminMain(admin);
            adminView.Show();
            this.Close();
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            Start start = new Start();
            start.Show();
            this.Close();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            ReturnToPreviousForm();
        }


    }
}
