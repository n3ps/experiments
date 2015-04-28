using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ninject3
{
    class Sword : IWeapon
    {
        public void Hit(string target)
        {
            Console.WriteLine("Chopped " + target);
        }
    }
}
