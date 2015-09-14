namespace Decorator
{
    using System;
    using System.Text;

    public class Plane : Vehicle
    {
        private string pilotName;

        public Plane(double width, double height, int maxSpeed, double fuelConsumation, string pilotName)
        {
            this.Width = width;
            this.Height = height;
            this.MaxSpeed = maxSpeed;
            this.FuelConsumption = fuelConsumation;
            this.PilotName = pilotName;
        }

        public string PilotName
        {
            get
            {
                return this.pilotName;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Pilot name cannot be null");
                }

                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid pilot name");
                }

                this.pilotName = value;
            }
        }

        public override string Display()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(new string('-', 5) + "Pilot name: " + this.PilotName + new string('-', 5));
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
