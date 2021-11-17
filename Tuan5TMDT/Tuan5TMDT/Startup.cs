using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tuan5TMDT.Startup))]
namespace Tuan5TMDT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
