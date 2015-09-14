namespace Decorator
{
    public abstract class Decorator : Vehicle
    {
        public Decorator(Vehicle vehicle)
        {
            this.Vehicle = vehicle;
        }

        protected Vehicle Vehicle { get; private set; }

        public override string Display()
        {
            return this.Vehicle.Display();
        }
    }
}
