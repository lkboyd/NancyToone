using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NancyToone.Startup))]
namespace NancyToone
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
