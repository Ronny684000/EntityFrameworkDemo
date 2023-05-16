using EntityFrameworkDemo.Database.Entity;
using EntityFrameworkDemo.Utils;
using MySql.Data.EntityFramework;
using System.Data.Entity;
using Task = EntityFrameworkDemo.Database.Entity.Task;

namespace EntityFrameworkDemo
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class DemoContext : DbContext
    {
        public DemoContext() : base(XmlReader.GetConnString(nameof(DemoContext))) 
        { 
        }
        public DbSet<Employee>? Employees { get; set; }
        public DbSet<Passport>? Passports { get; set; }
        public DbSet<Project>? Projects { get; set; }
        public DbSet<Task>? Tasks { get; set; }
    }
}
