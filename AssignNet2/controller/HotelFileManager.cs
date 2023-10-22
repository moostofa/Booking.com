using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms;
using System.Xml.Linq;
using Booking.com;


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

    // Specific search method for ViewHotel class
    public static Hotel searchHotel(string nameLocation)
    {
        hotelList = readHotelsFromFile();
        string[] details = nameLocation.Split(new string[] { ", " }, StringSplitOptions.None);

        foreach (Hotel hotel in hotelList)
        {
            if (hotel.Name.ToLower() == details[0].ToLower())
            {
                if (hotel.Location.ToLower() == details[1].ToLower())
                {
                    return hotel;
                }
            }
        }
        return null;
    }

    public static Hotel searchHotel(string name, string location)
    {
        hotelList = readHotelsFromFile();
        foreach (Hotel hotel in hotelList)
        {
            if (hotel.Name.ToLower() == name.ToLower())
            {
                if (location.ToLower() == location.ToLower())
                {
                    return hotel;
                }
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

    public static bool addHotel(Dictionary<string, string> properties)
    {
        bool areHotelDetailsValid = FormValidation.IsNewOrModifiedHotelValid(properties);
        if (areHotelDetailsValid )
        {
            double price;
            try
            {
                price = Convert.ToDouble(properties["Price"]);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Price Format");
                return false;
            }
            catch (OverflowException)
            {
                MessageBox.Show("Price too large");
                return false;
            }
            hotelList = readHotelsFromFile();
            Hotel hotel = new Hotel(properties["Name"], properties["Location"], generateHotelId(), price);
            hotelList.Add(hotel);
            writeHotelsToFile();
        }
        return false;
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

    public static List<Hotel> getHotelList()
    {
        hotelList = readHotelsFromFile();
        return hotelList;
    }

    public static bool UpdateHotelDetails(Hotel hotel, Dictionary<string, string> properties)
    {
        bool hotelDetailsValid = FormValidation.IsNewOrModifiedHotelValid(properties);

        hotelList = readHotelsFromFile();
        int index = hotelList.FindIndex(res => res.Id == hotel.Id);
        if (index == -1)
        {
            MessageBox.Show("Error: Hotel not found in file");
            return false;
        }
        else
        {
            try
            {
                hotelList[index].PricePerNight = double.Parse(properties["Price"]);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid PricePerNight Format");
                return false;
            }
            catch (OverflowException)
            {
                MessageBox.Show("PricePerNight too large");
                return false;
            }
            hotelList[index].Name = properties["Name"];
            hotelList[index].Location = properties["Location"];
            writeHotelsToFile();
            MessageBox.Show("Account Details Successfully Changed");
            return true;
        }
    }

    public static bool deleteHotel(Hotel result)
    {
        hotelList = readHotelsFromFile();
        int index = hotelList.FindIndex(hotel => hotel.Name == result.Name && hotel.Location == result.Location);
        if (index == -1)
        {
            MessageBox.Show("Error: Hotel not found in file");
            return false;
        }
        else
        {
            try
            {
                hotelList.RemoveAt(index);
                writeHotelsToFile();
                MessageBox.Show("Hotel has been deleted");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
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




