using System;
using System.Runtime.Serialization;

namespace Core.Exceptions
{
    public class InvalidTeamSelectionException : Exception
    {
        public InvalidTeamSelectionException()
        {

        }
        public InvalidTeamSelectionException(string message) : base(message)
        {

        }
        public InvalidTeamSelectionException(string message, Exception exception) : base(message)
        {

        }
        protected InvalidTeamSelectionException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
    }
}
