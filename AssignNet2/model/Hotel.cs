using Booking.com;
using System;


public class Hotel : CompanyEntity
{
    public double PricePerNight { get; set; }

    public Hotel(string name, string location, int id, double pricePerNight) : base(name, location, id)
    {
        this.PricePerNight = pricePerNight;
    }

    public override string ToString()
    {
        return Name + ", " + Location;
    }
}

