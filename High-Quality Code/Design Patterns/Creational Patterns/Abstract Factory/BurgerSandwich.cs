namespace Abstract_Factory
{
    using System;
    using System.Collections.Generic;

    public class BurgerSandwich : RegularSandwich
    {
        private BurgerType type;

        public BurgerSandwich(List<string> ingredients, string garnish, BurgerType type)
            : base(ingredients, garnish)
        {
            this.Type = type;
        }

        public BurgerType Type
        {
            get
            {
                return this.type;
            }

            private set
            {
                this.type = value;
            }
        }
    }
}
