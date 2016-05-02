namespace RodHall.RepoSearcher.Entities.GitHub {
    using Repository;
    using System.Collections.Generic;

    public class GitHubUserInfo : IRepoUserInfo {
        public IRepoUser User { get; set; }
        public IEnumerable<IRepoUserRepo> Repos { get; set; }
    }
}
