using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Square : Shape
    {
        public int SideLength { get; set; }

        public Square(int sideLength, string color)
        {
            this.SideLength = sideLength;
            this.Color = color;
        }

        // Sao chép đối tượng hình vuông
        public override Shape Clone()
        {
            return new Square(this.SideLength, this.Color);
        }

        public void Display()
        {
            Console.WriteLine($"Square: Side Length = {SideLength}, Color = {Color}");
        }
    }
}
