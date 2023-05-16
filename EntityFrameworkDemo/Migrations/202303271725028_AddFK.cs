namespace EntityFrameworkDemo.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class AddFK : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, unicode: false),
                        PassportId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Passports", t => t.PassportId, cascadeDelete: true)
                .Index(t => t.PassportId);
            
            CreateTable(
                "dbo.Passports",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Series = c.Int(nullable: false),
                        Number = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "PassportId", "dbo.Passports");
            DropIndex("dbo.Employees", new[] { "PassportId" });
            DropTable("dbo.Passports");
            DropTable("dbo.Employees");
        }
    }
}
