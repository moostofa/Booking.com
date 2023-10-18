using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

public class Customer : User
{
    // key, booking id; value, type (hotel, airline)
    Dictionary<int, string> bookings = new Dictionary<int, string>();
    
    public Customer(string email, string password, string firstName, string lastName, string phone, string address) : base(email, password, firstName, lastName, phone, address, USER_TYPE.Customer)
    {

    }


    public string this[int key]
    {
        get { return bookings[key]; }
        set { bookings[key] = value; }
    }

    public Dictionary<int, string> Bookings { get { return bookings; } }



    public string changeAccountDetails(string[] properties)
    {
        if (string.IsNullOrEmpty(properties[0]) || !properties[0].Contains('@'))
        {
            return "Please enter a valid email address";
        }
        else if (string.IsNullOrEmpty(properties[1]) || properties[1].Count() < 8)
        {
            return "Please enter a valid password (at least 8 characters)";
        }
        else if (string.IsNullOrEmpty(properties[2]))
        {
            return "Please enter a First Name";
        }
        else if (string.IsNullOrEmpty(properties[3]))
        {
            return "Please enter a Last Name";
        }
        else if (string.IsNullOrEmpty(properties[4]) || properties[4].Count() < 8)
        {
            return "Please enter a valid phone number (at least 8 digits)";
        }
        else if (string.IsNullOrEmpty(properties[5]))
        {
            return "Please enter a valid Street Address";
        }
        else
        {
            FileManager.UpdateCustomerDetails(this, properties);
            this.Email = properties[0];
            this.Password = properties[1]; 
            this.FirstName = properties[2];
            this.LastName = properties[3];
            this.Phone = properties[4];
            this.Address = properties[5];
            return "success";
        }
    }





}
