namespace RodHall.RepoSearcher.Tests.Repository {
    using Entities.GitHub;
    using Entities.Repository;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Collections.Generic;
    using System.Linq;
    using Web.Models;
    using Web.Repository;
    [TestClass]
    public class GitHubRepositoryTests {

        private const string TEST_GITHUB_USER = "robconery";

        [TestMethod]
        public void GetUser_RobConery_ReturnsRepositoryUserModel() {
            IRepository repo = new GitHubRepository();

            var result = repo.GetUser(TEST_GITHUB_USER);

            Assert.IsInstanceOfType(result, typeof(RepoUserInfo));
        }

        [TestMethod]
        public void GetUser_RobConery_ReturnsNameEqualsRobConery() {
            IRepository repo = new GitHubRepository();
            string expected = "Rob Conery";

            IRepoUserInfo result = repo.GetUser(TEST_GITHUB_USER);
            string actual = result.User.Name;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetUser_RobConery_ReturnsLocationSeattleWA() {
            IRepository repo = new GitHubRepository();
            string expected = "Seattle, WA";

            IRepoUserInfo result = repo.GetUser(TEST_GITHUB_USER);
            string actual = result.User.Location;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetUser_RobConery_ReturnsAvatarUrl() {
            IRepository repo = new GitHubRepository();
            string expected = "https://avatars.githubusercontent.com/u/78586?v=3";

            IRepoUserInfo result = repo.GetUser(TEST_GITHUB_USER);
            string actual = result.User.Avatar_url;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetUser_RobConery_ReturnsUserRepositoryCollection() {
            IRepository repo = new GitHubRepository();

            var result = repo.GetUser(TEST_GITHUB_USER);

            Assert.IsInstanceOfType(result.Repos, typeof(IEnumerable<GitHubUserRepo>));
        }

        [TestMethod]
        public void GetUser_RobConery_ReturnsFiveUserRepositories() {
            IRepository repo = new GitHubRepository();

            IEnumerable<IRepoUserRepo> result = repo.GetUser(TEST_GITHUB_USER)?.Repos;

            Assert.IsTrue(result.Count() == 5);
        }
    }
}
