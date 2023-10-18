using System;

public class Admin : User
{
    public Admin(string email, string password, string firstName, string lastName, string phone, string address, USER_TYPE type) : base(email, password, firstName, lastName, phone, address, USER_TYPE.Admin)
    {

    }

}
