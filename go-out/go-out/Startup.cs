using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(go_out.Startup))]
namespace go_out
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
