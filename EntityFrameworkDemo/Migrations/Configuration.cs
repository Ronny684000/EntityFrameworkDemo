namespace EntityFrameworkDemo.Migrations
{
    using System.Data.Entity.Migrations;

    public sealed class Configuration : DbMigrationsConfiguration<DemoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            SetSqlGenerator("MySql.Data.MySqlClient", new SqlGenerator());
        }

        protected override void Seed(DemoContext context)
        {
        }
    }
}
