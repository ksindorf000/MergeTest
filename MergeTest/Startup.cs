using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MergeTest.Startup))]
namespace MergeTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
