using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.com.controller
{
    internal interface IFileManager<T>
    {
        List<T> DeserializeEntitiesFromFile();

        void UpdateDetails(T t, Dictionary<string, string> properties);

        void AddToFile(T t);
        void DeleteFromFile(T t);

        void AddNewEntity(Dictionary<string, string> entityProperties);

        void WriteEntitiesToFile();

        List<T> GetListOfEntities();

        int GenerateNewId();
    }
}
