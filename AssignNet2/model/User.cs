using System;

public abstract class User
{
    public string Email { get; set; }
    public string Password { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
    public USER_TYPE Type { get; }

    public User(string email, string password, string firstName, string lastName, string phone, string address, USER_TYPE type)
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

public enum USER_TYPE
{
    Admin,
    Customer
}
