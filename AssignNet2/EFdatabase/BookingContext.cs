using Microsoft.EntityFrameworkCore;
using System;

namespace Booking.com
{
    public class BookingContext : DbContext
    {
        public DbSet<Booking> Bookings { get; set; }

        public BookingContext() : base(GetOptions())
        {

        }

        private static DbContextOptions<BookingContext> GetOptions()
        {
            return SqliteDbContextOptionsBuilderExtensions.UseSqlite(new DbContextOptionsBuilder<BookingContext>(), "Data Source=bookings_details.db").Options;
        }

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
