using System;
using System.Collections.Generic;
using System.Text;

namespace playground_api.Exceptions
{
    [Serializable]
    public class ApplicationException : Exception
    {
        public ApplicationException() : base() { }
        public ApplicationException(string message) : base(message) { }
        public ApplicationException(string message, System.Exception inner) : base(message, inner) { }
        public ApplicationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
