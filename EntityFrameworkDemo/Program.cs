using EntityFrameworkDemo;
using EntityFrameworkDemo.Database.Entity;
using EntityFrameworkDemo.Database.Repository;
using Task = EntityFrameworkDemo.Database.Entity.Task;

using (var unit = new DemoUnit(new DemoContext()))
{
    using (var transaction = unit.BeginTransaction())
    {
        try
        {
            string newEmployeeName = "OldName";

            var newEmployee = new Employee(newEmployeeName, new Passport(3333, 444444));
            var newProject = new Project("NewProject");

            newEmployee.AddProject(newProject);

            unit.Employees.Add(newEmployee);
            unit.Complete();

            newEmployeeName = "NewName";
            newEmployee.Name = newEmployeeName;

            unit.Employees.Update(newEmployee);
            unit.Complete();

            var data = unit.Employees.Find(e => e.Name == "NewName").Single();
            Console.WriteLine(data.Id);

            unit.Employees.Remove(data);
            unit.Complete();

            var newTask1 = new Task("NewTask1", newProject);
            var newTask2 = new Task("NewTask2", newProject);

            unit.Tasks.Add(newTask1);
            unit.Tasks.Add(newTask2);
            unit.Complete();

            transaction.Commit();

            var projects = unit.Projects.GetAll();

            Console.ReadKey();
        }
        catch (Exception)
        {
            transaction.Rollback();
            Console.WriteLine("Error occurred.");
        } 
    }
}
