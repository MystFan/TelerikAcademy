
namespace AdditionalClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    public class CycleArray<T>
    {
            private T[] collection;

            public CycleArray(T[] array)
            {
                this.collection = array;
            }

            public T[] ToArray()
            {
                return this.collection;
            }
            public int NextIndex(int currentIndex, int positions)
            {
                return (currentIndex + positions) % (this.collection.Length);
            }

            public T NextIndexElement(int currentIndex, int positions)
            {
                int index = this.NextIndex(currentIndex, positions);
                return this.collection[index];
            }

            public int BeforeIndex(int currentIndex, int positions)
            {
                int index = (currentIndex - positions) % (this.collection.Length);
                if (index < 0)
                {
                    index += this.collection.Length;
                }
                return index;
            }

            public T AfterIndexElement(int currentIndex, int positions)
            {
                int index = this.BeforeIndex(currentIndex, positions);
                return this.collection[index];
            }
            public void Forward()
            {
                List<T> list = new List<T>();
                list.Add(collection[collection.Length - 1]);
                for (int i = 0; i < collection.Length - 1; i++)
                {
                    list.Add(collection[i]);
                }
                for (int i = 0; i < list.Count; i++)
                {
                    collection[i] = list[i];
                }
            }


            public void Back()
            {
                List<T> list = new List<T>();
                for (int i = 1; i < collection.Length; i++)
                {
                    list.Add(collection[i]);
                }
                list.Add(collection[0]);
                for (int i = 0; i < list.Count; i++)
                {
                    collection[i] = list[i];
                }
            }

            public void Swap(int sourceIndex, int destinationIndex)
            {
                List<T> list = new List<T>(this.collection);
                T temp = collection[sourceIndex];
                list[sourceIndex] = default(T);
                list.Insert(destinationIndex, temp);
                list.Remove(default(T));
                this.collection = list.ToArray();
            }
            public int Length
            {
                get
                {
                    return this.collection.Length;
                }
            }
            public T this[int index]
            {
                get
                {
                    if (index >= 0 && index < collection.Length)
                    {
                        return collection[index];
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
                set
                {
                    collection[index] = value;
                }
            }
        }
}
