using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booking.com.controller.validation
{
    public class HotelFormValidation
    {
        public static bool IsHotelValid(Dictionary<string, string> properties)
        {
            if (string.IsNullOrEmpty(properties["Name"]))
            {
                MessageBox.Show("Please enter a valid hotel name");
                return false;
            }
            else if (string.IsNullOrEmpty(properties["Location"]))
            {
                MessageBox.Show("Please enter a valid hotel location");
                return false;
            }
            else if (string.IsNullOrEmpty(properties["Price"]))
            {
                MessageBox.Show("Please enter a valid price per night");
                return false;
            }
            return true;
        }

        public static bool IsHotelBookingValid(Hashtable properties)
        {
            if (!((DateTime)properties["CheckIn"] == (DateTime)properties["CheckOut"]))
            {
                MessageBox.Show("Check in date can not be the same as check out date. Please contact the hotel directly for dayroom bookings.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!((DateTime)properties["CheckIn"] < (DateTime)properties["CheckOut"]))
            {
                MessageBox.Show("Check out date can not be before check in date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
