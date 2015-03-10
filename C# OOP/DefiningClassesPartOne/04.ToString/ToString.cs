/*Problem 4. ToString

    Add a method in the GSM class for displaying all information about it.
    Try to override ToString().
*/
namespace _04.ToString
{
    class ToString
    {
        static void Main()
        {
            MobilePhone gsm = new MobilePhone("htc", "HTC", 600m);
            System.Console.WriteLine(gsm.ToString());
        }
    }
}
