using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms;

namespace Booking.com.controller
{
    using exceptions;
    // This class manages serialization and deserialization of airfare details to a txt file
    public class AirfareFileManager : IFileManager<Airfare>
    {
        private static string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "airline_details.txt");
        private List<Airfare> airfareList = new List<Airfare>();

        // Reads and deserializes the JSON txt file of hotel details as a list of Airfare objects
        public List<Airfare> DeserializeEntitiesFromFile()
        {
            string airfareData = File.ReadAllText(filePath);

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

        public void AddToFile(Airfare airfare)
        {
            airfareList = DeserializeEntitiesFromFile();
            airfareList.Add(airfare);
            WriteEntitiestoFile();
        }
        public List<Airfare> GetListOfEntities()
        {
            airfareList = DeserializeEntitiesFromFile();
            return airfareList;
        }
        public void AddNewEntity(Dictionary<string, string> airfareProperties)
        {
            bool validAirfare = FormValidation.IsNewOrModifiedAirfareValid(airfareProperties);
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

                airfareList = DeserializeEntitiesFromFile();
                Airfare airfare = new Airfare(airfareProperties["Name"], airfareProperties["Location"], GenerateNewId(), airfareProperties["Destination"], price);
                airfareList.Add(airfare);
                WriteEntitiestoFile();
                MessageBox.Show("Success! The airfare has been added to the system!");
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
            File.WriteAllText(filePath, writeAirlines);
        }

        void IFileManager<Airfare>.UpdateDetails(Airfare t, Dictionary<string, string> properties)
        {
            throw new NotImplementedException();
        }

        void IFileManager<Airfare>.DeleteFromFile(Airfare t)
        {
            throw new NotImplementedException();
        }

        void IFileManager<Airfare>.WriteEntitiesToFile()
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
