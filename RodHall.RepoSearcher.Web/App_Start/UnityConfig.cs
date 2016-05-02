using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc5;
using RodHall.RepoSearcher.Web.Repository;
using RodHall.RepoSearcher.Entities.Repository;

namespace RodHall.RepoSearcher.Web
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<IRepository, GitHubRepository>();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}