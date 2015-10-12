﻿namespace IssueTrackingSystem
{
    using System;
    using System.Globalization;
    using System.Threading;

    public class Program
    {
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            var engine = new Engine();
            engine.Run();
        }
    }
}
