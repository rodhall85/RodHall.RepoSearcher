using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RodHall.RepoSearcher.Web.Startup))]
namespace RodHall.RepoSearcher.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
