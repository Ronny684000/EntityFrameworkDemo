using EntityFrameworkDemo.Database.Entity;

namespace EntityFrameworkDemo.Database.Repository.Entity
{
    public interface IProjectRepository : IRepository<Project>
    {
        IEnumerable<Project> GetOnlyWithTasks();
    }
}
