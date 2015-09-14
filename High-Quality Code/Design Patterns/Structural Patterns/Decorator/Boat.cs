namespace Decorator
{
    using System.Text;

    public class Boat : Vehicle
    {
        private readonly string name;

        public Boat(double width, double height, int maxSpeed, double fuelConsumation, string name)
        {
            base.Width = width;
            base.Height = height;
            base.MaxSpeed = maxSpeed;
            base.FuelConsumption = fuelConsumation;
            this.name = name;
        }

        public override string Display()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(new string('-', 5) + "Boat name: " + this.name + new string('-', 5));
            sb.AppendLine("Size:");
            sb.AppendLine(new string(' ', 5) + "width - " + this.Width);
            sb.AppendLine(new string(' ', 5) + "height - " + this.Height);
            sb.AppendLine("Parameters:");
            sb.AppendLine(new string(' ', 5) + "max speed - " + this.MaxSpeed);
            sb.Append(new string(' ', 5) + "fuel consumation - " + this.FuelConsumption);

            return sb.ToString();
        }
    }
}
