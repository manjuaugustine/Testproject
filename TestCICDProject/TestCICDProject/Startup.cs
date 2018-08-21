using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestCICDProject.Startup))]
namespace TestCICDProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
