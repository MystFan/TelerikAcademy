/*Problem 8.* Events

    Read in MSDN about the keyword event in C# and how to publish events.
    Re-implement the above using .NET events and following the best practices.
*/

namespace _08.Events
{
    using System;
    using System.Collections.Generic;

    
    class Events
    {
        static void Main()
        {
            var publisher = new Timer();
            var subscriber = new TimerSubscriber();

            publisher.Timed += subscriber.OnTimerChange;

            publisher.RunTimer(10);
        }
    }

    public class TimerSubscriber
    {
        public void OnTimerChange(object sender, TimerArguments args)
        {
            if (args.Seconds == 0)
            {
                Console.WriteLine("BOOM");
            }
        }
    }
}
