using Booking.com.controller.validation;
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
    public class BookingManager
    {
        public static BookingContext context;
        public static void CreateBookingsDbContext()
        {
            if (context == null)
            {
                context = new BookingContext();
                context.Database.EnsureCreated();
                context.Bookings.Load();
            }
        }

        public static bool CreateHotelBooking(Hashtable properties)
        {
            bool validInputs = HotelFormValidation.IsHotelBookingValid(properties);
            if (validInputs)
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

        public static int CalculateNumberOfNights(DateTime checkIn, DateTime checkOut)
        {
            TimeSpan nights = checkOut.Subtract(checkIn);
            return nights.Days >= 1 ? nights.Days : 0;
        }

        // for testing
        public static void DeleteAllBookings()
        {
            context.Bookings.RemoveRange(context.Bookings);
            context.SaveChanges();
        }
    }
}
