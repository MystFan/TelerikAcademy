namespace _10.Sequence
{
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            Queue<int> numbers = new Queue<int>();

            int startNumber = 5;
            int endNumber = 23;

            while (startNumber <= endNumber)
            {
                numbers.Enqueue(endNumber);

                if (endNumber / 2 >= startNumber)
                {
                    if (endNumber % 2 == 0)
                    {
                        endNumber /= 2;
                    }
                    else
                    {
                        endNumber--;
                    }
                }
                else
                {
                    if (endNumber - 2 >= startNumber)
                    {
                        endNumber -= 2;
                    }
                    else
                    {
                        endNumber--;
                    }
                }
            }
        }
    }
}
