using EntityFrameworkDemo.Database.Repository.Entity;
using System.Data.Entity;

namespace EntityFrameworkDemo.Database.Repository
{
    public class DemoUnit : IUnit
    {
        private readonly DbContext _context;
        public IEmployeeRepository Employees { get; private set; }
        public IPassportRepository Passports { get; private set; }
        public IProjectRepository Projects { get; private set; }
        public ITaskRepository Tasks { get; private set; }

        public DemoUnit(DbContext context)
        {
            _context = context;
            Passports = new PassportRepository(_context);
            Employees = new EmployeeRepository(_context);
            Projects = new ProjectRepository(_context);
            Tasks = new TaskRepository(_context);
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public DbContextTransaction BeginTransaction()
        {
            return _context.Database.BeginTransaction();
        }
    }
}
