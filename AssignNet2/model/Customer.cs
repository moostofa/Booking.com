using Booking.com;
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

    public override string ToString()
    {
        return FirstName + " " + LastName;
    }


    public bool changeAccountDetails(string[] properties)
    {
        if (CheckForm.changeCustomerDetails(properties)) 
        {
            UserFileManager.UpdateCustomerDetails(this, properties);
            this.Email = properties[0];
            this.Password = properties[1];
            this.FirstName = properties[2];
            this.LastName = properties[3];
            this.Phone = properties[4];
            this.Address = properties[5];
            MessageBox.Show("Successfully Changed Details");
            return true;
        }
        return false; 
        }
    }


