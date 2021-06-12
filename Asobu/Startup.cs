using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Asobu.Startup))]
namespace Asobu
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
