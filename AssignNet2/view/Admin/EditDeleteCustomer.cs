using System;
using System.Windows.Forms;

namespace Booking.com
{
    public partial class EditDeleteCustomer : Form
    {
        Admin admin;
        Customer customer;
        public EditDeleteCustomer(Customer customer, Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
            this.customer = customer;
            fillDetails();
        }

        private void back()
        {
            this.Hide();
            ViewAllCustomers viewAllCustomersWindow = new ViewAllCustomers(admin);
            viewAllCustomersWindow.Show();
        }

        private void fillDetails()
        {
            tb_firstname.Text = customer.FirstName;
            tb_lastname.Text = customer.LastName;
            tb_email.Text = customer.Email;
            tb_phone.Text = customer.Phone.ToString();
            tb_address.Text = customer.Address;
        }

        private void tb_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            string[] properties = new string[] { tb_email.Text, tb_password.Text, tb_firstname.Text, tb_lastname.Text, tb_phone.Text, tb_address.Text };
            bool detailsChanged = customer.changeAccountDetails(properties);
            if (detailsChanged)
            {
                back();
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            back();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            UserFileManager.deleteCustomer(customer);
            back();
        }
    }
}
