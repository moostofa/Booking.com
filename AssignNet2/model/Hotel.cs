using Booking.com;
using Booking.com.controller;
using System.Collections.Generic;
using System.Windows.Forms;

public class Hotel : BookingEntity
{
    public double PricePerNight { get; set; }
    public int NumberOfFloors { get; set; }

    public static readonly HotelFileManager FileManager = new HotelFileManager();

    public Hotel(string name, string location, int id, double pricePerNight, int numberOfFloors) : base(name, location, id)
    {
        this.NumberOfFloors = numberOfFloors;
        this.PricePerNight = pricePerNight;
    }

    public static List<Hotel> GetAllEntities()
    {
        return FileManager.DeserializeEntitiesFromFile();
    }

    public override string ToString()
    {
        return Name + ", " + Location;
    }
}

