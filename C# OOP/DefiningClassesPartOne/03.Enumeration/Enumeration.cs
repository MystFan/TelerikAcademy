/*Problem 3. Enumeration

    Add an enumeration BatteryType (Li-Ion, NiMH, NiCd, …) and use it as a new field for the batteries.
*/
namespace _03.Enumeration
{
    class Enumeration
    {
        static void Main()
        {
            Battery battery = new Battery("mobile", BatteryType.Li_lon);
        }
    }
}
