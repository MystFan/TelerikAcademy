
namespace _04.ToString
{
    public class Battery
    {
        public Battery(string model)
        {
            this.Model = model;
        }
        public string Model { get; set; }
        public short? HoursIdle { get; set; }
        public short? HoursTalk { get; set; }
    }
}
