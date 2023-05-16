using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkDemo.Database.Entity
{
    public class Task
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        [Required]
        public int ProjectId { get; set; }

        [Required]
        [ForeignKey(nameof(ProjectId))]
        public Project? Project { get; set; }

        public Task(string name, Project project)
        {
            Name = name;
            Project = project;
        }

        public Task() { }   
    }
}
