using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_factory
{
    public class CaveFactory : IEnvironmentFactory
    {
        public IMonster CreateMonster()
        {
            return new Dragon();
        }

        public IWeapon CreateWeapon()
        {
            return new Sword();
        }
    }
}
