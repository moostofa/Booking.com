
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.com
{
    public class BookingContext : DbContext
    {
        public DbSet<Booking> Bookings { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    => optionsBuilder.UseSqlite("Data Source=bookings_details.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Booking>().HasData(
                new Booking
                {
                    BookingId = 1,
                    Email = "test@sample.com",
                    CheckIn = new DateTime(2023, 10, 1, 14, 30, 0),
                    CheckOut = new DateTime(2023, 10, 5, 10, 00, 0),
                    CompanyType = 1,
                    CompanyId = 1,
                }
                );
        }
    }
}
