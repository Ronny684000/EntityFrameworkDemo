using EntityFrameworkDemo.Database.Entity;

namespace EntityFrameworkDemo.Database.Repository.Entity
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        Employee GetByPassport(Passport passport);
    }
}
