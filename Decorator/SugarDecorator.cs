using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class SugarDecorator : CoffeeDecorator
    {
        public SugarDecorator(ICoffee coffee) : base(coffee) { }

        public override string GetDescription()
        {
            return _coffee.GetDescription() + ", Sugar";
        }

        public override double GetCost()
        {
            return _coffee.GetCost() + 0.5; // Thêm giá của đường
        }
    }
}
