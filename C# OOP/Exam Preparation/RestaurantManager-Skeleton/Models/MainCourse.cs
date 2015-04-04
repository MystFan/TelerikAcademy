
namespace RestaurantManager.Models
{
    using System;
    using RestaurantManager.Interfaces;
    using System.Text;
    public class MainCourse : Meal, IMainCourse
    {
        public MainCourse(string initName, decimal initPrice, int initCalories, int initQuantityPerServing, int initTimeToPrepare, bool initIsVegan, string initType)
            : base(initName, initPrice, initCalories, initQuantityPerServing, initTimeToPrepare, initIsVegan)
        {
            this.Type = SetType(initType);
        }
        public MainCourseType Type { get; private set; }
        
        private MainCourseType SetType(string type)
        {
            switch (type)
            {
                case "Soup": return MainCourseType.Soup;
                case "Entree": return MainCourseType.Entree;
                case "Pasta": return MainCourseType.Pasta;
                case "Side": return MainCourseType.Side;
                case "Meat": return MainCourseType.Meat;
                default: return MainCourseType.Other;
            }
        }

        public override string ToString()
        {
            StringBuilder mainCourseInfo = new StringBuilder();
            mainCourseInfo.Append(base.ToString());
            mainCourseInfo.AppendLine(string.Format("Type: {0}",this.Type.ToString()));
            return mainCourseInfo.ToString();
        }
    }
}
