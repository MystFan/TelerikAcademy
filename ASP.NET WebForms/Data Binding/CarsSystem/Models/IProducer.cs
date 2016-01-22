namespace CarsSystem.Models
{
    using System.Collections.Generic;

    public interface IProducer
    {
        string Name { get; set; }

        ICollection<string> Models { get; set; }
    }
}
