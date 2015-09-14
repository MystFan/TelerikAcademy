namespace Decorator
{
    public abstract class Vehicle
    {
        public double Width { get; set; }

        public double Height { get; set; }

        public int MaxSpeed { get; set; }

        public double FuelConsumption { get; set; }

        public abstract string Display();
    }
}
