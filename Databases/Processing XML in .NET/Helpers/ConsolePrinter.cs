namespace Helpers
{
    using System;
    using System.Collections.Generic;
    using Helpers;
    using Helpers.Contracts;

    public class ConsolePrinter : IPrinter
    {
        public void Print(IEnumerable<string> items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }

        public void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}
