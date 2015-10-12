namespace Phonebook.Common
{
    using System;

    public static class Validator
    {
        public static void CheckIfNull(object obj, string message = null)
        {
            if (obj == null)
            {
                throw new NullReferenceException(message);
            }
        }

        public static void CheckIfStringIsNullOrEmpty(string text, string message = null)
        {
            if (string.IsNullOrEmpty(text))
            {
                throw new NullReferenceException(message);
            }
        }

        public static void CheckIfStringLengthIsValid(string text, int max, int min = 0, string message = null)
        {
            if (text.Length < min || max < text.Length)
            {
                throw new IndexOutOfRangeException(message);
            }
        }

        public static void CheckIfNumberIsValidRange<T>(T number, T max, T min, string message = null) where T : struct, IComparable
        {
            if (number.CompareTo(min) < 0 || number.CompareTo(max) > 0)
            {
                throw new ArgumentOutOfRangeException(message);
            }
        }
    }
}
