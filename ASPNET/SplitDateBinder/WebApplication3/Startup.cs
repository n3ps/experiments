using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SplitDateDemo.Startup))]
namespace SplitDateDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
