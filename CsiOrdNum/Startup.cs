using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CsiOrdNum.Startup))]
namespace CsiOrdNum
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
