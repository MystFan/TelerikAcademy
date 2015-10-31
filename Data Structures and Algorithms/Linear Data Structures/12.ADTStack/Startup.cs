namespace _12.ADTStack
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            MyStack<int> myStack = new MyStack<int>();
            for (int i = 1; i < 10; i++)
            {
                myStack.Push(i);
            }

            Console.WriteLine("Elements count: {0}", myStack.Count);
            Console.WriteLine("Pop: {0}", myStack.Pop());
            Console.WriteLine("Elements count: {0}", myStack.Count);

            while (myStack.Count > 0)
            {
                Console.WriteLine("Pop: {0}", myStack.Pop());
            }

            Console.WriteLine("Elements count: {0}", myStack.Count);
        }
    }
}
