namespace Abstract_Factory.Factories
{
    using System;
    using System.Collections.Generic;
    using Abstract_Factory.Contracts;

    public class McDonaldsFactory : RestaurantFactory
    {
        public override ISandwich MakeRegularSandwich()
        {
            List<string> ingredients = new List<string>()
            {
                "cucumbers",
                "cheese",
                "butter"
            };

            string garnish = string.Empty;
            var regularSandwich = new RegularSandwich(ingredients, garnish);

            return regularSandwich;
        }

        public override ISandwich MakeBurgerSandwich(BurgerType type)
        {
            List<string> ingredients;
            ISandwich burgerSandwich;
            string garnish = string.Empty;

            switch (type)
            {
                case BurgerType.Beef:
                    ingredients = new List<string>()
                    {
                        "beef",
                        "ketchup",
                        "lettuce"
                    };

                    garnish = "French fries";
                    burgerSandwich = new BurgerSandwich(ingredients, garnish, type);
                    break;
                case BurgerType.Cheese:
                    ingredients = new List<string>()
                    {
                        "cheese",
                        "ketchup",
                        "butter"
                    };

                    garnish = string.Empty;
                    burgerSandwich = new BurgerSandwich(ingredients, garnish, type);
                    break;
                case BurgerType.Chicken:
                    ingredients = new List<string>()
                    {
                        "chicken",
                        "ketchup",
                        "lettuce"
                    };

                    garnish = "French fries";
                    burgerSandwich = new BurgerSandwich(ingredients, garnish, type);
                    break;
                default: throw new ArgumentException();
            }

            return burgerSandwich;
        }

        public override IDrink MakeCola()
        {
            return new Cola();
        }
    }
}
