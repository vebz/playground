using System;
using System.Collections.Generic;
using System.Text;

namespace playground_api.Exceptions
{

    [Serializable]
    public class BikeException : ApplicationException
    {
        public BikeException() {}
        public BikeException(string message) : base(message) {}
        public BikeException(string message, Exception inner) : base(message, inner) {}
        protected BikeException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) {}

        public BikeException(string message, string cause, DateTime time) : base(message)
        {
            CauseOfError = cause;
            ErrorTimeStamp = time;
        }

        public DateTime ErrorTimeStamp { get; set; }

        public string CauseOfError { get; set; }
    }

}
