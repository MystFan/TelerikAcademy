/*Problem 2. Constructors

    Define several constructors for the defined classes that take different sets of arguments (the full information for the class or part of it).
    Assume that model and manufacturer are mandatory (the others are optional). All unknown data fill with null.
*/
namespace _02.Constructors
{
    using System;
    class Constructors
    {
        public static void Main()
        {
            MobilePhone phone = new MobilePhone("Galaxy", "Samsung", 630m);
            phone.Battery = new Battery("mobile");
            phone.Display = new Display(5,65000000);
        }
    }
}
