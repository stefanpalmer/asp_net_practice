using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vidly1.Startup))]
namespace Vidly1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
