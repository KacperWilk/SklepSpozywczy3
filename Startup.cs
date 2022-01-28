using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SklepSpozywczy3.Startup))]
namespace SklepSpozywczy3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
