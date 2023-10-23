using System;
using System.Collections.Generic;
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
            List<User> users = User.FileManager.GetListOfEntities();
            foreach (User user in users)
            {
                if (user.Type == USER_TYPE.Customer)
                {
                    lb_customers.Items.Add(user);
                }
            }
        }

        private void back()
        {
            AdminView adminView = new AdminView(admin);
            adminView.Show();
            this.Close();
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
            back();
        }
    }
}
