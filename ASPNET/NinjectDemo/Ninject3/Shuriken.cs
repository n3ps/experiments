using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninject3
{
    class Shuriken : IWeapon
    {
        public void Hit(string target)
        {
            Console.WriteLine("Pierced " + target);
        }
    }
}
