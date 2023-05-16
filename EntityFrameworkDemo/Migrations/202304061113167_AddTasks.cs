namespace EntityFrameworkDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTasks : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tasks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(unicode: false),
                        ProjectId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Projects", t => t.ProjectId, cascadeDelete: true)
                .Index(t => t.ProjectId);
            
            AlterColumn("dbo.Projects", "Name", c => c.String(maxLength: 50, storeType: "nvarchar"));
            CreateIndex("dbo.Projects", "Name", unique: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tasks", "ProjectId", "dbo.Projects");
            DropIndex("dbo.Tasks", new[] { "ProjectId" });
            DropIndex("dbo.Projects", new[] { "Name" });
            AlterColumn("dbo.Projects", "Name", c => c.String(unicode: false));
            DropTable("dbo.Tasks");
        }
    }
}
