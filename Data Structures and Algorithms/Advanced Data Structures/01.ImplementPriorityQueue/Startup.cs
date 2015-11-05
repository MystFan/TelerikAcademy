namespace _01.ImplementPriorityQueue
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            PriorityQueue<int> priorityQueue = new PriorityQueue<int>(true);

            priorityQueue.Enqueue(100);
            priorityQueue.Enqueue(19);
            priorityQueue.Enqueue(36);
            priorityQueue.Enqueue(17);
            priorityQueue.Enqueue(3);
            priorityQueue.Enqueue(25);
            priorityQueue.Enqueue(1);
            priorityQueue.Enqueue(27);
            priorityQueue.Enqueue(22);
            priorityQueue.Enqueue(100);
            priorityQueue.Enqueue(111);
            priorityQueue.Enqueue(222);
            priorityQueue.Enqueue(100);
            priorityQueue.Enqueue(100);
            priorityQueue.Enqueue(324100);
            priorityQueue.Enqueue(32);
            priorityQueue.Enqueue(4);

            while (priorityQueue.Count > 0)
            {
                Console.WriteLine(priorityQueue.Dequeue());
            }
        }
    }
}
