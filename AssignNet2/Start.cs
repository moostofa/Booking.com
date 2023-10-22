
using System;
using System.Linq;
using System.Windows.Forms;

namespace Booking.com
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
            BookingsManager.createBookingsDbContext();
            Test test = new Test();
            test.Show();
        }

        private void login_Click(object sender, EventArgs e)
        {
            string email = tb_email.Text;
            string password = tb_password.Text;

            User user = UserFileManager.checkLoginValidDetails(email, password);
            if (user == null)
            {
                MessageBox.Show("Incorrect Email or Password. Try Again");
                tb_password.Text = string.Empty;
                return;
            }
            if (user.Type == USER_TYPE.Admin)
            {
                AdminView adminView = new AdminView((Admin)user);
                adminView.Show();
                this.Hide();
            }
            else
            {
                CustomerView customerView = new CustomerView((Customer)user);
                customerView.Show();
                this.Hide();
            }
        }

        private void register_click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.ShowDialog();
        }
    }
}
