using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_factory
{
    public class Sword : IWeapon
    {
        public void Use()
        {
            Console.WriteLine("Sử dụng kiếm");
        }
    }
}
