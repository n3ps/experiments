using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ninject3
{
    class Samurai
    {
        readonly IWeapon[] allWeapons;

        [Inject]
        public Samurai(IWeapon[] weapons)
        {
            this.allWeapons = weapons;
        }

        public void Attack(string target)
        {
            foreach (var weapon in allWeapons)
            {
                weapon.Hit(target);
            }
        }
    }
}
