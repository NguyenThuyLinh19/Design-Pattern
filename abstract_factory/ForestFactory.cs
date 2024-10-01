using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_factory
{
    public class ForestFactory : IEnvironmentFactory
    {
        public IMonster CreateMonster()
        {
            return new Wolf();
        }

        public IWeapon CreateWeapon()
        {
            return new Bow();
        }
    }
}
