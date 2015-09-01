namespace Abstract_Factory
{
    using Abstract_Factory.Contracts;

    public class Pepsi : IDrink
    {
        private const float Quantity = 350;

        public float Milliliters
        {
            get
            {
                return Pepsi.Quantity;
            }
        }
    }
}
