using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_factory
{
    public class Dragon : IMonster
    {
        public void Attack()
        {
            Console.WriteLine("Con rồng phun lữa");
        }
    }
}
