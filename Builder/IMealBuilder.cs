﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public interface IMealBuilder
    {
        void BuildBurger();
        void BuildFries();
        void BuildDrink();
        Meal GetMeal();
    }
}
