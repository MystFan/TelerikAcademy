/*Problem 7. GSM test

    Write a class GSMTest to test the GSM class:
        Create an array of few instances of the GSM class.
        Display the information about the GSMs in the array.
        Display the information about the static property IPhone4S.
*/

namespace _07.GSMTest
{
    using System;
    using _06.StaticField;
    class GSMTest
    {
        static void Main()
        {
            GSM[] phones = new GSM[]
            {
                new GSM("htc one","HTC",700),
                new GSM("Galaxy","Samsung",600),
                new GSM("IPhone","Apple",900)
            };

            foreach (var phone in phones)
            {
                Console.WriteLine(phone.ToString());
            }

            for (int i = 0; i < GSM.IPhone4S.Length; i++)
            {
                Console.WriteLine(GSM.IPhone4S[i]);
            }
        }
    }
}
