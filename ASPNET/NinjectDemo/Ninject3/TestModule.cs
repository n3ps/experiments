using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninject3
{
    class TestModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IWeapon>().To<Sword>();
            Bind<IWeapon>().To<Shuriken>();
        }
    }
}
