namespace Decorator
{
    using System;
    using System.Collections.Generic;

    public class Passengerable : Decorator
    {
        private readonly int maxPassengersCount;
        private readonly double flightPrice;
        private int passengersCount;
        private List<string> passengers;

        public Passengerable(Vehicle vehicle, int maxPassengersCount, double price)
            : base(vehicle)
        {
            this.passengersCount = 0;
            this.maxPassengersCount = maxPassengersCount;
            this.flightPrice = price;
            this.Passengers = new List<string>();
        }

        public List<string> Passengers
        {
            get
            {
                return new List<string>(this.passengers);
            }

            set
            {
                this.passengers = value;
            }
        }

        public override string Display()
        {
            return base.Display() + "\n" + "Passengers count: " + this.passengersCount +
                "\n" + new string(' ', 5) + "Total profit: " + this.CalculateTotalProfit();
        }

        public void Add(string passenger)
        {
            if (passenger == null)
            {
                throw new ArgumentNullException("Cannot add null passenger name");
            }

            if (this.passengers.Count == this.maxPassengersCount)
            {
                throw new ArgumentException("Plane is full");
            }

            this.passengersCount++;
            this.passengers.Add(passenger);
        }

        private double CalculateTotalProfit()
        {
            return this.passengersCount * this.flightPrice;
        }
    }
}
