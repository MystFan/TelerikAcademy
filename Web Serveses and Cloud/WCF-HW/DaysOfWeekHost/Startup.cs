namespace DaysOfWeekHost
{
    using System;
    using System.Linq;
    using System.ServiceModel;
    using System.ServiceModel.Description;
    using DayOfWeekService;

   public  class Startup
    {
        public static void Main()
        {
            // Run DaysOfWeekHost.exe like admin and Use WCF Test Client for testing
            Uri serviceAddress = new Uri("http://localhost:1333/DayOfWeek");
            ServiceHost selfHost = new ServiceHost(typeof(DayService), serviceAddress);

            (selfHost.Description.Behaviors.FirstOrDefault(x => x is ServiceDebugBehavior) as ServiceDebugBehavior).IncludeExceptionDetailInFaults = true;
            var sMetadataBehavior = new ServiceMetadataBehavior();
            sMetadataBehavior.HttpGetEnabled = true;
            selfHost.Description.Behaviors.Add(sMetadataBehavior);

            selfHost.Open();
            Console.WriteLine("Service strted on: {0}", serviceAddress);
            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
        }
    }
}
