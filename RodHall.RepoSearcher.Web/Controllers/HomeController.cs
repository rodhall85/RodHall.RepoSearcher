using RodHall.RepoSearcher.Entities.Repository;
using RodHall.RepoSearcher.Web.Models;
using System;
using System.Web.Mvc;

namespace RodHall.RepoSearcher.Web.Controllers {
    public class HomeController : Controller {

        private IRepository repo;

        public HomeController(IRepository repo) {
            if (repo == null) {
                throw new ArgumentNullException("repo");
            }

            this.repo = repo;
        }

        public ActionResult Search() {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Search(UserSearch userSearch) {
            if (ModelState.IsValid) {
                return RedirectToAction("Results", userSearch);
            }

            return View();
        }

        public ActionResult Results(UserSearch userSearch) {
            IRepoUserInfo user = this.repo.GetUser(userSearch.Username);

            return View(user);
        }
    }
}