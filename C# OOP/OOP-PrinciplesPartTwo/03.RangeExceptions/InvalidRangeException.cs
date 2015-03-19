
namespace _03.RangeExceptions
{
    using System;
    public class InvalidRangeException<T> : ApplicationException where T : struct
    {
        private const string ErrorMessage = "The value is not in range";
        public InvalidRangeException(string message)
            : base(message)
        {

        }
        public InvalidRangeException(string message, Exception innerEx)
            : base(message, innerEx)
        {

        }
        public InvalidRangeException(T start, T end, string message = ErrorMessage)
            :base(message)
        {
            this.Start = start;
            this.End = end;
        }

        public T Start { get; private set; }
        public T End { get; private set; }
    }
}
