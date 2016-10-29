using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MarketsTree.Startup))]
namespace MarketsTree
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
