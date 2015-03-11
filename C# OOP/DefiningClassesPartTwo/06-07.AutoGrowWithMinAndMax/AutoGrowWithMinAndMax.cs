/*Problem 6. Auto-grow

    Implement auto-grow functionality: when the internal array is full, create a new array of double size and move all elements to it.

Problem 7. Min and Max

    Create generic methods Min<T>() and Max<T>() for finding the minimal and maximal element in the GenericList<T>.
    You may need to add a generic constraints for the type T.
*/

namespace _06_07.AutoGrowWithMinAndMax
{
    using System;
    class AutoGrowWithMinAndMax
    {
        static void Main()
        {
            GenericList<string> gList = new GenericList<string>(10);

            for (int i = 0; i < gList.Length; i++)
            {
                gList[i] = "Some text " + (i + 1);
            }

            Console.WriteLine("Before Insert");
            PrintValues(gList);
            gList.InsertAtPosition(1, "Some new text at position 1");

            Console.WriteLine("After Insert");
            PrintValues(gList);

            gList.RemoveAtPosition(1);
            Console.WriteLine("After Remove");
            PrintValues(gList);

            for (int i = 0; i < 10; i++)
            {
                gList.Add("added text");
            }
            Console.WriteLine("After Adding");
            PrintValues(gList);


            GenericList<double> numbers = new GenericList<double>(5);
            numbers.Add(3.4);
            numbers.Add(5);
            numbers.Add(12.6);
            numbers.Add(12.3);
            numbers.Add(12.61);
            Console.WriteLine("Max: {0}", numbers.Max());
            Console.WriteLine("Min: {0}", numbers.Min());
        }

        private static void PrintValues<T>(GenericList<T> gList) where T : IComparable
        {
            for (int i = 0; i < gList.Length; i++)
            {
                Console.WriteLine("[{0}] --> {1}",i,gList[i]);
            }
        }
    }
}
