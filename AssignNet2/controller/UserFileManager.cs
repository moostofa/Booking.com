﻿using AssignNet2;
using Booking.com;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


// This class manages serialization and deserialization of user account details (name, email, password etc.) to a txt file
// We will eventually need another class that communicates with an actual DB such as Postgres (for bonus marks by introducing external DB with LINQ).
public class UserFileManager
{
    private static string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "user_details.txt");
    private static List<User> users = new List<User>();

    // Deserializes the JSON txt file of user account details as a list of User objects
    private static List<User> readUsersFromFile()
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

    public static List<Customer> getCustomersList()
    {
        List<User> userList = readUsersFromFile();
        List<Customer> customerList = userList.OfType<Customer>().ToList();
        return customerList;
    }

    public static void addUser(User user)
    {
        users = readUsersFromFile();
        users.Add(user);
        writeUsersToFile();
    }

    // for changing account details e.g 'First Name'
    // NOT FOR Updating Booking - Check BookingManager.UpdateBooking(...)
    public static void UpdateCustomerDetails(Customer customer, string[] properties)
    {
        users = readUsersFromFile();
        int index = users.FindIndex(user => user.Email == customer.Email);
        if (index == -1)
        {
            MessageBox.Show("Error: Customer not found in file");
        }
        else
        {
            users[index].Email = properties[0];
            users[index].Password = properties[1];
            users[index].FirstName = properties[2];
            users[index].LastName = properties[3];
            users[index].Phone = properties[4];
            users[index].Address = properties[5];
            writeUsersToFile();
            MessageBox.Show("Account Details Successfully Changed");
        }
    }

    private static void writeUsersToFile()
    {
        JsonSerializerOptions options = new JsonSerializerOptions
        {
            WriteIndented = true,
            Converters = { new UserConverter() },
        };
        string writeUsers = JsonSerializer.Serialize(users, options);
        File.WriteAllText(filePath, writeUsers);
    }

    public static void addBooking(Customer user, KeyValuePair<int, string> bookingID)
    {
        users = readUsersFromFile();
        try
        {
            int index = users.FindIndex(obj => obj.Email == user.Email);
            if (user.Type == USER_TYPE.Customer)
            {
                if (((Customer)users[index]).Bookings != null)
                {
                    ((Customer)users[index]).Bookings.Add(bookingID.Key, bookingID.Value);
                }
                else
                {
                    // something is wrong since bookings dictionary can be empty, but should never be null (bookings was deleted or nullified, or not written properly to the file)
                    // if this happens, you can initialise bookings and add bookingID for quick fix, but root issue should be investigated
                    Console.WriteLine("Check addBooking Method in FileManager - bookings list is null");
                }
            }
            writeUsersToFile();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public static User checkLoginValidDetails(string email, string password)
    {
        bool validLogin = (CheckForm.loginValidation(email, password));
        if (validLogin) {
            User user = UserFileManager.checkLoginCredentials(email, password);
            if (user != null)
            {
                return user;
            }
        }
        MessageBox.Show("Incorrect Email or Password. Please try again");
        return null;
    }
    private static User checkLoginCredentials(string email, string password)
    {
        List<User> userList = readUsersFromFile();
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

    public static void deleteCustomer(Customer customer)
    {
        users = readUsersFromFile();
        try
        {
            int index = users.FindIndex(user => user.Email == customer.Email);
            users.RemoveAt(index);
            writeUsersToFile();


            MessageBox.Show("Customer Successfully Deleted");
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
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
        writer.WriteEndObject();
    }
}



