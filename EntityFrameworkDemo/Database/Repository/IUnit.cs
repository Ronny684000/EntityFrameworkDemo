namespace EntityFrameworkDemo.Database.Repository
{
    public interface IUnit : IDisposable 
    {
        int Complete();
    }
}
