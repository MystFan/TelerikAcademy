using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.GenericClass
{
    public class GenericList<T> where T : class
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
            if (this.collection[lastIndex] != null)
            {
                throw new OverflowException("The collection is not enough space for a new item");
            }
            for (int i = 0; i < this.collection.Length; i++)
            {
                if (this.collection[i] == null)
                {
                    this.collection[i] = element;
                    break;
                }
            }
        }

        public void RemoveAtPosition(int index)
        {
            if (index < 0 || index > this.Length - 1)
            {
                var ex = new ArgumentOutOfRangeException();
                throw new ArgumentOutOfRangeException(ex.Message);
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
                    this.collection[i] = null;
                }
                else
                {
                    this.collection[i] = array[i];
                }
            }
        }

        public void InsertAtPosition(int index,T element)
        {
            int lastIndex = this.collection.Length - 1;
            if (this.collection[lastIndex] != null)
            {
                throw new OverflowException("The collection is not enough space for a new item");
            }
            T[] array = new T[lastIndex + 1];
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
    }
}
