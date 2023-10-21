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
        Customer customer;
        public CustomerView(Customer customer)
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
            CustomerChangeDetails customerChangeDetailsView = new CustomerChangeDetails(customer);
            customerChangeDetailsView.ShowDialog();
        }
    }
}
