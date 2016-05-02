namespace RodHall.RepoSearcher.Entities.Repository {
    public interface IRepoUserRepo {
        string Name { get; set; }
        string Html_url { get; set; }
        string Description { get; set; }
        int Stargazers_count { get; set; }
    }
}
