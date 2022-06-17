using System;

namespace ModularisTest.Domain.Exceptions
{
    public class NoValidArgsException : Exception
    {
        public NoValidArgsException() : base("No valid args provided")
        {
        }
    }
}
