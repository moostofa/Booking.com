using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.com.controller.exceptions
{
    public class InvalidUpdateException : Exception
    {
        public InvalidUpdateException()
        {
        }
        public InvalidUpdateException(string message) : base(message)
        {
        }
        public InvalidUpdateException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
