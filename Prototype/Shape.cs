using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public abstract class Shape
    {
        public string Color { get; set; }

        // Phương thức Clone để sao chép đối tượng
        public abstract Shape Clone();
    }
}
