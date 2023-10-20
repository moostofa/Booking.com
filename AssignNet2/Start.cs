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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            string email = tb_email.Text;
            string password = tb_password.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter a valid email and password");
            }
            else
            {
                User user = UserFileManager.checkLoginCredentials(email, password);
                if (user == null)
                {
                    MessageBox.Show("Incorrect Email or Password. Please try again");
                    tb_email.Text = string.Empty;
                    tb_password.Text = string.Empty;
                }
                if (user.Type == USER_TYPE.Admin)
                {
                    AdminView adminView = new AdminView((Admin)user);
                    adminView.Show();
                    tb_email.Text = string.Empty;
                    tb_password.Text = string.Empty;
                    this.Hide();
                }
                else
                {
                    CustomerView customerView = new CustomerView((Customer)user, this);
                    tb_email.Text = string.Empty;
                    tb_password.Text = string.Empty;
                    this.Hide();
                }
            }
        }

        private void register_click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.ShowDialog();
        }
    }
}
