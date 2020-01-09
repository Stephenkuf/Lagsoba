using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lagsoba.Startup))]
namespace Lagsoba
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
