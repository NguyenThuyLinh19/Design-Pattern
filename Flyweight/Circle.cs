using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class Circle : ICircle
    {
        private string _color;  // Trạng thái nội tại: màu sắc

        public Circle(string color)
        {
            _color = color;
        }

        public void Draw(int x, int y)
        {
            Console.WriteLine($"Drawing a {_color} circle at ({x}, {y})");
        }
    }

}
