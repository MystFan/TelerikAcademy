namespace CarsSystem.Models
{
    public interface IExtra
    {
        bool HasAlarm { get; set; }

        bool HasAirCondition { get; set; }

        bool HasElectricalGlasses { get; set; }
    }
}
