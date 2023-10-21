namespace Booking.com
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json;
    using System.Text.Json.Serialization;


    // This class manages serialization and deserialization of airfare details (name,  etc.) to a txt file
    // We will eventually need another class that communicates with an actual DB such as Postgres (for bonus marks by introducing external DB with LINQ) for bookings.
    public class AirfareFileManager
    {
        private static string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "airline_details.txt");
        private static List<Airfare> airfareList = new List<Airfare>();

        // Deserializes the JSON txt file of hotel details as a list of User objects
        private static List<Airfare> readAirfaresFromFile()
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

        public static void addAirfare(Airfare airfare)
        {
            airfareList = readAirfaresFromFile();
            airfareList.Add(airfare);
            writeAirfaresToFile();
        }

        public static void addAirfare(string name, string location, string destination, double price)
        {
            //airfareList = readAirfaresFromFile();
            Airfare airfare = new Airfare(name, location, generateAirlineId(), destination, price);
            airfareList.Add(airfare);
            writeAirfaresToFile();
        }

        public static int generateAirlineId()
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

        private static void writeAirfaresToFile()
        {
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Converters = { new AirlineConverter() },
            };
            string writeAirlines = JsonSerializer.Serialize(airfareList, options);
            File.WriteAllText(filePath, writeAirlines);
        }
    }


    public class AirlineConverter : JsonConverter<Airfare>
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
