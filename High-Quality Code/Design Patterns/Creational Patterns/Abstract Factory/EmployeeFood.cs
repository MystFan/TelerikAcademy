namespace Abstract_Factory
{
    using Abstract_Factory.Contracts;

    public class EmployeeFood
    {
        private readonly RestaurantFactory restaurant;

        public EmployeeFood(RestaurantFactory restaurant)
        {
            this.restaurant = restaurant;
        }

        public ISandwich GetRegularSandwich()
        {
            return this.restaurant.MakeRegularSandwich();
        }

        public ISandwich GetBurgerSandwich(BurgerType type)
        {
            return this.restaurant.MakeBurgerSandwich(type);
        }

        public IDrink GetCola()
        {
            return this.restaurant.MakeCola();
        }
    }
}
