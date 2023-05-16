using EntityFrameworkDemo.Database.Entity;
using System.Data.Entity;

namespace EntityFrameworkDemo.Database.Repository.Entity
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(DbContext context) : base(context)
        {
        }

        public DemoContext DemoContext
        {
            get { return Context as DemoContext; }
        }

        public Employee GetByPassport(Passport passport)
        {
            return Context.Set<Employee>().Where(e => e.Passport == passport).Single();
        }
    }
}
