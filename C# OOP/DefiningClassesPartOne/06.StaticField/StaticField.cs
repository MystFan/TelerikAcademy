/*Problem 6. Static field

    Add a static field and a property IPhone4S in the GSM class to hold the information about iPhone 4S.
*/
namespace _06.StaticField
{
    class StaticField
    {
        static void Main()
        {
            string[] gsmInfo = GSM.IPhone4S;
            for (int i = 0; i < gsmInfo.Length; i++)
            {
                System.Console.WriteLine(gsmInfo[i]);
            }
        }
    }
}
