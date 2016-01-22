namespace CarsSystem.Models
{
    using System.Collections.Generic;

    public class Producer : IProducer
    {
        public string Name { get; set; }

        public ICollection<string> Models { get; set; }
    }
}