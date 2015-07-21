using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(web4stone.Startup))]
namespace web4stone
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
