using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Pencil : IDrawAPI
    {
        public void DrawShape(string shapeName)
        {
            Console.WriteLine($"Drawing {shapeName} with Pencil.");
        }
    }
}
