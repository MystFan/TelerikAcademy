
namespace _03.Enumeration
{
    public class Battery
    {
        public Battery(string model,BatteryType type)
        {
            this.Model = model;
            this.Type = type;
        }
        public string Model { get; set; }
        public BatteryType Type { get; set; }
        public short? HoursIdle { get; set; }
        public short? HoursTalk { get; set; }
    }

    public enum BatteryType
    {
        Li_lon, 
        Li_Poly, 
        NiMH, 
        NiCd
    }
}
