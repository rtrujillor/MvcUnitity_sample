using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcUnitity_sample.Startup))]
namespace MvcUnitity_sample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
