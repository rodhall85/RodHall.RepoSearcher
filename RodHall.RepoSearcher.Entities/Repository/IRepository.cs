namespace RodHall.RepoSearcher.Entities.Repository {
    public interface IRepository {
        IRepoUserInfo GetUser(string Username);
    }
}
