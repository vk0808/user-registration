using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistration
{
    public class CustomException : Exception
    {
        // default enum
        public enum ExceptionType
        {
            NULL_VALUE, EMPTY_VALUE,
        }

        // instance variable
        public ExceptionType type;

        // constructor
        public CustomException(ExceptionType Type, string message) : base(message)
        {
            this.type = Type;
        }
    }
}
