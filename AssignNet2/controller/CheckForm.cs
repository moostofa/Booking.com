using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booking.com
{
    public class CheckForm
    {
        public static bool changeCustomerDetails(string[] properties)
        {
            if (string.IsNullOrEmpty(properties[0]) || !properties[0].Contains('@'))
            {
                MessageBox.Show("Please enter a valid email address");
                return false;
            }
            else if (string.IsNullOrEmpty(properties[1]) || properties[1].Count() < 8)
            {
                MessageBox.Show("Please enter a valid password (at least 8 characters)");
                return false;
            }
            else if (string.IsNullOrEmpty(properties[2]))
            {
                MessageBox.Show("Please enter a First Name");
                return false;
            }
            else if (string.IsNullOrEmpty(properties[3]))
            {
                MessageBox.Show("Please enter a Last Name");
                return false;
            }
            else if (string.IsNullOrEmpty(properties[4]) || properties[4].Count() < 8)
            {
                MessageBox.Show("Please enter a valid phone number (at least 8 digits)");
                return false;
            }
            else if (string.IsNullOrEmpty(properties[5]))
            {
                MessageBox.Show("Please enter a valid Street Address");
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool loginValidation(string email, string password)
        {
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter a valid email");
                return false;
            }
            else if (string.IsNullOrEmpty (password) || password.Length < 8)
            {
                MessageBox.Show("Please enter a valid password");
                return false;
            }
            return true;
        }

        public static bool addHotel(string name, string location, string price)
        {
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter a valid hotel name");
                return false;
            }
            else if (string.IsNullOrEmpty(location))
            {
                MessageBox.Show("Please enter a valid location");
                return false;
            }
            else if (string.IsNullOrEmpty(price))
            {
                MessageBox.Show("Please enter a valid price per night");
                return false;
            }
            return true;
        }

    }
}
