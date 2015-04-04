
namespace RestaurantManager.Models
{
    using System;
    using System.Collections.Generic;
    using RestaurantManager.Interfaces;
    using System.Text;
    using System.Linq;
    public class Restaurant : IRestaurant
    {
        private string name;
        private string location;
        private IList<IRecipe> recipes;

        public Restaurant(string initName, string initLocation)
        {
            this.Name = initName;
            this.Location = initLocation;
            this.Recipes = new List<IRecipe>();
        }
        public string Name
        {
            get 
            {
                return this.name;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Restaurant name cannot be null");
                }
                if (value == String.Empty)
                {
                    throw new ArgumentException("Restaurant name cannot be empty string");
                }
                this.name = value;
            }
        }

        public string Location
        {
            get 
            {
                return this.location;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Restaurant location cannot be null");
                }
                if (value == String.Empty)
                {
                    throw new ArgumentException("Restaurant location cannot be empty string");
                }
                this.location = value;
            }
        }

        public IList<IRecipe> Recipes
        {
            get 
            {
                return new List<IRecipe>(this.recipes);
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Restaurant collection of recipes cannot be null");
                }
                this.recipes = value;
            }
        }

        public void AddRecipe(IRecipe recipe)
        {
            if (recipe == null)
            {
                throw new ArgumentNullException("Recipe you try to add in restaurant recipes cannot be null");
            }

            this.recipes.Add(recipe);
        }

        public void RemoveRecipe(IRecipe recipe)
        {
            if (recipe == null)
            {
                throw new ArgumentNullException("Recipe you try to remove in restaurant recipes cannot be null");
            }

            this.recipes.Remove(recipe);
        }

        public string PrintMenu()
        {
            StringBuilder menu = new StringBuilder();
            string title = string.Format("***** {0} - {1} *****", this.Name, this.Location);
            menu.AppendLine(title);
            if (this.Recipes.Count > 0)
            {
                var drinks = this.Recipes.Where(r => r is IDrink);
                if (drinks.Count() > 0)
                {
                    menu.AppendLine("~~~~~ DRINKS ~~~~~");
                    foreach (var drink in drinks)
                    {
                        menu.Append(drink.ToString());
                    }
                }
                var salads = this.Recipes.Where(r => r is ISalad);
                if (salads.Count() > 0)
                {
                    menu.AppendLine("~~~~~ SALADS ~~~~~");
                    foreach (var salad in salads)
                    {
                        menu.Append(salad.ToString());
                    }
                }
                var mainCourses = this.Recipes.Where(r => r is IMainCourse);
                if (mainCourses.Count() > 0)
                {
                    menu.AppendLine("~~~~~ MAIN COURSES ~~~~~");
                    foreach (var mainCourse in mainCourses)
                    {
                        menu.Append(mainCourse.ToString());
                    }
                }
                var desserts = this.Recipes.Where(r => r is IDessert);
                if (desserts.Count() > 0)
                {
                    menu.AppendLine("~~~~~ DESSERTS ~~~~~");
                    foreach (var dessert in desserts)
                    {
                        menu.Append(dessert.ToString());
                    }
                }
            }
            else
            {
                menu.Append("No recipes... yet");
            }
            return menu.ToString();
        }
    }
}
