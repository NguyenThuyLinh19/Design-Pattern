using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Circle : Shape
    {
        public int Radius { get; set; }

        public Circle(int radius, string color)
        {
            this.Radius = radius;
            this.Color = color;
        }

        // Sao chép đối tượng hình tròn
        public override Shape Clone()
        {
            return new Circle(this.Radius, this.Color);
        }

        public void Display()
        {
            Console.WriteLine($"Circle: Radius = {Radius}, Color = {Color}");
        }
    }
}
