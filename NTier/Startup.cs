using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NTier.Startup))]
namespace NTier
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
