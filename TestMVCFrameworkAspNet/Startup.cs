using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestMVCFrameworkAspNet.Startup))]
namespace TestMVCFrameworkAspNet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
