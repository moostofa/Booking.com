using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms;

namespace Booking.com.controller
{
    using exceptions;
    using validation;

    public class AirfareFileManager : IFileManager<Airfare>
    {
        public static readonly string FilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "airline_details.txt");
        private List<Airfare> airfareList = new List<Airfare>();

        public List<Airfare> DeserializeEntitiesFromFile()
        {
            string airfareData = File.ReadAllText(FilePath);

            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Converters = { new UserConverter() },
            };
            try
            {
                List<Airfare> airlines = JsonSerializer.Deserialize<List<Airfare>>(airfareData, options);
                return airlines;
            }
            catch (JsonException)
            {
                Console.WriteLine("List Empty");
            }
            return null;
        }
        public List<Airfare> FilterEntities()
        {
            airfareList = DeserializeEntitiesFromFile();
            return airfareList;
        }
        public void AddNewEntity(Airfare airfare)
        {
            airfareList = DeserializeEntitiesFromFile();
            airfareList.Add(airfare);
            WriteEntitiestoFile();
        }
        public void AddNewEntity(Dictionary<string, string> airfareProperties)
        {
            bool validAirfare = AirfareFormValidation.IsAirfareValid(airfareProperties);
            double price;
            if (validAirfare)
            {
                try
                {
                    price = Convert.ToDouble(airfareProperties["Price"]);
                }
                catch (FormatException)
                {
                    string errorMessage = "Error: Invalid price format";
                    MessageBox.Show(errorMessage);
                    throw new UnableToAddException(errorMessage);
                }
                catch (OverflowException)
                {
                    string errorMessage = "Error: Invalid price format";
                    MessageBox.Show(errorMessage);
                    throw new UnableToAddException(errorMessage);
                }

                Airfare airfare = new Airfare(airfareProperties["Name"], airfareProperties["Location"], GenerateNewId(), airfareProperties["Destination"], price);
                AddNewEntity(airfare);
            }
        }

        public int GenerateNewId()
        {
            if (airfareList.Count == 0)
            {
                return 1;
            }
            else
            {
                return airfareList.Count + 1;
            }
        }

        public void WriteEntitiestoFile()
        {
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Converters = { new AirfareConverter() },
            };
            string writeAirlines = JsonSerializer.Serialize(airfareList, options);
            File.WriteAllText(FilePath, writeAirlines);
        }

        void IFileManager<Airfare>.UpdateDetails(Airfare t, Dictionary<string, string> properties)
        {
            throw new NotImplementedException();
        }

        void IFileManager<Airfare>.DeleteEntity(Airfare airfareToDelete)
        {
            airfareList = DeserializeEntitiesFromFile();
            int index = airfareList.FindIndex(airfare => airfare.Name == airfareToDelete.Name && airfare.Location == airfareToDelete.Location);
            if (index == -1)
            {
                string errorMessage = "Error: Airfare not found in file";
                MessageBox.Show(errorMessage);
                throw new InvalidDeletionException(errorMessage);
            }

            try
            {
                airfareList.RemoveAt(index);
                WriteEntitiestoFile();
                MessageBox.Show("Sucesss! The airfare has been deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while trying to delete the airfare from the file: {ex.Message}");
                throw new InvalidDeletionException(ex.Message, ex);
            }
        }

        void IFileManager<Airfare>.SerializeEntitiesToFile()
        {
            throw new NotImplementedException();
        }
    }


    public class AirfareConverter : JsonConverter<Airfare>
    {
        public override Airfare Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            int id = 0;
            string name = null;
            string location = null;
            string destination = null;
            double price = 0;

            while (reader.Read())
            {
                if (reader.TokenType == JsonTokenType.EndObject)
                {
                    return new Airfare(name, location, id, destination, price);
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
                    case "Destination":
                        destination = reader.GetString();
                        break;
                    case "Price":
                        price = reader.GetDouble();
                        break;
                    default:
                        throw new JsonException($"Unrecognized property: {propertyName}");
                }
            }

            throw new JsonException("Unexpected end of JSON data");
        }
        public override void Write(Utf8JsonWriter writer, Airfare value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            writer.WriteNumber("Id", value.Id);
            writer.WriteString("Name", value.Name);
            writer.WriteString("Location", value.Location);
            writer.WriteString("Destination", value.Destination);
            writer.WriteNumber("Price", value.Price);
            writer.WriteEndObject();
        }
    }
}
