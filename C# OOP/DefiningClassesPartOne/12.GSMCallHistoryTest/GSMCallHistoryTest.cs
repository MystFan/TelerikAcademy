/*Problem 12. Call history test

    Write a class GSMCallHistoryTest to test the call history functionality of the GSM class.
        Create an instance of the GSM class.
        Add few calls.
        Display the information about the calls.
        Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
        Remove the longest call from the history and calculate the total price again.
        Finally clear the call history and print it.
*/
namespace _12.GSMCallHistoryTest
{
    using _08.Calls;
    using _11.CallPrice;
    using System;
    using System.Globalization;
    using System.Threading;
    using System.Linq;
    using System.Collections.Generic;
    class GSMCallHistoryTest
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            GSM gsm = new GSM("htc one", "HTC");
            gsm.AddCall(new Call(DateTime.Now, "0897213421", 430));
            gsm.AddCall(new Call(DateTime.Now, "0882345233", 630));
            gsm.AddCall(new Call(DateTime.Now, "0882332432", 930));

            foreach (var call in gsm.CallHistory)
            {
                Console.WriteLine("Date: {0}",call.Date);
                Console.WriteLine("Time: {0}",call.Time);
                Console.WriteLine("Number: {0}",call.DialledPhoneNumber);
                Console.WriteLine("Duration: {0}",call.Duration);
                Console.WriteLine("----------------------------");
            }

            decimal totalPriceCalls = gsm.CalcCallsTotalPrice(0.37m);
            Console.WriteLine(totalPriceCalls);
            int longestDuration = gsm.CallHistory.Max(c => c.Duration);
            Call longestCall = gsm.CallHistory.FirstOrDefault(c => c.Duration == longestDuration);
            gsm.CallHistory.Remove(longestCall);
            totalPriceCalls = gsm.CalcCallsTotalPrice(0.37m);
            Console.WriteLine(totalPriceCalls);
            gsm.ClearCallHistory();
        }
    }
}
