namespace CarsSystem.Models
{
    public interface ICar
    {
        string Producer { get; set; }

        string Model { get; set; }

        EngineType EngineType { get; set; }

        IExtra Extres { get; set; }
    }
}
