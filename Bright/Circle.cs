using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Circle : Shape
    {
        public Circle(IDrawAPI drawAPI) : base(drawAPI) { }

        public override void Draw()
        {
            drawAPI.DrawShape("Circle");
        }
    }
}
