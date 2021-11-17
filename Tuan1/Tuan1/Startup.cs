using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tuan1.Startup))]
namespace Tuan1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
