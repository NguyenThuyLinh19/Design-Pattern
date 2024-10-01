using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class CircleFactory
    {
        private Dictionary<string, Circle> _circles = new Dictionary<string, Circle>();

        public Circle GetCircle(string color)
        {
            if (!_circles.ContainsKey(color))
            {
                _circles[color] = new Circle(color);  // Tạo mới nếu chưa có đối tượng cùng màu
                Console.WriteLine($"Creating a new circle of color {color}");
            }
            return _circles[color];
        }
    }

}
