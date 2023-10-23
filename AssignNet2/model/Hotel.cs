using Booking.com;
using Booking.com.controller;
using System;


public class Hotel : BookingEntity
{
    public double PricePerNight { get; set; }
    public static readonly HotelFileManager FileManager = new HotelFileManager();

    public Hotel(string name, string location, int id, double pricePerNight) : base(name, location, id)
    {
        this.PricePerNight = pricePerNight;
    }

    public override string ToString()
    {
        return Name + ", " + Location;
    }
}

