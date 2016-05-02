using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RodHall.RepoSearcher.Web.Controllers;
using RodHall.RepoSearcher.Web.Models;
using RodHall.RepoSearcher.Web.Repository;

namespace RodHall.RepoSearcher.Tests.Controllers {
    [TestClass]
    public class HomeControllerTest {
        [TestMethod]
        public void Search_Invoke_ReturnsViewResult() {
            HomeController controller = new HomeController(new GitHubRepository());

            ViewResult result = controller.Search() as ViewResult;

            Assert.IsInstanceOfType(result, typeof(ViewResult));
        }

        [TestMethod]
        public void Results_Invoke_ReturnsViewResult() {
            HomeController controller = new HomeController(new GitHubRepository());

            ViewResult result = controller.Results(new UserSearch() { Username = "robconery" }) as ViewResult;

            Assert.IsInstanceOfType(result, typeof(ViewResult));
        }
    }
}
