namespace _12.ADTStack
{
    using System;

    public class MyStack<T>
    {
        private const int InitialSize = 8;
        private T[] elements;
        private int index;

        public MyStack()
        {
            this.elements = new T[InitialSize];
            this.index = 0;
        }

        public int Count
        {
            get
            {
                return this.index;
            }
        }

        public void Push(T element)
        {
            if(index == this.elements.Length)
            {
                AutoResize();
            }

            this.elements[index] = element;
            this.index++;
        }

        public T Pop()
        {
            if (this.elements.Length == 0)
            {
                throw new InvalidOperationException("MyStack empty.");
            }

            --this.index;
            T item = this.elements[this.index];
            this.elements[this.index] = default(T);
            return item;
        }

        public T Peek()
        {
            if(this.elements.Length == 0)
            {
                throw new InvalidOperationException("MyStack empty."); 
            }

            return this.elements[this.index];
        }

        private void AutoResize()
        {
            T[] currentCollection = new T[this.elements.Length];
            for (int i = 0; i < currentCollection.Length; i++)
            {
                currentCollection[i] = this.elements[i];
            }

            this.elements = new T[currentCollection.Length * 2];
            for (int i = 0; i < currentCollection.Length; i++)
            {
                this.elements[i] = currentCollection[i];
            }

            this.index = currentCollection.Length;
        }
    }
}
