using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.com.controller.exceptions
{
    public class InvalidDeletionException : Exception
    {
        public InvalidDeletionException()
        {
        }
        public InvalidDeletionException(string message) : base(message)
        {
        }
        public InvalidDeletionException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
