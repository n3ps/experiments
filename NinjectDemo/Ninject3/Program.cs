using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninject3
{
    class Program
    {
        static void Main(string[] args)
        {
            var kernel = new StandardKernel(new TestModule());

            var samurai = kernel.Get<Samurai>();

            samurai.Attack("soldier");
        }
    }
}
