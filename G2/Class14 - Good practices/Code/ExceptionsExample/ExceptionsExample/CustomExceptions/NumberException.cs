using System;

namespace ExceptionsExample.CustomExceptions
{
    public class NumberException : Exception
    {
        public NumberException(string message) : base (message)
        {

        }
    }
}
