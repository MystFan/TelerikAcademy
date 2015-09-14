namespace Decorator
{
    public class Freightable : Decorator
    {
        private readonly double maxLoad;

        public Freightable(Vehicle vehicle, double maximumLoad) 
            : base(vehicle)
        {
            this.maxLoad = maximumLoad;
        }

        public override string Display()
        {
            return base.Display() + "\n" + "Maximum load: " + this.maxLoad;
        }
    }
}
