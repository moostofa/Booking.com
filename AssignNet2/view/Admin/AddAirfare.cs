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
    public partial class AddAirfare : Form
    {
        Admin admin;
        public AddAirfare(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        private void ReturnToPreviousForm()
        {
            this.Close();
        }

        private void button_addairfare_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> properties = new Dictionary<string, string>
            {
                {"Name", tb_airlinename.Text},
                {"Location", tb_location.Text},
                {"Destination", tb_location.Text},
                {"Price", tb_price.Text}
            };
            try
            {
                Airfare.FileManager.AddNewEntity(properties);
                MessageBox.Show("Success! The airfare has been added to the system.");
                ReturnToPreviousForm();
            }
            catch
            {
                // no need to do anything here, as a detailed MessageBox error is already shown at a deeper exception level. let the user continue to try add again.
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            ReturnToPreviousForm();
        }

        private void tb_price_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
