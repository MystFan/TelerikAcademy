
namespace RestaurantManager.Models
{
    using System;
    using RestaurantManager.Interfaces;
    using System.Text;
    public class Dessert : Meal ,IDessert
    {

        public Dessert(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare, bool isVegan)
            : base(name, price, calories, quantityPerServing, timeToPrepare, isVegan)
        {
        }
        public bool WithSugar { get; private set; }

        public void ToggleSugar()
        {
            if (this.WithSugar)
            {
                this.WithSugar = false;
            }
            else
            {
                this.WithSugar = true;
            }
        }

        public override string ToString()
        {
            StringBuilder dessertInfo = new StringBuilder();
            dessertInfo.Append(string.Format("{0}", this.WithSugar ? "[SUGAR] " : ""));
            dessertInfo.Append(base.ToString());
            return dessertInfo.ToString();
        }
    }
}
