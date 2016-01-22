namespace CarsSystem.Data
{
    using System.Collections.Generic;
    using Models;

    public class DataSource
    {
        public static ICollection<IProducer> GetProducers()
        {
            List<IProducer> producers = new List<IProducer>()
            {
                new Producer() { Name="BMW", Models = new string[] {"315","316","318","320","323"}},
                new Producer() { Name="VW", Models = new string[] {"Golf","Jetta","Bora","Caddy","Passat"}},
                new Producer() { Name="Toyota", Models = new string[] {"Corolla","Selica","Auris","Supra"}},
                new Producer() { Name ="Audi", Models = new string[] {"TT","A1","A2","A3","A4","A5","A6","A7","A8"}}
            };

            return producers;
        }

        public static ICollection<ICar> GetCars()
        {
            List<ICar> cars = new List<ICar>()
            {
                new Car() {Producer = "BMW", Model = "315", EngineType = EngineType.Gas,Extres = new Extra(){HasAirCondition = false,HasAlarm = false, HasElectricalGlasses = false}},
                new Car() {Producer = "BMW", Model = "315", EngineType = EngineType.Gas,Extres = new Extra(){HasAirCondition = false,HasAlarm = false, HasElectricalGlasses = false}},
                new Car() {Producer = "BMW", Model = "318", EngineType = EngineType.Gas,Extres = new Extra(){HasAirCondition = true,HasAlarm = false, HasElectricalGlasses = true}},
                new Car() {Producer = "BMW", Model = "320", EngineType = EngineType.Gas,Extres = new Extra(){HasAirCondition = true,HasAlarm = true, HasElectricalGlasses = true}},
                new Car() {Producer = "BMW", Model = "323", EngineType = EngineType.Gas,Extres = new Extra(){HasAirCondition = true,HasAlarm = true, HasElectricalGlasses = true}},
                new Car() {Producer = "Audi", Model = "A6", EngineType = EngineType.Disel,Extres = new Extra(){HasAirCondition = true,HasAlarm = true, HasElectricalGlasses = true}},
                new Car() {Producer = "Audi", Model = "A4", EngineType = EngineType.Gas,Extres = new Extra(){HasAirCondition = false,HasAlarm = false, HasElectricalGlasses = true}},
                new Car() {Producer = "Audi", Model = "A8", EngineType = EngineType.Gas,Extres = new Extra(){HasAirCondition = true,HasAlarm = true, HasElectricalGlasses = true}},
                new Car() {Producer = "VW", Model = "Golf", EngineType = EngineType.Disel,Extres = new Extra(){HasAirCondition = false,HasAlarm = false, HasElectricalGlasses = true}},
                new Car() {Producer = "VW", Model = "Golf", EngineType = EngineType.Gas,Extres = new Extra(){HasAirCondition = false,HasAlarm = true, HasElectricalGlasses = true}},
                new Car() {Producer = "VW", Model = "Passat", EngineType = EngineType.Gas,Extres = new Extra(){HasAirCondition = true,HasAlarm = false, HasElectricalGlasses = true}},
                new Car() {Producer = "VW", Model = "Bora", EngineType = EngineType.Disel,Extres = new Extra(){HasAirCondition = true,HasAlarm = true, HasElectricalGlasses = true}},
                new Car() {Producer = "Toyota", Model = "Supra", EngineType = EngineType.Gas,Extres = new Extra(){HasAirCondition = true,HasAlarm = true, HasElectricalGlasses = true}},
                new Car() {Producer = "Toyota", Model = "Corolla", EngineType = EngineType.Gas,Extres = new Extra(){HasAirCondition = true,HasAlarm = false, HasElectricalGlasses = true}}
            };

            return cars;
        }

        public static IEnumerable<string> GetExtresNames()
        {
            return new List<string> { "Alarm", "Air Condition", "Electrical Glasses" };
        }

        public static IEnumerable<string> GetEngineTypes()
        {
            return new List<string> { "Gas", "Disel" };
        }
    }
}