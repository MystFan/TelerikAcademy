using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.IEnumerableExtensions
{

    public static class Extensions
    {
        public static T Sum<T>(this IEnumerable<T> collection)where T : IComparable
        {
            T sum = default(T);
            foreach (T element in collection)
            {
                sum += (dynamic)element;
            }
            return sum;
        }

        public static T Average<T>(this IEnumerable<T> collection) where T : struct
        {
            T sum = default(T);
            foreach (T element in collection)
            {
                sum += (dynamic)element;
            }
            return (sum / (dynamic)2);
        }
        public static T Max<T>(this IEnumerable<T> collection) where T : IComparable
        {
            T min = collection.FirstOrDefault();

            foreach (T item in collection)
            {
                if (min.CompareTo(item) < 0)
                {
                    min = item;
                }
            }
            return min;
        }

        public static T Min<T>(this IEnumerable<T> collection) where T : IComparable
        {
            T max = collection.FirstOrDefault();

            foreach (T item in collection)
            {
                if (max.CompareTo(item) > 0)
                {
                    max = item;
                }
            }
            return max;
        }

        public static T Product<T>(this IEnumerable<T> collection) where T : struct
        {
            T product = (dynamic)default(T) + 1;

            foreach (T element in collection)
            {
                product *= (dynamic)element;
            }
            return product;
        }
    }
}
