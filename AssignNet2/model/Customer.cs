using Booking.com;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Collections;

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

    public override string ToString()
    {
        return FirstName + " " + LastName;
    }


    public bool changeAccountDetails(Dictionary<string, string> properties)
    {
        if (FormValidation.AreCustomerDetailsValid(properties)) 
        {
            UserFileManager.UpdateCustomerDetails(this, properties);
            this.Email = properties["Email"];
            this.Password = properties["Password"];
            this.FirstName = properties["FirstName"];
            this.LastName = properties["LastName"];
            this.Phone = properties["Phone"];
            this.Address = properties["Address"];
            MessageBox.Show("Successfully Changed Details");
            return true;
        }
        return false; 
        }
    }


