namespace ControlFlowStatementsAndLoops
{
    using System;

    public class EntryPoint
    {
        public static void Main()
        {
            // Task 2. Refactor the following if statements
            if (potato != null)
            {
                if (!potato.isPeeled && !potato.isRotten)
                {
                    Cook(potato);
                }
            }

            if ((MIN_X <= x && x <= MAX_X) && (MIN_Y <= y && y <= MAX_Y) && shouldVisitCell)
            {
                VisitCell();
            }

            // Task 3. Refactor the following loop
            for (int i = 0; i < 100; i++) 
            {
               if (i % 10 == 0)
               {
                   if (array[i] == expectedValue) 
                   {
                       Console.WriteLine("Value Found");
                   }
               }

               Console.WriteLine(array[i]);
            }
        }
    }
}
