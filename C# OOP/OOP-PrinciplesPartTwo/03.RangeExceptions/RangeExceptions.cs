/*Problem 3. Range Exceptions

    Define a class InvalidRangeException<T> that holds information about an error condition related to invalid range. 
 * It should hold error message and a range definition [start … end].
    Write a sample application that demonstrates the InvalidRangeException<int> and InvalidRangeException<DateTime> 
 * by entering numbers in the range [1..100] and dates in the range [1.1.1980 … 31.12.2013].
*/

using System;
namespace _03.RangeExceptions
{
    class RangeExceptions
    {
        static void Main()
        {
            try
            {
                Random rand = new Random();
                int start = 1;
                int end = rand.Next(2, 101);
                int number = rand.Next(2, 200);
                if (number < 0 || number > end)
                {
                    throw new InvalidRangeException<int>(start, end, string.Format("Number {2} is not in range from {0} to {1}", start, end, number));
                }
            }
            catch (InvalidRangeException<int> ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine();
            try
            {
                DateTime startDate = new DateTime(1980, 1, 1);
                DateTime lastDate = new DateTime(2013, 12, 31);
                DateTime date = new DateTime(2014, 2, 1);
                if (date < startDate || date > lastDate)
                {
                    throw new InvalidRangeException<DateTime>(startDate, lastDate, string.Format("Date {2} is not in range from {0} to {1}", startDate, lastDate, date));
                }
            }
            catch (InvalidRangeException<DateTime> ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
