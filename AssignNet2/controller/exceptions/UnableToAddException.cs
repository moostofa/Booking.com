using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Booking.com.controller.exceptions
{
    public class UnableToAddException : Exception
    {
        public UnableToAddException()
        {
        }

        public UnableToAddException(string message) : base(message)
        {
        }

        public UnableToAddException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected UnableToAddException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
