namespace RodHall.RepoSearcher.Web.Models {
    using Entities.Repository;
    using System.Collections.Generic;

    public class RepoUserInfo : IRepoUserInfo {
        public IRepoUser User { get; set; }
        public IEnumerable<IRepoUserRepo> Repos { get; set; }
    }
}