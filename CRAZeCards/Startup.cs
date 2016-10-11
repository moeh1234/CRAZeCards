using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CRAZeCards.Startup))]
namespace CRAZeCards
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
