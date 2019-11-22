using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MongoExamplesMvcApp.Startup))]
namespace MongoExamplesMvcApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
