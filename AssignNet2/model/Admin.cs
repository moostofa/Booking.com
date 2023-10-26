using Booking.com.model;
using System;

public class Admin : User
{
    public Admin(string email, string password, string firstName, string lastName, string phone, string address, UserType type) : base(email, password, firstName, lastName, phone, address, type)
    {
        Email = email;
        Password = password;
        FirstName = firstName;
        LastName = lastName;
        Phone = phone;
        Address = address;
        Type = type;
    }
}
