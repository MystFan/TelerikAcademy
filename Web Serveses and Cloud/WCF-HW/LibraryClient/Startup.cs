namespace LibraryClient
{
    using System;
    using LibraryServiceReference;

    public class Startup
    {
        public static void Main()
        {
            LibraryServiceClient client = new LibraryServiceClient();
            int timesContain = client.Contains("asasas", "as");
            Console.WriteLine(timesContain);
        }
    }
}
