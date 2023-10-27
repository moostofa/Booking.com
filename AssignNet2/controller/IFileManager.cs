using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.com.controller
{
    public interface IFileManager<T>
    {
        // read a boooking entity (hotel, airfare, users etc.) json text file and turn it into a list of objects of that entity type
        List<T> DeserializeEntitiesFromFile();
        
        // turns the List of object entities into a json string and writes to a text file
        void SerializeEntitiesToFile();

        // used for modifying specific information of hotels, airfares and users such as name/price/location details
        void UpdateDetails(T t, Dictionary<string, string> modifiedProperties);

        void AddNewEntity(T t);
        void AddNewEntity(Dictionary<string, string> entityProperties);

        // this method deletes from both the in-memory Object list AND the text file
        void DeleteEntity(T t);
    }
}
