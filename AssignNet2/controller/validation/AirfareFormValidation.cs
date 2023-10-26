using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booking.com.controller.validation
{
    public class AirfareFormValidation
    {
        public static bool IsAirfareValid(Dictionary<string, string> properties)
        {
            if (string.IsNullOrEmpty(properties["Name"]))
            {
                MessageBox.Show("Please enter a valid airline name");
                return false;
            }
            else if (string.IsNullOrEmpty(properties["Location"]))
            {
                MessageBox.Show("Please enter a valid airfare departure location");
                return false;
            }
            else if (string.IsNullOrEmpty(properties["Destination"]))
            {
                MessageBox.Show("Please enter a valid airfare destination");
                return false;
            }
            else if (string.IsNullOrEmpty(properties["Price"]))
            {
                MessageBox.Show("Please enter a valid price for the airfare");
                return false;
            }
            return true;
        }
    }
}
