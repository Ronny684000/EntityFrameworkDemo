using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkDemo.Database.Entity
{
    public class Project
    {
        [Key]
        public int Id { get; set; }

        [Index(IsUnique = true)]
        [StringLength(50)]
        public string Name { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }

        public Project(string name, HashSet<Employee> employees, HashSet<Task> tasks)
        {
            Name = name;
            Employees = employees;
            Tasks = tasks;
        }

        public Project(string name)
        {
            Name = name;
            Employees = new HashSet<Employee>();
            Tasks = new HashSet<Task>();
        }

        public Project() { }

        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }
        public void AddTask(Task task)
        {
            Tasks.Add(task);
        }
    }
}
