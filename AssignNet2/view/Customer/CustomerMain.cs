using AssignNet2;
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
    public partial class CustomerMain : Form
    {
        Customer customer;
        public CustomerMain(Customer customer)
        {
            InitializeComponent();
            this.customer = customer;
            this.Show();
        }

        private void logout_click(object sender, EventArgs e)
        {
            Start start = new Start();
            start.Show();
            this.Close();
        }

        private void changedetails_click(object sender, EventArgs e)
        {
            ChangeAccountDetails customerChangeDetailsView = new ChangeAccountDetails(customer);
            customerChangeDetailsView.ShowDialog();
        }

        private void button_bookHotel_Click(object sender, EventArgs e)
        {
            SelectHotelToBook customerViewHotels = new SelectHotelToBook(customer);
            customerViewHotels.Show();
        }
    }
}
