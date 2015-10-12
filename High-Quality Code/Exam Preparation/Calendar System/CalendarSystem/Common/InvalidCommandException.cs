namespace CalendarSystem.Common
{
    using System;

    public class InvalidCommandException : ApplicationException
    {
        public InvalidCommandException(string message)
            : base(message)
        {
        }
    }
}
