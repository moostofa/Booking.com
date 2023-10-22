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
    public partial class AddHotel : Form
    {
        Admin admin;
        public AddHotel(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
        }
        private void back()
        {
            this.Close();
            AdminView adminView = new AdminView(admin);
            adminView.Show();
        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> properties = new Dictionary<string, string>
            {
                { "Name", tb_name.Text },
                { "Location", tb_location.Text },
                { "Price", tb_price.Text }
            };
            bool validForm = HotelFileManager.addHotel(properties);
            if (validForm)
            {
                MessageBox.Show("Hotel Added Successfully");
                back();
            }
        }  

        private void tb_price_keypress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains('.'))
            {
                e.Handled = true;
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            back();
        }


    }
}
