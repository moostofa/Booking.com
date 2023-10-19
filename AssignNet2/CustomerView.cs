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
    public partial class CustomerView : Form
    {
        Start start;
        Customer customer;
        public CustomerView(Customer customer, Start start)
        {
            InitializeComponent();
            this.start = start;
            this.customer = customer;
            this.Show();
        }

        private void logout_click(object sender, EventArgs e)
        {
            start.Show();
            this.Close();
        }

        private void changedetails_click(object sender, EventArgs e)
        {
            CustomerChangeDetailsView customerChangeDetailsView = new CustomerChangeDetailsView(customer);
            customerChangeDetailsView.ShowDialog();
        }
    }
}
