namespace _01.ImplementPriorityQueue
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class PriorityQueue<T> : IEnumerable<T>
        where T : IComparable
    {
        private const int InitialSize = 8;
        private T[] collection;
        private bool isMaxPriority = false;
        private int index;

        public PriorityQueue(bool priority)
        {
            this.isMaxPriority = priority;
            this.index = 0;
            this.collection = new T[InitialSize];
        }

        public int Count { get; private set; }

        public T Dequeue()
        {
            T[] currentCollection = new T[this.collection.Length];
            for (int i = 1; i < this.index + 1; i++)
            {
                currentCollection[i] = this.collection[i];
            }

            T result = this.collection[0];
            this.collection = currentCollection;
            Swap(0, this.index);

            this.index--;


            if (this.isMaxPriority)
            {
                MaxHeapifyDown(0);
            }
            else
            {
                MinHeapifyDown(0);
            }

            this.Count--;

            return result;
        }

        public void Enqueue(T value)
        {
            if (this.Count > 0)
            {
                this.index++;
                if(this.index >= this.collection.Length)
                {
                    Resize();
                }

                this.collection[this.index] = value;

                if (this.isMaxPriority)
                {
                    MaxHeapify(this.index);
                }
                else
                {
                    MinHeapify(this.index);
                }
            }
            else
            {
                this.collection[this.index] = value;
            }

            this.Count++;
        }

        private void MaxHeapifyDown(int currentIndex)
        {
            int leftChildIndex = (2 * currentIndex) + 1;
            int rightChildIndex = (2 * currentIndex) + 2;

            if (leftChildIndex > this.index && rightChildIndex > this.index)
            {
                return;
            }

            T currentValue = this.collection[currentIndex];
            T leftValue = this.collection[leftChildIndex];
            T rightValue = this.collection[rightChildIndex];

            if(leftValue.CompareTo(currentValue) > 0 || rightValue.CompareTo(currentValue) > 0)
            {
                if (rightValue.CompareTo(leftValue) < 0)
                {
                    Swap(currentIndex, leftChildIndex);
                    MaxHeapifyDown(leftChildIndex);
                }
                else
                {
                    Swap(currentIndex, rightChildIndex);
                    MaxHeapifyDown(rightChildIndex);
                }
            }
            else
            {
                return;
            }
        }

        private void MinHeapifyDown(int currentIndex)
        {
            int leftChildIndex = (2 * currentIndex) + 1;
            int rightChildIndex = (2 * currentIndex) + 2;

            if (leftChildIndex > this.index && rightChildIndex > this.index)
            {
                return;
            }
            else if (leftChildIndex == this.index && rightChildIndex > this.index)
            {
                if (this.collection[leftChildIndex].CompareTo(this.collection[currentIndex]) < 0) // <
                {
                    Swap(currentIndex, leftChildIndex);
                }

                return;
            }
            else if (rightChildIndex == this.index && leftChildIndex > this.index)
            {
                if (this.collection[rightChildIndex].CompareTo(this.collection[currentIndex]) < 0) // <
                {
                    Swap(currentIndex, rightChildIndex);
                }

                return;
            }

            T currentValue = this.collection[currentIndex];
            T leftValue = this.collection[leftChildIndex];
            T rightValue = this.collection[rightChildIndex];

            if (leftValue.CompareTo(currentValue) < 0 || rightValue.CompareTo(currentValue) < 0)
            {
                if (rightValue.CompareTo(leftValue) > 0)
                {
                    Swap(currentIndex, leftChildIndex);
                    MinHeapifyDown(leftChildIndex);
                }
                else
                {
                    Swap(currentIndex, rightChildIndex);
                    MinHeapifyDown(rightChildIndex);
                }
            }
            else
            {
                return;
            }
        }

        private void MaxHeapify(int currentIndex)
        {
            int parentIndex = (currentIndex - 1) / 2;
            T parent = this.collection[parentIndex];

            if(parent.CompareTo(this.collection[currentIndex]) < 0)
            {
                this.Swap(currentIndex, parentIndex);
                this.MaxHeapify(parentIndex);
            }
            else
            {
                return;
            }
        }

        private void MinHeapify(int currentIndex)
        {
            int parentIndex = (currentIndex - 1) / 2;
            T parent = this.collection[parentIndex];

            if (parent.CompareTo(this.collection[currentIndex]) > 0)
            {
                this.Swap(currentIndex, parentIndex);
                this.MinHeapify(parentIndex);
            }
            else
            {
                return;
            }
        }

        private void Swap(int sourceIndex, int destinationIndex)
        {
            T savedValue = this.collection[sourceIndex];
            this.collection[sourceIndex] = this.collection[destinationIndex];
            this.collection[destinationIndex] = savedValue;
        }

        private void Resize()
        {
            T[] currentCollection = this.collection;
            this.collection = new T[currentCollection.Length * 2];

            for (int i = 0; i < currentCollection.Length; i++)
            {
                this.collection[i] = currentCollection[i];
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.Count; i++)
            {
                yield return this.collection[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
