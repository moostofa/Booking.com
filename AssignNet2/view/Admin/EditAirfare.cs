using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booking.com
{
    public partial class EditAirfare : Form
    {
        public EditAirfare()
        {
            InitializeComponent();
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
                Airfare.FileManager.UpdateDetails(null, properties);
                MessageBox.Show("TODO: Update Airfare!");
                ReturnToPreviousForm();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
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
