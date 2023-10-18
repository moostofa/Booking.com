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
            else if (FileManager.checkLoginCredentials(email, password))
            {
                MessageBox.Show("success");
            }
            else
            {
                MessageBox.Show("Incorrect Email or Password. Please try again");
                tb_email.Text = string.Empty;
                tb_password.Text = string.Empty;
            }

        }

        private void register_click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.ShowDialog();
        }
    }
}
