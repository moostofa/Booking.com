using System;
using System.Collections.Generic;

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

}
