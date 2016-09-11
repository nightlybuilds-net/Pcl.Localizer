using System;

namespace PclLocalizer.Console.Exceptions
{
    class ParameterMissingException : Exception
    {
        public ParameterMissingException(string msg) : base(msg)
        { }
    }
}