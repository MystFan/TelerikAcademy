namespace Abstract_Factory
{
    using Abstract_Factory.Factories;
    using System.Reflection;
    using System.Configuration;

    public class AbstractFactory
    {
        public static void Main()
        {
            //var factoryClassName = ConfigurationManager.AppSettings["ManufacturerFactory"];
            //var foodFactory =
            //    Assembly.GetExecutingAssembly()
            //    .CreateInstance(factoryClassName) as RestaurantFactory;
            var foodFactory = new McDonaldsFactory(); // new KFCFactory();
            var developerFood = new EmployeeFood(foodFactory);

            var regularSandwich = developerFood.GetRegularSandwich();

            var chickenBurger = developerFood.GetBurgerSandwich(BurgerType.Chicken);

            var cola = developerFood.GetCola();
        }
    }
}
