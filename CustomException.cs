using System;
using System.Runtime.Serialization;

namespace Trifenix_Exception
{
    [Serializable]
    public class CustomException : Exception
    {
        public CustomException()
        {
        }

        public CustomException(string mensaje) : base(mensaje)
        {
        }
        public CustomException(string message, Exception innerException) : base(message, innerException)
        {
        }
        protected CustomException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
