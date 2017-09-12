using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Pyme.Startup))]
namespace Pyme
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
