using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booking.com
{
    public class BookingsManager
    {
        public static BookingContext context;
        public static void createBookingsDbContext()
        {
            if (context == null)
            {
                context = new BookingContext();
                context.Database.EnsureCreated();
                context.Bookings.Load();
            }
        }

        public static bool createHotelBooking(Hashtable properties)
        {
            bool validBooking = FormValidation.AreHotelBookingDetailsValid(properties);
            if (validBooking)
            {
                Booking booking = new Booking
                {
                    Email = (string)properties["Email"],
                    CheckIn = (DateTime)properties["CheckIn"],
                    CheckOut = (DateTime)properties["CheckOut"],
                    CompanyType = 1,
                    CompanyId = (int)properties["CompanyId"]
                };
                context.Bookings.Add(booking);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public static int calculateHotelNights(DateTime checkIn, DateTime checkOut)
        {
            TimeSpan nights = checkOut.Subtract(checkIn);
            return nights.Days;
        }


    }
}
