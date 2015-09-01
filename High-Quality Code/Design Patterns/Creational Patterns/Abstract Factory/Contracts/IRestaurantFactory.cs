namespace Abstract_Factory.Contracts
{
    public interface IRestaurantFactory
    {
        ISandwich MakeRegularSandwich();

        ISandwich MakeBurgerSandwich(BurgerType type);

        IDrink MakeCola();
    }
}
