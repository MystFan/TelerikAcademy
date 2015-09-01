namespace Abstract_Factory
{
    using Abstract_Factory.Contracts;

    public abstract class RestaurantFactory : IRestaurantFactory
    {
        public abstract ISandwich MakeRegularSandwich();

        public abstract ISandwich MakeBurgerSandwich(BurgerType type);

        public abstract IDrink MakeCola();
    }
}
