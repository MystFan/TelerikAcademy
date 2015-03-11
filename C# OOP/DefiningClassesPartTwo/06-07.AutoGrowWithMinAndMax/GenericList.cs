using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_07.AutoGrowWithMinAndMax
{
    public class GenericList<T> where T : IComparable
    {
        private T[] collection;

        public GenericList(int size)
        {
            this.collection = new T[size];
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

        public void Add(T element)
        {
            int lastIndex = this.collection.Length - 1;
            if (element.GetType().Name == "String")
            {
                if (this.collection[lastIndex] != null)
                {
                    IncreaseCollectionSize();
                }
            }
            else
            {
                if (this.collection[lastIndex].CompareTo(default(T)) != 0)
                {
                    IncreaseCollectionSize();
                }
            }

            for (int i = 0; i < this.collection.Length; i++)
            {
                if (element.GetType().Name == "String")
                {
                    if (this.collection[i] == null)
                    {
                        this.collection[i] = element;
                        break;
                    }
                }
                else
                {
                    if (this.collection[i].CompareTo(default(T)) == 0)
                    {
                        this.collection[i] = element;
                        break;
                    }
                }
            }
        }

        public void RemoveAtPosition(int index)
        {
            if (index < 0 || index > this.Length - 1)
            {
                throw new ArgumentOutOfRangeException("Index was out of the range of valid values.");
            }
            T[] array = new T[this.collection.Length - 1];
            int currentIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i == index)
                {
                    currentIndex++;
                }
                array[i] = this.collection[currentIndex];
                currentIndex++;
            }

            for (int i = 0; i < this.collection.Length; i++)
            {
                if (i == this.collection.Length - 1)
                {
                    this.collection[i] = default(T);
                }
                else
                {
                    this.collection[i] = array[i];
                }
            }
        }

        public void InsertAtPosition(int index, T element)
        {
            if (index < 0 || index > this.Length - 1)
            {
                throw new ArgumentOutOfRangeException("Index was out of the range of valid values.");
            }
            int lastIndex = this.collection.Length - 1;
            if (this.collection[lastIndex].CompareTo(default(T)) != 0)
            {
                IncreaseCollectionSize();
            }
            T[] array = new T[this.Length];
            int i = 0;
            int j = 0;
            while (i < this.collection.Length)
            {
                if (index == i)
                {
                    array[i] = element;
                    j--;
                }
                else
                {
                    array[i] = this.collection[j];
                }
                i++;
                j++;
            }

            this.collection = array;
        }

        public T Max()
        {
            T max = this.collection.Max();
            return max;
        }

        public T Min()
        {
            T min = this.collection.Min();
            return min;
        }
        private void IncreaseCollectionSize()
        {
            T[] newCollection = new T[this.Length * 2];
            for (int i = 0; i < this.collection.Length; i++)
            {
                newCollection[i] = this.collection[i];
            }
            this.collection = newCollection;
        }
    }
}
