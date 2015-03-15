/*Problem 2. IEnumerable extensions

    Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max, average.
*/

using System;
using System.Collections;
using System.Collections.Generic;
namespace _02.IEnumerableExtensions
{
    class IEnumerableExtensions
    {
        static void Main()
        {
            List<string> words = new List<string>() { "word", "some text", "foo", "lorem", "ipsum" };
            Console.WriteLine(words.Max());
            Console.WriteLine(words.Min());
            Console.WriteLine(words.Sum());

            decimal[] numbers = new decimal[] { 3.56m, 12m, 25.3m, 234m };
            Console.WriteLine(numbers.Average());
            Console.WriteLine(numbers.Product());
        }
    }
}
