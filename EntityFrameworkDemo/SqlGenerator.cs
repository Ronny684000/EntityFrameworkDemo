using System.Data.Entity.Migrations.Model;
using System.Data.Entity.Migrations.Sql;

namespace EntityFrameworkDemo
{
    public class SqlGenerator : MySql.Data.EntityFramework.MySqlMigrationSqlGenerator
    {
        public override IEnumerable<MigrationStatement> Generate(IEnumerable<MigrationOperation> migrationOperations, string providerManifestToken)
        {
            IEnumerable<MigrationStatement> res = base.Generate(migrationOperations, providerManifestToken);
            foreach (MigrationStatement ms in res)
            {
                if (ms.Sql.Contains("dbo."))
                {
                    return new List<MigrationStatement>();
                }
            }
            return res;
        }
    }
}
