using System;
using System.Linq;
using System.Diagnostics;

public class AssertionsHomework
{
    public static void SelectionSort<T>(T[] arr) where T : IComparable<T>
    {
        Debug.Assert(arr != null, "Collection is null");
        for (int index = 0; index < arr.Length - 1; index++)
        {
            int minElementIndex = FindMinElementIndex(arr, index, arr.Length - 1);
            Swap(ref arr[index], ref arr[minElementIndex]);
        }
    }

    public static int BinarySearch<T>(T[] arr, T value) where T : IComparable<T>
    {
        Debug.Assert(arr != null, "Collection is null");
        return BinarySearch(arr, value, 0, arr.Length - 1);
    }

    private static int BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex)
        where T : IComparable<T>
    {
        Debug.Assert(startIndex > 0 || startIndex < arr.Length - 1, "Start index is out of the bound of the collection");
        Debug.Assert(startIndex < endIndex, "Start index must be equal or less than end index");
        Debug.Assert(endIndex > 0 || endIndex < arr.Length - 1, "End index is out of the bound of the collection");

        while (startIndex <= endIndex)
        {
            int midIndex = (startIndex + endIndex) / 2;
            if (arr[midIndex].Equals(value))
            {
                Debug.Assert(midIndex > 0 || midIndex < arr.Length - 1, "Found index is out of the bound of the collection");

                return midIndex;
            }

            if (arr[midIndex].CompareTo(value) < 0)
            {
                // Search on the right half
                startIndex = midIndex + 1;
            }
            else
            {
                // Search on the right half
                endIndex = midIndex - 1;
            }
        }

        // Searched value not found
        int result = -1;
        Debug.Assert(result < 0, "Not Found index must be less than zero");
        return result;
    }

    private static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex)
    where T : IComparable<T>
    {
        Debug.Assert(startIndex > 0 || startIndex < arr.Length - 1, "Start index is out of the bound of the collection");
        Debug.Assert(startIndex < endIndex, "Start index must be equal or less than end index");
        Debug.Assert(endIndex > 0 || endIndex < arr.Length - 1, "End index is out of the bound of the collection");
        int minElementIndex = startIndex;
        for (int i = startIndex + 1; i <= endIndex; i++)
        {
            if (arr[i].CompareTo(arr[minElementIndex]) < 0)
            {
                minElementIndex = i;
            }
        }

        Debug.Assert(minElementIndex > 0 || minElementIndex < arr.Length - 1, "End index is out of the bound of the collection");
        return minElementIndex;
    }

    private static void Swap<T>(ref T x, ref T y)
    {
        T oldX = x;
        x = y;
        y = oldX;
        Debug.Assert(x.Equals(x), "Swap of the objects faild");
        Debug.Assert(y.Equals(y), "Swap of the objects faild");
    }

    private static void Main()
    {
        int[] arr = new int[] { 3, -1, 15, 4, 17, 2, 33, 0 };
        Console.WriteLine("arr = [{0}]", string.Join(", ", arr));
        SelectionSort(arr);
        Console.WriteLine("sorted = [{0}]", string.Join(", ", arr));

        SelectionSort(new int[0]); // Test sorting empty array
        SelectionSort(new int[1]); // Test sorting single element array

        Console.WriteLine(BinarySearch(arr, -1000));
        Console.WriteLine(BinarySearch(arr, 0));
        Console.WriteLine(BinarySearch(arr, 17));
        Console.WriteLine(BinarySearch(arr, 10));
        Console.WriteLine(BinarySearch(arr, 1000));
    }
}
