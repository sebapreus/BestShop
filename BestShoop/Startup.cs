using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BestShoop.Startup))]
namespace BestShoop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
