namespace Decorator
{
    using System;

    public class Program
    {
        public static void Main()
        {
            Boat boat = new Boat(30, 50, 60, 100, "Queen Mary");
            Console.WriteLine(boat.Display());
            PrintLine('-', 20);

            Plane plane = new Plane(25, 30, 660, 80, "Jhon Doe");
            Console.WriteLine(plane.Display());
            PrintLine('-', 20);

            Passengerable passengerablePlane = new Passengerable(plane, 300, 252.5);
            passengerablePlane.Add("Jhon Doe");
            passengerablePlane.Add("Foo");
            Console.WriteLine("Passengerable plane");
            Console.WriteLine(passengerablePlane.Display());
            PrintLine('-', 20);

            Passengerable passengerableBoat = new Passengerable(boat, 50, 125);
            passengerableBoat.Add("Jhon Doe");
            Console.WriteLine("Passengerable boat");
            Console.WriteLine(passengerableBoat.Display());
            PrintLine('-', 20);

            var freightableAndPassengerablePlane = new Freightable(passengerablePlane, 2000);
            Console.WriteLine(freightableAndPassengerablePlane.Display());
        }

        public static void PrintLine(char c, int length)
        {
            Console.WriteLine(new string(c, length));
        }
    }
}
