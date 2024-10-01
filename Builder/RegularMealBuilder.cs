using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class RegularMealBuilder : IMealBuilder
    {
        private Meal meal = new Meal();

        public void BuildBurger()
        {
            meal.AddItem("Regular Hamburger");
        }

        public void BuildFries()
        {
            meal.AddItem("Regular Fries");
        }

        public void BuildDrink()
        {
            meal.AddItem("Coke");
        }

        public Meal GetMeal()
        {
            return meal;
        }
    }
}
