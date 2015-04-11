
namespace AdditionalClasses
{
    using System;

    public class Validator
    {
        public static void CheckStringIsNullOrEmpty(string value, string message = "")
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException(message);
            }
        }

        public static void CheckObjectIsNull(object obj, string message = "")
        {
            if (obj == null)
            {
                throw new ArgumentNullException(message);
            }
        }

        public static void CheckValueIsNegativ<T>(T value, string message = "") where T : struct,IComparable
        {
            if (value.CompareTo(default(T)) < 0)
            {
                throw new ArgumentOutOfRangeException(message);
            }
        }
    }
}
