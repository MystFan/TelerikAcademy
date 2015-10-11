namespace IssueTrackingSystem
{
    using System;
    using System.Globalization;
    using System.IO;
    using System.Threading;

    public class Program
    {
        public static void Main()
        {
            StreamReader reader = new StreamReader("../../../Tests/test.001.in.txt");
            Console.SetIn(reader);
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            var engine = new Engine();
            engine.Run();
        }
    }
}
