using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EnumDropDown.Startup))]
namespace EnumDropDown
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
