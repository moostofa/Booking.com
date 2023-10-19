using System;
using System.Collections.Generic;

namespace Booking.com
{
    internal class HotelManager
    {
        public static List<Hotel> hotelList = new List<Hotel>();

        public static void addHotel(string name, string location, double pricePerNight)
        {
            Hotel hotel = new Hotel(name, location, generateHotelId(), pricePerNight);
            hotelList.Add(hotel);
        }

        public static void removeHotel(Hotel hotel)
        {
            hotelList.Remove(hotel);
        }

        private static int generateHotelId()
        {
            return hotelList.Count;
        }


    }
}
