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
    public partial class ViewAllCustomers : Form
    {
        Admin admin;
        public ViewAllCustomers(Admin admin)
        {
            InitializeComponent();
            listCustomers();
            this.admin = admin;
        }

        private void listCustomers()
        {
            List<Customer> customers = UserFileManager.getCustomersList();
            foreach (Customer customer in customers)
            {
                lb_customers.Items.Add(customer);
            }
        }

        private void button_viewdetails_Click(object sender, EventArgs e)
        {
            Customer customer = (Customer)lb_customers.SelectedItem;
            ViewCustomer viewCustomerWindow = new ViewCustomer(customer);
            viewCustomerWindow.ShowDialog();
        }

        private void button_editdeletecustomer_Click(object sender, EventArgs e)
        {
            Customer customer = (Customer)lb_customers.SelectedItem;
            EditDeleteCustomer editDeleteCustomerView = new EditDeleteCustomer(customer, admin);
            editDeleteCustomerView.Show();
            this.Hide();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
