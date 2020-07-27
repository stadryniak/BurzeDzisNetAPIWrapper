using System;
using System.Collections.Generic;
using System.Text;

namespace BurzeDzisAPIWrapper
{
    [Serializable]
    public class InvalidApiKeyException : ApplicationException
    {
        public InvalidApiKeyException() { }
        public InvalidApiKeyException(string message) : base(message) { }
        public InvalidApiKeyException(string message, System.Exception inner) : base(message, inner) { }
        protected InvalidApiKeyException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
