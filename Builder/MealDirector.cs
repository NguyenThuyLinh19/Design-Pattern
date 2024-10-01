using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class MealDirector
    {
        private IMealBuilder _mealBuilder;

        public MealDirector(IMealBuilder mealBuilder)
        {
            _mealBuilder = mealBuilder;
        }

        public void MakeMeal()
        {
            _mealBuilder.BuildBurger();
            _mealBuilder.BuildFries();
            _mealBuilder.BuildDrink();
        }
    }
}
