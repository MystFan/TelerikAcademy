using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.ADTQueue
{
    public class MyQueue<T>
    {
        private QueueNode<T> head;
        private QueueNode<T> tail;
        private int count;

        public int Count
        {
            get
            {
                return this.count;
            }
        }

        public void Enqueue(T value)
        {
            if (this.tail != null)
            {
                
                var element = new QueueNode<T>(value);
                this.tail.Next = element;
                element.Previous = this.tail;
                this.tail = element;
            }
            else
            {
                this.head = this.tail = new QueueNode<T>(value);
            }

            this.count++;
        }

        public T Dequeue()
        {
            T headValue = this.head.Value;
            this.head = this.head.Next;
            this.count--;

            return headValue;
        }

        private class QueueNode<T>
        {
            public QueueNode(T value)
            {
                this.Value = value;
            }

            public T Value { get; }

            public QueueNode<T> Next { get; set; }

            public QueueNode<T> Previous { get; set; }
        }
    }
}
