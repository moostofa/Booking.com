using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booking.com.view
{
    public partial class ViewAirfare : Form
    {
        Airfare Airfare;
        public ViewAirfare(Airfare airfare)
        {
            InitializeComponent();
            Airfare = airfare;
            DisplayAirfareProperties();
        }

        private void DisplayAirfareProperties()
        {
            tb_name.Text = Airfare.Name;
            tb_location.Text = Airfare.Location;
            tb_destination.Text = Airfare.Destination;
            tb_price.Text = Airfare.Price.ToString();
            tb_id.Text = Airfare.Id.ToString();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
