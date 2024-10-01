using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class MilkDecorator : CoffeeDecorator
    {
        public MilkDecorator(ICoffee coffee) : base(coffee) { }

        public override string GetDescription()
        {
            return _coffee.GetDescription() + ", Milk";
        }

        public override double GetCost()
        {
            return _coffee.GetCost() + 1.5; // Thêm giá của sữa
        }
    }
}
