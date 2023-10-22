using System;
using System.Collections;
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
    // This class contains the logic for ensuring valid inputs into fields across the application including user registration, login, adding airfares and hotels and making bookings.
    // The error MessageBoxes are shown directly from this class to reduce complexity, as opposed to all other classes having to parse, handle and display their own error messages.
    public class FormValidation
    {
        public static bool AreCustomerDetailsValid(Dictionary<string, string> properties)
        {
            if (string.IsNullOrEmpty(properties["Email"]) || !properties["Email"].Contains('@'))
            {
                MessageBox.Show("Please enter a valid email address");
                return false;
            }
            else if (string.IsNullOrEmpty(properties["Password"]) || properties["Password"].Count() < 8)
            {
                MessageBox.Show("Please enter a valid password (at least 8 characters)");
                return false;
            }
            else if (string.IsNullOrEmpty(properties["FirstName"]))
            {
                MessageBox.Show("Please enter a First Name");
                return false;
            }
            else if (string.IsNullOrEmpty(properties["LastName"]))
            {
                MessageBox.Show("Please enter a Last Name");
                return false;
            }
            else if (string.IsNullOrEmpty(properties["Password"]) || properties["Password"].Count() < 8)
            {
                MessageBox.Show("Please enter a valid phone number (must be at least 8 digits)");
                return false;
            }
            else if (string.IsNullOrEmpty(properties["Address"]))
            {
                MessageBox.Show("Please enter a valid Street Address. Address can not be empty");
                return false;
            }
            return true;
        }

        public static bool AreLoginDetailsValid(string email, string password)
        {
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter a valid email address");
                return false;
            }
            else if (string.IsNullOrEmpty (password) || password.Length < 8)
            {
                MessageBox.Show("Please enter a valid password");
                return false;
            }
            return true;
        }

        public static bool IsNewOrModifiedHotelValid(Dictionary<string, string> properties)
        {
            if (string.IsNullOrEmpty(properties["Name"]))
            {
                MessageBox.Show("Please enter a valid name");
                return false;
            }
            else if (string.IsNullOrEmpty(properties["Location"]))
            {
                MessageBox.Show("Please enter a valid location");
                return false;
            }
            else if (string.IsNullOrEmpty(properties["Price"]))
            {
                MessageBox.Show("Please enter a valid price per night");
                return false;
            }
            return true;
        }

        public static bool IsNewOrModifiedAirfareValid(Dictionary<string, string> properties)
        {
            if (string.IsNullOrEmpty(properties["Name"]))
            {
                MessageBox.Show("Please enter a valid Airline name");
                return false;
            }
            else if (string.IsNullOrEmpty(properties["Location"]))
            {
                MessageBox.Show("Please enter a valid location");
                return false;
            }
            else if (string.IsNullOrEmpty(properties["Destination"]))
            {
                MessageBox.Show("Please enter a valid destination");
                return false;
            }
            else if (string.IsNullOrEmpty(properties["Price"]))
            {
                MessageBox.Show("Please enter a valid price");
                return false;
            }
            return true;
        }

        public static bool AreCustomerRegistrationDetailsValid(Dictionary<string, string> properties)
        {
            if (string.IsNullOrEmpty(properties["Email"]) || !properties["Email"].Contains('@'))
            {
                MessageBox.Show("Please enter a valid email address");
                return false;
            }
            else if (string.IsNullOrEmpty(properties["Password"]) || properties["Password"].Length < 8)
            {
                MessageBox.Show("Please enter a valid password (at least 8 characters)");
                return false;
            }
            else if (string.IsNullOrEmpty(properties["FirstName"]))
            {
                MessageBox.Show("Please enter a First Name");
                return false;
            }
            else if (string.IsNullOrEmpty(properties["LastName"]))
            {
                MessageBox.Show("Please enter a Last Name");
                return false;
            }
            else if (string.IsNullOrEmpty(properties["Phone"]) || properties["Phone"].Length < 8)
            {
                MessageBox.Show("Please enter a valid phone number (at least 8 digits)");
                return false;
            }
            else if (string.IsNullOrEmpty(properties["StreetAddress"]))
            {
                MessageBox.Show("Please enter a valid Street Address");
                return false;
            }
            else if (string.IsNullOrEmpty(properties["Suburb"]))
            {
                MessageBox.Show("Please enter a valid suburb");
                return false;
            }
            else if (string.IsNullOrEmpty(properties["Postcode"]) || properties["Postcode"].Length < 4)
            {
                MessageBox.Show("Please enter a valid Postcode");
                return false;
            }
            else if (string.IsNullOrEmpty(properties["State"]))
            {
                MessageBox.Show("Please select a State or Territory");
                return false;
            }
            return true;
        }

        public static bool AreHotelBookingDetailsValid(Hashtable properties)
        {
            if (!((DateTime)properties["CheckIn"] < (DateTime)properties["CheckOut"]))
            {
                MessageBox.Show("Cannot check-out before check-in. Please pick a valid date");
                return false;
            }
            return true;
        }
    }
}
