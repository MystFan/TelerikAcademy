namespace Abstract_Factory
{
    using Abstract_Factory.Contracts;

    public class Cola : IDrink
    {
        private const float Quantity = 250;

        public float Milliliters
        {
            get
            {
                return Cola.Quantity;
            }
        }
    }
}
