using System.Data.Entity;
namespace EntityFrameworkDemo.Database.Repository.Entity
{
    public class TaskRepository : Repository<Database.Entity.Task>, ITaskRepository
    {
        public TaskRepository(DbContext context) : base(context)
        {
        }

        public DemoContext DemoContext
        {
            get { return Context as DemoContext; }
        }
    }
}
