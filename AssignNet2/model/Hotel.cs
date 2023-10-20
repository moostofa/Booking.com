using System;


    public class Hotel
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Location {  get; set; }
        public double PricePerNight { get; set; }

        public Hotel(string name, string location, int id, double pricePerNight)
        {
            this.Name = name;
            this.Location = location;
            this.Id = id;
            this.PricePerNight = pricePerNight;
        }



    }

