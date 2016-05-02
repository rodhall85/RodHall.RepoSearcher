namespace RodHall.RepoSearcher.Entities.Repository {
    using System.Collections.Generic;

    public interface IRepoUserInfo {
        IRepoUser User { get; set; }
        IEnumerable<IRepoUserRepo> Repos { get; set; }
    }
}
