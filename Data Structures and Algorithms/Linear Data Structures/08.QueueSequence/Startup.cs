namespace _09.QueueSequence
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(2);
            List<int> sequenceMembers = new List<int>();

            for (int i = 0; i < 50; i++)
            {
                int number = queue.Dequeue();
                sequenceMembers.Add(number);
                queue.Enqueue(number + 1);
                queue.Enqueue(2 * number + 1);
                queue.Enqueue(number + 2);
            }

            Console.WriteLine(string.Join(", ", sequenceMembers));
        }
    }
}
