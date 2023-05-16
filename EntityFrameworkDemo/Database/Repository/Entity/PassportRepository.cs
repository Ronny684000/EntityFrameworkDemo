using EntityFrameworkDemo.Database.Entity;
using System.Data.Entity;

namespace EntityFrameworkDemo.Database.Repository.Entity
{
    public class PassportRepository : Repository<Passport>, IPassportRepository
    {
        public PassportRepository(DbContext context) : base(context)
        {
        }

        public DemoContext DemoContext
        {
            get { return Context as DemoContext; }
        }
    }
}
