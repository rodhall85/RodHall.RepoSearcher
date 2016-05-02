namespace RodHall.RepoSearcher.Entities.Repository {
    public interface IRepoUser {
        string Avatar_url { get; set; }
        string Repos_url { get; set; }
        string Name { get; set; }
        string Location { get; set; }
    }
}
