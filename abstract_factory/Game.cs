using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_factory
{
    public class Game
    {
        private IMonster _monster;
        private IWeapon _weapon;

        public Game(IEnvironmentFactory factory)
        {
            _monster = factory.CreateMonster();
            _weapon = factory.CreateWeapon();
        }

        public void Play()
        {
            _monster.Attack();
            _weapon.Use();
        }
    }
}
