using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_factory
{
    public interface IEnvironmentFactory
    {
        IMonster CreateMonster();
        IWeapon CreateWeapon();
    }
}
