using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TMDT_Lab4.Startup))]
namespace TMDT_Lab4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
