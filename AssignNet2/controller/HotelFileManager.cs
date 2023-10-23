using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Booking.com.controller
{
    using exceptions;
    // This class manages serialization and deserialization of hotel details to text files
    public class HotelFileManager : IFileManager<Hotel>
    {
        private static string FilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "hotel_details.txt");
        private List<Hotel> hotelList = new List<Hotel>();

        // Reads and deserializes the JSON text file of hotel details as a list of Hotel objects
        public List<Hotel> DeserializeEntitiesFromFile()
        {
            string hotelData = File.ReadAllText(FilePath);

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

        public Hotel SearchBy(string nameLocation)
        {
            hotelList = DeserializeEntitiesFromFile();
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

        public Hotel SearchBy(string name, string location)
        {
            hotelList = DeserializeEntitiesFromFile();
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

        public void AddToFile(Hotel hotel)
        {
            hotelList = DeserializeEntitiesFromFile();
            hotelList.Add(hotel);
            WriteEntitiesToFile();
        }

        public void AddNewEntity(Dictionary<string, string> hotelProperties)
        {
            bool areHotelDetailsValid = FormValidation.AreHotelInputsValid(hotelProperties);
            if (areHotelDetailsValid)
            {
                double price;
                try
                {
                    price = Convert.ToDouble(hotelProperties["Price"]);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Error: Invalid Price Format");
                    return;
                }
                catch (OverflowException)
                {
                    MessageBox.Show("Error: Price too large");
                    return;
                }
                Hotel hotel = new Hotel(hotelProperties["Name"], hotelProperties["Location"], GenerateNewId(), price);
                AddToFile(hotel);
                MessageBox.Show("Success! The hotel has been added to the system!");
            }
            return;
        }

        public int GenerateNewId()
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

        public List<Hotel> GetListOfEntities()
        {
            hotelList = DeserializeEntitiesFromFile();
            return hotelList;
        }

        public void UpdateDetails(Hotel hotel, Dictionary<string, string> hotelProperties)
        {
            bool areHotelInputsValid = FormValidation.AreHotelInputsValid(hotelProperties);
            if (!areHotelInputsValid)
            {
                throw new InvalidUpdateException();
            }

            hotelList = DeserializeEntitiesFromFile();
            int index = hotelList.FindIndex(res => res.Id == hotel.Id);
            if (index == -1)
            {
                string errorMessage = "Error: Invalid PricePerNight Format";
                MessageBox.Show(errorMessage);
                throw new InvalidUpdateException(errorMessage);
            }
            else
            {
                try
                {
                    hotelList[index].PricePerNight = double.Parse(hotelProperties["Price"]);
                }
                catch (FormatException)
                {
                    string errorMessage = "Erorr: Invalid PricePerNight Format";
                    MessageBox.Show(errorMessage);
                    throw new InvalidUpdateException(errorMessage);
                }
                catch (OverflowException)
                {
                    string errorMessage = "Error: PricePerNight too large";
                    MessageBox.Show(errorMessage);
                    throw new InvalidUpdateException(errorMessage);
                }
                hotelList[index].Name = hotelProperties["Name"];
                hotelList[index].Location = hotelProperties["Location"];
                WriteEntitiesToFile();
                MessageBox.Show("Success! The hotel details were successfully changed");
            }
        }

        public void DeleteFromFile(Hotel hotel)
        {
            hotelList = DeserializeEntitiesFromFile();
            int index = hotelList.FindIndex(x => x.Name == hotel.Name && x.Location == hotel.Location);
            if (index == -1)
            {
                string errorMessage = "Error: Hotel not found in file";
                MessageBox.Show(errorMessage);
                throw new InvalidDeletionException(errorMessage);
            }
            else
            {
                try
                {
                    hotelList.RemoveAt(index);
                    WriteEntitiesToFile();
                    MessageBox.Show("Sucesss! The hotel has been deleted");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while trying to delete the hotel from the file: {ex.Message}");
                    throw new InvalidDeletionException(ex.Message, ex);
                }
            }
        }

        public void WriteEntitiesToFile()
        {
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Converters = { new HotelConverter() },
            };
            string writeHotels = JsonSerializer.Serialize(hotelList, options);
            File.WriteAllText(FilePath, writeHotels);
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
}




