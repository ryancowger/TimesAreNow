using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TimesAreNow.Startup))]
namespace TimesAreNow
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
