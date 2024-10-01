using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class VeggieMealBuilder : IMealBuilder
    {
        private Meal meal = new Meal();

        public void BuildBurger()
        {
            meal.AddItem("Veggie Burger");
        }

        public void BuildFries()
        {
            meal.AddItem("Sweet Potato Fries");
        }

        public void BuildDrink()
        {
            meal.AddItem("Orange Juice");
        }

        public Meal GetMeal()
        {
            return meal;
        }
    }
}
