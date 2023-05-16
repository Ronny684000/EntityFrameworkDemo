using EntityFrameworkDemo.Database.Entity;
using System.Data.Entity;

namespace EntityFrameworkDemo.Database.Repository.Entity
{
    public class ProjectRepository : Repository<Project>, IProjectRepository
    {
        public ProjectRepository(DbContext context) : base(context)
        {
        }

        public IEnumerable<Project> GetOnlyWithTasks()
        {
            return Context.Set<Project>().Where(p => p.Tasks.Count > 0);
        }
    }
}
