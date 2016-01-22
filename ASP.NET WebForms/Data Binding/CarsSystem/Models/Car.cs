namespace CarsSystem.Models
{
    public class Car : ICar
    {
        public string Producer { get; set; }

        public string Model { get; set; }

        public EngineType EngineType { get; set; }

        public IExtra Extres { get; set; }
    }
}