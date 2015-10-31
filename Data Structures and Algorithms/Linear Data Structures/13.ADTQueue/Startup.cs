namespace _13.ADTQueue
{
    using System;

    public class Startup
    {

        public static void Main()
        {
            MyQueue<int> queue = new MyQueue<int>();
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Enqueue(6);
            queue.Enqueue(6);
            queue.Enqueue(6);
            queue.Enqueue(6);
            queue.Enqueue(6);
            queue.Enqueue(6);
            queue.Enqueue(6);

            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }
        }
    }
}
