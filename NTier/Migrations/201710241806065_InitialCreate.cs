namespace NTier.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.epics",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Notes = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.iterations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Start = c.DateTime(nullable: false),
                        Description = c.String(),
                        Notes = c.String(),
                        Project_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.releases", t => t.Project_Id)
                .Index(t => t.Project_Id);
            
            CreateTable(
                "dbo.releases",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Start = c.DateTime(nullable: false),
                        IterationCount = c.Int(nullable: false),
                        Description = c.String(),
                        Notes = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.stories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IterationBase_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.iterations", t => t.IterationBase_Id)
                .Index(t => t.IterationBase_Id);
            
            CreateTable(
                "dbo.projects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Start = c.DateTime(nullable: false),
                        ReleaseCount = c.Int(nullable: false),
                        Description = c.String(),
                        Notes = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.stories", "IterationBase_Id", "dbo.iterations");
            DropForeignKey("dbo.iterations", "Project_Id", "dbo.releases");
            DropIndex("dbo.stories", new[] { "IterationBase_Id" });
            DropIndex("dbo.iterations", new[] { "Project_Id" });
            DropTable("dbo.projects");
            DropTable("dbo.stories");
            DropTable("dbo.releases");
            DropTable("dbo.iterations");
            DropTable("dbo.epics");
        }
    }
}
