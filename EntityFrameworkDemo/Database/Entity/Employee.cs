using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkDemo.Database.Entity
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public int PassportId { get; set; }

        [ForeignKey(nameof(PassportId))]
        public Passport? Passport { get; set; }

        public virtual ICollection<Project> Projects { get; set; }

        public Employee(string name, Passport passport, HashSet<Project> projects) 
        {
            Name = name;
            Passport = passport;
            Projects = projects;
        }

        public Employee(string name, Passport passport)
        {
            Name = name;
            Passport = passport;
            Projects = new HashSet<Project>();
        }

        public Employee() { } 

        public void AddProject(Project project)
        {
            Projects.Add(project);
        }
    }
}
