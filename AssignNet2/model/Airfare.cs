using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.com
{
    public class Airfare : CompanyEntity
    {

        public string Destination {  get; set; }
        public double Price { get; set; }

        public DateTime Departure { get; set; }
        public DateTime Arrival { get; set; }

        public Airfare(string name, string location, int id, string destination, double price) : base(name, location, id) 
        {
            this.Destination = destination;
            this.Price = price;
        }
    }
}
