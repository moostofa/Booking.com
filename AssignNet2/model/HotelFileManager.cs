using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Dynamic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms;
using System.Xml;


// This class manages serialization and deserialization of hotel details (name,  etc.) to a txt file
// We will eventually need another class that communicates with an actual DB such as Postgres (for bonus marks by introducing external DB with LINQ) for bookings.
public class HotelFileManager
{
    private static string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "hotel_details.txt");
    private static List<Hotel> hotelList = new List<Hotel>();

    // Deserializes the JSON txt file of hotel details as a list of User objects
    private static List<Hotel> readHotelsFromFile()
    {
        string hotelData = File.ReadAllText(filePath);

        JsonSerializerOptions options = new JsonSerializerOptions
        {
            WriteIndented = true,
            Converters = { new UserConverter() },
        };
        try
        {
            List<Hotel> hotelList = JsonSerializer.Deserialize<List<Hotel>>(hotelData, options);
            return hotelList;
        }
        catch (JsonException)
        {
            Console.WriteLine("List Empty");
        }
        return null;
    }

    public static Hotel searchHotel(string name)
    {
        hotelList = readHotelsFromFile();
        foreach (Hotel hotel in hotelList)
        {
            if (hotel.Name.ToLower() == name.ToLower())
            {
                return hotel;
            }
        }
        return null;
    }


    public static void addHotel(Hotel hotel)
    {
        hotelList = readHotelsFromFile();
        hotelList.Add(hotel);
        writeHotelsToFile();
    }

    public static void addHotel(string name, string location, double pricePerNight)
    {
        hotelList = readHotelsFromFile();
        Hotel hotel = new Hotel(name, location, generateHotelId(), pricePerNight);
        hotelList.Add(hotel);
        writeHotelsToFile();
    }

    public static int generateHotelId()
    {
        if (hotelList.Count == 0)
        {
            return 1;
        }
        else
        {
            return hotelList.Count + 1;
        }
    }

    public static void UpdateHotelDetails(Hotel result, string[] properties)
    {
        hotelList = readHotelsFromFile();
        int index = hotelList.FindIndex(hotel => hotel.Name == result.Name);
        if (index == -1)
        {
            MessageBox.Show("Error: Hotel not found in file");
        }
        else
        {

            writeHotelsToFile();
            MessageBox.Show("Account Details Successfully Changed");
        }
    }

    private static void writeHotelsToFile()
    {
        JsonSerializerOptions options = new JsonSerializerOptions
        {
            WriteIndented = true,
            Converters = { new HotelConverter() },
        };
        string writeHotels = JsonSerializer.Serialize(hotelList, options);
        File.WriteAllText(filePath, writeHotels);
    }
}


public class HotelConverter : JsonConverter<Hotel>
{
    public override Hotel Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        int id = 0;
        string name = null;
        string location = null;
        double pricePerNight = 0;

        while (reader.Read())
        {
            if (reader.TokenType == JsonTokenType.EndObject)
            {
                return new Hotel(name, location, id, pricePerNight);
            }

            if (reader.TokenType != JsonTokenType.PropertyName)
            {
                throw new JsonException($"Expected PropertyName but got {reader.TokenType}");
            }

            string propertyName = reader.GetString();
            reader.Read();

            switch (propertyName)
            {
                case "Id":
                    id = reader.GetInt32();
                    break;
                case "Name":
                    name = reader.GetString();
                    break;
                case "Location":
                    location = reader.GetString();
                    break;
                case "PricePerNight":
                    pricePerNight = reader.GetDouble();
                    break;
                default:
                    throw new JsonException($"Unrecognized property: {propertyName}");
            }
        }

        throw new JsonException("Unexpected end of JSON data");
    }
    public override void Write(Utf8JsonWriter writer, Hotel value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        writer.WriteNumber("Id", value.Id);
        writer.WriteString("Name", value.Name);
        writer.WriteString("Location", value.Location);
        writer.WriteNumber("PricePerNight", value.PricePerNight);
        writer.WriteEndObject();
    }
}




