using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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

        public static bool addEditHotel(string[] properties)
        {
            if (string.IsNullOrEmpty(properties[0]))
            {
                MessageBox.Show("Please enter a valid name");
                return false;
            }
            else if (string.IsNullOrEmpty(properties[1]))
            {
                MessageBox.Show("Please enter a valid location");
                return false;
            }
            else if (string.IsNullOrEmpty(properties[2]))
            {
                MessageBox.Show("Please enter a valid price per night");
                return false;
            }
            return true;
        }

        public static bool addEditAirfare(string[] properties)
        {
            if (string.IsNullOrEmpty(properties[0]))
            {
                MessageBox.Show("Please enter a valid Airline name");
                return false;
            }
            else if (string.IsNullOrEmpty(properties[1]))
            {
                MessageBox.Show("Please enter a valid location");
                return false;
            }
            else if (string.IsNullOrEmpty(properties[2]))
            {
                MessageBox.Show("Please enter a valid destination");
                return false;
            }
            else if (string.IsNullOrEmpty(properties[3]))
            {
                MessageBox.Show("Please enter a valid price");
                return false;
            }
            return true;
        }

        public static bool registerCustomer(string[] properties)
        {
            if (string.IsNullOrEmpty(properties[0]) || !properties[0].Contains('@'))
            {
                MessageBox.Show("Please enter a valid email address");
                return false;
            }
            else if (string.IsNullOrEmpty(properties[1]) || properties[1].Length < 8)
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
            else if (string.IsNullOrEmpty(properties[4]) || properties[4].Length < 8)
            {
                MessageBox.Show("Please enter a valid phone number (at least 8 digits)");
                return false;
            }
            else if (string.IsNullOrEmpty(properties[5]))
            {
                MessageBox.Show("Please enter a valid Street Address");
                return false;
            }
            else if (string.IsNullOrEmpty(properties[6]))
            {
                MessageBox.Show("Please enter a valid suburb");
                return false;
            }
            else if (string.IsNullOrEmpty(properties[7]) || properties[7].Length < 4)
            {
                MessageBox.Show("Please enter a valid Postcode");
                return false;
            }
            else if (properties[8] == null)
            {
                MessageBox.Show("Please select a State or Territory");
                return false;
            }
            return true;
        }

    }
}
