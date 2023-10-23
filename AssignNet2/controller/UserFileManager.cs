using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms;

namespace Booking.com.controller
{
    using exceptions;

    // This class manages serialization and deserialization of x account details (name, email, password etc.) to a txt file
    // We will eventually need another class that communicates with an actual DB such as Postgres (for bonus marks by introducing external DB with LINQ).
    public class UserFileManager : IFileManager<User>
    {
        private static string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "user_details.txt");
        private List<User> users = new List<User>();

        // Deserializes the JSON txt file of x account details as a list of User objects
        public List<User> DeserializeEntitiesFromFile()
        {
            string userData = File.ReadAllText(filePath);

            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Converters = { new UserConverter() },
            };
            try
            {
                List<User> userList = JsonSerializer.Deserialize<List<User>>(userData, options);
                return userList;
            }
            catch (JsonException)
            {
                Console.WriteLine("List Empty");
            }
            return null;
        }
        public List<User> GetListOfEntities()
        {
            List<User> userList = DeserializeEntitiesFromFile();
            return userList;
        }

        public void AddToFile(User user)
        {
            users = DeserializeEntitiesFromFile();
            users.Add(user);
            WriteEntitiesToFile();
        }

        public void AddNewEntity(Dictionary<string, string> userProperties)
        {
            // the form validation for users already displays message boxes for the x input field that is causing issues, so no need to display again here.
            bool validUserDetailInputs = FormValidation.AreCustomerRegistrationDetailsValid(userProperties);
            if (!validUserDetailInputs)
            {
                throw new InvalidInputException();
            }
            string address = userProperties["StreetAddress"] + " " + userProperties["Suburb"] + " " + userProperties["State"] + " " + userProperties["Postcode"];
            User customer = new Customer(userProperties["Email"], userProperties["Password"], userProperties["FirstName"], userProperties["LastName"], userProperties["Phone"], address);
            AddToFile(customer);
        }

        // for changing account details of a customer e.g 'First Name' or 'Address'
        // NOT for updating bookings for a customer; that logic is in BookingManager.UpdateBooking(...)
        public void UpdateDetails(User userToUpdate, Dictionary<string, string> userProperties)
        {
            users = DeserializeEntitiesFromFile();
            int index = users.FindIndex(user => user.Email == userToUpdate.Email);
            if (index == -1)
            {
                string errorMessage = "Error: Customer not found in file";
                MessageBox.Show(errorMessage);
                throw new InvalidUpdateException(errorMessage);
            }
            else
            {
                users[index].Email = userProperties["Email"];
                users[index].Password = userProperties["Password"];
                users[index].FirstName = userProperties["FirstName"];
                users[index].LastName = userProperties["LastName"];
                users[index].Phone = userProperties["Phone"];
                users[index].Address = userProperties["Address"];
                WriteEntitiesToFile();
                MessageBox.Show("Success! The details of the user were changed in the system");
            }
        }

        public void WriteEntitiesToFile()
        {
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Converters = { new UserConverter() },
            };
            string writeUsers = JsonSerializer.Serialize(users, options);
            File.WriteAllText(filePath, writeUsers);
        }
        public User GetUserWithLoginDetails(string email, string password)
        {
            User user = null;
            if (FormValidation.AreLoginInputsValid(email, password))
            {
                user = SearchForUserWithCredentials(email, password);
            }
            return user;
        }
        private User SearchForUserWithCredentials(string email, string password)
        {
            List<User> userList = DeserializeEntitiesFromFile();
            if (userList != null)
            {
                foreach (User user in userList)
                {
                    if (user.Email == email)
                    {
                        if (user.Password == password)
                        {
                            return user;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
            return null;
        }

        public void DeleteFromFile(User userToDelete)
        {
            users = DeserializeEntitiesFromFile();
            try
            {
                int index = users.FindIndex(user => user.Email == userToDelete.Email);
                users.RemoveAt(index);
                WriteEntitiesToFile();
                MessageBox.Show("Success! The user was deleted from the system");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        int IFileManager<User>.GenerateNewId()
        {
            throw new NotImplementedException();
        }
    }


    public class UserConverter : JsonConverter<User>
    {
        public override User Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            using (JsonDocument doc = JsonDocument.ParseValue(ref reader))
            {
                var root = doc.RootElement;
                if (root.TryGetProperty("Type", out var typeProp) && typeProp.GetInt32() == 1)
                {
                    return JsonSerializer.Deserialize<Customer>(root.GetRawText());
                }
                else if (root.TryGetProperty("Type", out typeProp) && typeProp.GetInt32() == 0)
                {
                    return JsonSerializer.Deserialize<Admin>(root.GetRawText());
                }
                else
                {
                    Console.WriteLine("Error with file");
                    Console.ReadKey();
                    return JsonSerializer.Deserialize<User>(root.GetRawText());
                }
            }
        }

        public override void Write(Utf8JsonWriter writer, User value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            writer.WriteString("Email", value.Email);
            writer.WriteString("Password", value.Password);
            writer.WriteString("FirstName", value.FirstName);
            writer.WriteString("LastName", value.LastName);
            writer.WriteString("Phone", value.Phone);
            writer.WriteString("Address", value.Address);
            writer.WriteNumber("Type", (int)value.Type);

            /* Code before DataBase created - delete when ready
            if (value is Customer customer && customer.Bookings != null)
            {
                writer.WriteStartObject("Bookings");
                foreach (var booking in customer.Bookings)
                {
                    writer.WritePropertyName(booking.Key.ToString());
                    writer.WriteStringValue(booking.Value);
                }
                writer.WriteEndObject();
            }
            */
            writer.WriteEndObject();
        }
    }
}


