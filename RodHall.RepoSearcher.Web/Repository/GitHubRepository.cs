using RodHall.RepoSearcher.Entities.GitHub;
using RodHall.RepoSearcher.Entities.Repository;
using RodHall.RepoSearcher.Web.Helpers;
using RodHall.RepoSearcher.Web.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace RodHall.RepoSearcher.Web.Repository {
    public class GitHubRepository : IRepository {

        private readonly string baseAddress = "https://api.github.com/users/";

        public IRepoUserInfo GetUser(string username) {
            if (string.IsNullOrEmpty(username)) {
                throw new ArgumentNullException("username");
            }

            GitHubUser userInfo = GetWebData.DownloadJsonAsObject<GitHubUser>(baseAddress + username.ToLowerInvariant());
            List<GitHubUserRepo> userRepos = GetWebData.DownloadJsonAsObject<List<GitHubUserRepo>>(userInfo.Repos_url).ToList();

            IRepoUserInfo info = new RepoUserInfo() {
                User = userInfo,
                Repos = userRepos.OrderByDescending(r => r.Stargazers_count).Take(5)
            };

            return info;
        }
    }
}