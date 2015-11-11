namespace DayOfWeekClient
{
    using DayServiceReference;
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var client = new DayServiceClient();
            DateTime date = DateTime.Now;            
            string day = client.GetDayOfWeek(date);
            Console.WriteLine(day);
        }
    }
}
