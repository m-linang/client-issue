using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClientIssueTicketing.Startup))]
namespace ClientIssueTicketing
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
